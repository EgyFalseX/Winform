/*
	edxClientlessPrototype
	By: pushedx
	http://edxLabs.com

	This framework represents an experimental architecture for a clientless
	framework. There is quite a bit of code, so please read over it all before
	you start trying to modify anything.

	Take the time to understand how the cEntity class is setup since that design
	is what this clientless is based upon. New advanced packet building and reading
	classes are provided, so be sure to understand how those are used as well.

	Also included is a simple plugin system as always to allow for flexible and
	rapid development. Plugins are loaded from a folder named 'plugins'. Plugins
	are automatically loaded from the folder 'plugins/autoload', just like SR33
	and edx33 were done. Be sure to copy over your plugins into the approporiate
	folder after building them.

	This is being released "as-is" and no support will be given. It is up to
	your imagination to turn this framework into something more interesting ;)
	You will be required to read through the source to understand all the commands
	and how it all works together.

	Enjoy!
*/
//-----------------------------------------------------------------------------

#define _CRT_SECURE_NO_WARNINGS

#include "edxTCPNetwork.h"
#include "StreamBuilder.h"
#include "StreamReader.h"
#include "Entity.h"
#include "HandShakeApi.h"
#include <windows.h>
#include <wchar.h>
#include <fstream>
#include <iostream>
#include <sstream>
#include <string>
#include <vector>
#include <time.h>
#include "SilkroadPacket.h"
#include "zlib/zlib.h"
#include "Console.h"
#include "reader.h"
#include "playerclass.h"
using namespace std;
namespace con = JadedHoboConsole;
//-----------------------------------------------------------------------------

struct tPlugin
{
	// The handle to the plugin
	HMODULE hDLL;

	// Setup function for internal use
	void (*onSetup)(cEntity *, void (*)(unsigned short, unsigned char *, bool));

	// Core plugin event functions
	void (*onLoad)(void);
	void (*onUnload)(void);

	// Command function
	void (*onInput)(const char *);

	// Packet event functions
	void (*onServerToClient)(tSilkroadPacketHeader * header, LPBYTE data);

	// Function when the timer is called
	void (*onTimer)();
};
//-----------------------------------------------------------------------------

// Tokenizes a string into a vector
std::vector<std::string> TokenizeString(const std::string & str, const std::string & delim);

// Saves raw data as a BMP
int WriteBitmapFile(const char *filename, int width, int height, unsigned char *imageData);

// Loads a plugin
bool LoadPlugin(cEntity & classData, void (*InjectClientToServerFunc)(unsigned short, unsigned char *, bool), const char * filename, const char * refname);

// Unloads a plugin
bool UnloadPlugin(const char * refname);

// The callback function for when a file is found in the plugins folder
void OnAutoLoadPlugin(const char * filename);

// This function will find all *.ext files and call UserFunc with the file name.
void FindAllFiles(const char* searchThisDir, bool searchSubDirs, void (*UserFunc)(const char*));
//-----------------------------------------------------------------------------

// Template function to convert a string into any datatype
template <class type>
type StringToNumber(std::string strNumber)
{
	type number;
	std::stringstream ss;
	ss << strNumber;
	ss >> number;
	return number;
}

//-----------------------------------------------------------------------------

// Template function to convert a string into any datatype
template <class type>
std::string NumberToString(type number)
{
	std::stringstream ss;
	ss << number;
	return ss.str();
}

//-----------------------------------------------------------------------------

// This class represents the simplest client class you may have.
class SilkroadClientless : public edx::TCPClient
{
private:
	// Protect multithreaded access
	CRITICAL_SECTION cs;

	// Our SRO security object
	cHandShakeApi * HandShakeApi;

	// Workspace to process packets
	LPBYTE streamBuffer;

	// Interface ptr for the client
	edx::TCPClientInterface * interface_ptr;

public:
	// The entity for this class
	cEntity classData;

public:
	// Default ctor
	SilkroadClientless();

	// Default dtor
	~SilkroadClientless();

	// User function called when a client connects to the server
	bool TCPOnConnect(edx::TCPClientInterface * client, const CHAR * ip, WORD port);

	// User function called when a client sends data to the server. Should return -1
	// if the stream of data is not processable (needs more data) or a value > 0
	// that represents how much data was processed.
	int TCPOnProcessStream(edx::TCPClientInterface * client, WORD size, LPBYTE stream);

	// User function called when a client closes the connection
	void TCPOnClose(edx::TCPClientInterface * client);

	// User function called when a client encounters an error on the server 
	// (not required, but a good idea)
	void TCPOnError(edx::TCPClientInterface * client, CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error);

	// Inject a packet into the server
	void InjectClientToServer(unsigned short size, unsigned char * stream, bool encrypted);

	// Function called when a complete packet has been received
	void OnServerToClient(tSilkroadPacketHeader * header, LPBYTE data);

	// Function called when the timer is invoked as define in the edxTCPNetwork module
	void OnTimer();
};

SilkroadClientless * clientless = 0;
std::map<std::string, tPlugin> plugins;
CRITICAL_SECTION pcs;

//-----------------------------------------------------------------------------

int SILKROAD_SPAWN_PACKET;
int SILKROAD_VERSION;
int spmade = 0;
int sptemp = 0;
int xpmade = 0;
int xptemp = 0;
int lvlups = 0;
int masteryups = 0;
int tempnextlvlxp = 0;
DWORD id = 0;
char hrs = 0;
char mins = 0;
unsigned char zähler = 0;
unsigned char counter = 0;
string charname;
char cnames[50];
const char *title = " CL Powerlevel tool by Painfull";
//-----------------------------------------------------------------------------

// Inject a packet into the server
void GlobalInjectClientToServer(unsigned short size, unsigned char * stream, bool encrypted)
{
	clientless->InjectClientToServer(size, stream, encrypted);
}
//-----------------------------------------------------------------------------
int main(int argc, char * argv[])
{
	// Reading version and Spawn Packet op Code

	SetConsoleTitleA("CL Powerlevel tool by Painfull");
	con::bgHiYellow;
	char tempversion[4];
	int spawn;
	// Reading data from ini method 1
	ifstream infile("clientless.ini");
	infile.seekg(10,ios::beg);
	infile.seekg(10,ios::cur);
	infile.getline(tempversion,100);
	SILKROAD_VERSION = static_cast<int>(strtol(tempversion, NULL, 10));
	char test[1024];
	char inipath[1024];
	// Reading data from ini method 2
	char ini[50] = "\\clientless.ini";
	GetCurrentDirectory(100, inipath);
	strcat( inipath, ini);
	GetPrivateProfileString("settings","spawn","NULL",test,sizeof(test),inipath);
    SILKROAD_SPAWN_PACKET = static_cast<int>(strtol(test, NULL, 16));
	cout << con::fg_blue << "Silkroad Version: " << SILKROAD_VERSION <<
		"\nSpawn OP Code: " << std::hex << SILKROAD_SPAWN_PACKET << "\n";

	cout << con::fg_blue << "Is this the right OP CODE ?\n";
	cout << con::fg_green << "(in the OP Code all Big letter will be shown as small letter)\n";
	cout << con::fg_green << "(example: 0x36A8 will be displayed 36a8)\n";
	cout << con::fg_white << "1: Yes\n";
	cout << con::fg_red << "2: No\n";
	cin>>spawn;
	if(spawn == 1)
	{
		cout << con::fg_yellow << "OK!\n";
	}
	else if(spawn == 2)
	{
		cout << con::fg_yellow << "The Program will continue now,"
			<< "but with a highly banrisk\n";
	}
	else
	{
		exit(1);
	}

	// Build the folder to the autoloaded plugins directory
	char autoLoadDir[MAX_PATH  + 1] = {0};
	GetCurrentDirectory(MAX_PATH, autoLoadDir);
	strcat(autoLoadDir, "\\plugins\\autoload");
	InitializeCriticalSection(&pcs);
	srand(GetTickCount());
	if(edx::InitializeWinsock(2, 2) == false)
	{
		printf("Could not initialize the Winsock interface.\n");
		return 0;
	}
	clientless = new SilkroadClientless;
	FindAllFiles(autoLoadDir, true, OnAutoLoadPlugin);
	printf("Attempting to connect to gwgt1.joymax.com...\n");
	if(clientless->Connect("gwgt1.joymax.com", 15779) == false)
	{
		printf("Connection to gwgt1.joymax.com failed.\n");
		printf("Attempting to connect to gwgt2.joymax.com...\n");
		if(clientless->Connect("gwgt2.joymax.com", 15779) == false)
		{
			printf("Connection to gwgt2.joymax.com failed.\n");
			printf("Could not connect to any of the Silkroad login servers.\n");
			edx::DeinitializeWinsock();
			return 0;
		}
		printf("Connection to gwgt2.joymax.com successful.\n");
	}
	else
	{
		printf("Connection to gwgt1.joymax.com successful.\n");
	}

	while(1)
	{
		std::string command;
		std::getline(std::cin, command);
		if(command == "quit") break;
		else if(command == "exit") break;
		//
		else if(command == "cls") system("cls");
		else
		{
			std::vector<std::string> tokens = TokenizeString(command, " ");
			if(tokens.size() >= 2)
			{
				if(tokens[0] == "/load")
				{
					if(tokens.size() == 3)
					{
						std::string pgnname = "plugins/";
						pgnname += tokens[1];
						bool result = LoadPlugin(clientless->classData, GlobalInjectClientToServer, pgnname.c_str(), tokens[2].c_str());
						if(result) printf("The plugin has been successfully loaded.\n");
					}
					else
					{
						printf("Usage: /load plugin.dll refname\n");
					}
					continue;
				}
				else if(tokens[0] == "/unload")
				{
					if(tokens.size() == 2)
					{
						bool result = UnloadPlugin(tokens[1].c_str());
						if(result) printf("The plugin has been successfully unloaded.\n");
					}
					else
					{
						printf("Usage: /unload refname\n");
					}
					continue;
				}

				// Party join function

				else if(tokens[0] == ".party") {
					if(tokens.size() == 2) {
					unsigned short  party_nr;
					cStreamBuilder  build;
					party_nr = strtoul( tokens[1].c_str(), 0, 10 ) & 0xffff;
					build.SetOpcode( 0x7588 );
					build.Append<unsigned char>( 0x00 );
					GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
					build.Reset();
					build.SetOpcode( 0x75BF );
					build.Append<unsigned short>( party_nr );
					build.Append<unsigned char>( 0x00 );
					build.Append<unsigned char>( 0x00 );
					GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
					}
					else
					{
						printf("Usage: .party partynumber\n");
					}
					continue;
				  }

				// Trace Function
				
				else if(tokens[0] == ".trace") {
					if(tokens.size() == 2) {
					DWORD charid;
					cStreamBuilder  build;
					charid = strtoul( tokens[1].c_str(), 0, 16 ) & 0xffffffff;
					// Select Packet
					build.SetOpcode( 0x745A );
					build.Append<DWORD>( charid );
					GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
					build.Reset();
					// Trace Packet
					build.SetOpcode( 0x72CD );
					build.Append<unsigned char>( 0x01 );
					build.Append<unsigned char>( 0x03 );
					build.Append<unsigned char>( 0x01 );
					build.Append<DWORD>( charid );
					GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
					}
					else
					{
						printf("Usage: .trace charid\n");
					}
					continue;
				}
				// Message system
				
				else if(tokens[0] == ".message") {
					wchar_t wmessage[150] = {0};
					char message[150] = {0};
					string temp;
					char tempor[150];
					int count = 0;
					int blub = 0;
					unsigned int i;
					int a = 0;
					if(tokens.size() > 2)
					{
						if(tokens[1] != "all")
						{
							for(i = 2; i < tokens.size(); ++i)
							{
								if(i != 2)
								{
									strcat(message, " ");
								}
								memcpy(tempor,tokens[i].c_str(),sizeof(tokens[i]));
								strcat(message, tempor);
							}
						}
						else
						{
							for(i = 3; i < tokens.size(); ++i)
							{
								if(i != 3)
								{
									strcat(message, " ");
								}
								memcpy(tempor,tokens[i].c_str(),sizeof(tokens[i]));
								strcat(message, tempor);
							}
						}
						wchar_t buffer[1024] = {0};
						mbstowcs(wmessage,message,150);
						while (message[a]!='\0')
						{
						counter++;
						a++;
						}
					if(tokens[1] == "pm")
					{
						int y = 0;
						unsigned short counters = 0;
						char player[1024];
						memcpy(player,tokens[2].c_str(),sizeof(tokens[2]));
						while (player[y]!='\0')
						{
						counters++;
						y++;
						}
						cStreamBuilder build;
						build.SetOpcode( 0x7367 );
						build.Append<unsigned char>( 0x02 );
						build.Append<unsigned char>( zähler );
						build.Append<unsigned short>(counters);
						build.AppendArray(player,counters);
						build.Append<unsigned short>(counter);
						build.AppendArray(wmessage,counter);
						GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
						zähler++;
					}
					else if(tokens[1] == "guild")
					{
						cStreamBuilder build;
						build.SetOpcode( 0x7367 );
						build.Append<unsigned char>( 0x05 );
						build.Append<unsigned char>( zähler );
						build.Append<unsigned short>(counter);
						build.AppendArray(wmessage,counter);
						GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
						zähler++;
					}
					else if(tokens[1] == "union")
					{
						cStreamBuilder build;
						build.SetOpcode( 0x7367 );
						build.Append<unsigned char>( 0x0B );
						build.Append<unsigned char>( zähler );
						build.Append<unsigned short>(counter);
						build.AppendArray(wmessage,counter);
						GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
						zähler++;
					}
					else if(tokens[1] == "all")
					{
						cStreamBuilder build;
						build.SetOpcode( 0x7367 );
						build.Append<unsigned char>( 0x01 );
						build.Append<unsigned char>( zähler );
						build.Append<unsigned short>(counter);
						build.AppendArray(wmessage,counter);
						GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
						zähler++;					
					}
					else if(tokens[1] == "party")
					{
						cStreamBuilder build;
						build.SetOpcode( 0x7367 );
						build.Append<unsigned char>( 0x04 );
						build.Append<unsigned char>( zähler );
						build.Append<unsigned short>(counter);
						build.AppendArray(wmessage,counter);
						GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
						zähler++;
					}
					else
					{
					printf("Usage: .trace charid\n");
					}
					} // if tokens size
					else
					{
					printf("Usage: .trace charid\n");
					}
					continue;
				}
				
				// Mastery Uppen

				else if(tokens[0] == ".mastery") {
					if(tokens.size() == 2) {
						if(tokens[1] == "bicheon")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery bicheon upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "heuksal")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery heuksal upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "pacheon")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x03 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery pacheon upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "cold")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x11 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery cold upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "lightning")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x12 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery lightning upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "fire")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x13 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery fire upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "force")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x14 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery force upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "warrior")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x01 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery warrior upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "wizard")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery wizard upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "rogue")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x03 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery rogue upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "warlock")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x04 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery warlock upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "bard")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x05 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery bard upped\n");
							masteryups = masteryups+1;
						}
						else if(tokens[1] == "cleric")
						{
							cStreamBuilder  build;
							build.SetOpcode( 0x7165 );
							build.Append<unsigned char>( 0x06 );
							build.Append<unsigned char>( 0x02 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x00 );
							build.Append<unsigned char>( 0x01 );
							GlobalInjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
							printf("Mastery cleric upped\n");
							masteryups = masteryups+1;
						}
						else
						{
						printf("Usage: .mastery mastery\n");
						}
					continue;
				}
				else
				{
					printf("Usage: .mastery mastery\n");
				}
				}
				}

			tokens = TokenizeString(command, "=");
			if(tokens.size() == 2)
			{
				clientless->classData.SetString(tokens[0], tokens[1]);
			}
			tokens = TokenizeString(command, ":");
			if(tokens.size() == 2)
			{
				if(tokens[1].find_first_of('.') != std::string::npos)
					clientless->classData.SetDecimal(tokens[0], StringToNumber<double>(tokens[1]));
				else
					clientless->classData.SetNumber(tokens[0], StringToNumber<long>(tokens[1]));
			}
			EnterCriticalSection(&pcs);
				std::map<std::string, tPlugin>::iterator itr = plugins.begin();
				while(itr != plugins.end())
				{
					itr->second.onInput(command.c_str());
					++itr;
				}
			LeaveCriticalSection(&pcs);
		}
	}
	clientless->Disconnect();
	clientless->Destroy();
	edx::DeinitializeWinsock();
	DeleteCriticalSection(&pcs);
	delete clientless;
	return 0;
}
//-----------------------------------------------------------------------------
// Default ctor
SilkroadClientless::SilkroadClientless()
{
	HandShakeApi = 0;
	streamBuffer = new BYTE[8192];
	memset(streamBuffer, 0, 8192);
	interface_ptr = 0;
	InitializeCriticalSection(&cs);
	classData.SetNumber("DoPingPacket", false);
	classData.SetNumber("PingPacketDelay", 5000);
	classData.SetNumber("DoRequestStats", false);
	classData.SetNumber("ServerCount", 0);
	classData.SetString("name", "");
	classData.SetString("pass", "");
	classData.SetString("server", "");
	classData.SetString("action", "");
	classData.SetString("state", "");
}

//-----------------------------------------------------------------------------

// Default dtor
SilkroadClientless::~SilkroadClientless()
{
	delete [] streamBuffer;
	DeleteCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// User function called when a client connects to the server
bool SilkroadClientless::TCPOnConnect(edx::TCPClientInterface * client, const CHAR * ip, WORD port)
{
	if(HandShakeApi) delete HandShakeApi;
	HandShakeApi = new cHandShakeApi;
	HandShakeApi->SetRandomNumber(0x33);
	interface_ptr = client;
	return true;
}

//-----------------------------------------------------------------------------

// User function called when a client sends data to the server. Should return -1
// if the stream of data is not processable (needs more data) or a value > 0
// that represents how much data was processed.
int SilkroadClientless::TCPOnProcessStream(edx::TCPClientInterface * client, WORD size, LPBYTE stream)
{
	tSilkroadPacketHeader * header = (tSilkroadPacketHeader*)stream;
	int packet_size = 0;
	bool encrypted = false;

	if(header->size & 0x8000)
	{
		packet_size = HandShakeApi->blowfish.GetOutputLength((header->size & 0x7FFF) + 4) + 2;
		encrypted = true;
	}
	else
	{
		packet_size = header->size + 6;
	}

	// See if we have a full packet yet
	if(packet_size > size)
		return -1;

	// If the packet is encrypted, fix the size and decrypt it
	if(encrypted)
	{
		header->size &= 0x7FFF;
		HandShakeApi->blowfish.Decode(stream + 2, stream + 2, packet_size - 2);
	}

	// Copy the entire packet into our buffer
	memcpy(streamBuffer, stream, header->size + 6);

	// Call the function to process the packet
	OnServerToClient(header, stream + 6);

	// Returns how many bytes were processed
	return packet_size;
}

//-----------------------------------------------------------------------------

// User function called when a client closes the connection
void SilkroadClientless::TCPOnClose(edx::TCPClientInterface * client)
{
	try
	{
		printf("The connection to the %s has been lost.\n", classData.GetString("ServerType").c_str());
	}
	catch (std::exception & e)
	{
		printf("%s\n", e.what());
		printf("The connection has been lost.\n");
	}
}

//-----------------------------------------------------------------------------

// User function called when a client encounters an error on the server 
// (not required, but a good idea)
void SilkroadClientless::TCPOnError(edx::TCPClientInterface * client, CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error)
{
}

//-----------------------------------------------------------------------------

// Inject a packet into the server
void SilkroadClientless::InjectClientToServer(unsigned short size, unsigned char * stream, bool encrypted)
{
	// Multithreaded access
	EnterCriticalSection(&cs);

	// Size of the packet
	unsigned short realSize = size;

	// Temp buffer
	BYTE tmpBuffer[8192];

	// Copy over the packet to send
	memcpy(tmpBuffer, stream, realSize);

	// Make a packet pointer
	tSilkroadPacketHeader * tmpPacket = (tSilkroadPacketHeader *)tmpBuffer;

	// Fix the size if it's encrypted
	if(encrypted)
		tmpPacket->size |= 0x8000;

	// Generate count byte
	tmpPacket->securityCount = HandShakeApi->GenerateCountByte();

	// Generate CRC byte
	tmpPacket->securityCRC = 0;
	tmpPacket->securityCRC = HandShakeApi->GenerateCheckByte((char*)tmpBuffer, realSize, HandShakeApi->GetCRCSeed());

	// Check to see if we need to encode the packet
	if(encrypted)
	{
		// Get blowfish data size
		unsigned short bfSize = (unsigned short)HandShakeApi->blowfish.GetOutputLength(realSize - 2);

		// Encode the packet
		HandShakeApi->blowfish.Encode((BYTE*)tmpBuffer + 2, (BYTE*)tmpBuffer + 2, realSize - 2);

		// Forward the packet
		Send(bfSize + 2, tmpBuffer);
	}
	else
	{
		// Forward the packet
		Send(realSize, tmpBuffer);
	}

	// Multithreaded access
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------


// Function called when a complete packet has been received
void SilkroadClientless::OnServerToClient(tSilkroadPacketHeader * header, LPBYTE data)
{
	// Handshake - do not need to pass this one
	if(header->opcode == 0x5000)
	{
		// Generate the response packets (data is 6 bytes after header in 
		// the same buffer, so this works in this case)
		std::pair<int, unsigned char *> * ptr = HandShakeApi->OnPacketRecv((LPBYTE)header);

		// Failed
		if(ptr == 0)
		{
			Disconnect();
			return;
		}

		// We need to do a raw Send rather than InjectClientToServer since it is the
		// handshake process
		Send(ptr->first, ptr->second);

		// Free buffer memory
		delete [] ptr->second;

		// Free pair memory
		delete ptr;
	}
	else
	{
		// If you wanted to dump all packet data to the console
		/*printf("[%X][%i bytes]\n", header->opcode, header->size);
		for(int x = 0; x < header->size; ++x)
		{
			BYTE b = data[x];
			printf("%.2X ", b);
			if((x + 1) % 16 == 0 && x + 1 < header->size)
				printf("\n");
		}
		printf("\n");*/

		// Stream reading object
		cStreamReader reader(data, header->size);

	// Login server specific

		// Server identify packet
		if(header->opcode == 0x2001)
		{
			WORD nameLength = reader.Read<WORD>();
			char * nameData = new char[nameLength + 1];
			memset(nameData, 0, nameLength + 1);
			reader.ReadArray(nameData, nameLength);
			std::string name = nameData;
			delete [] nameData;
			classData.SetString("ServerType", name);
			if(name == "GatewayServer")
			{
				//printf("Connecting to a %s\n", name.c_str());
				
				
				cStreamBuilder response;
				response.SetOpcode(0x6100);
				response.Append<BYTE>(18); // Locale: 18 = iso, 4 = csro/ecsro, 2 = ksro, 23 = vsro, 12 = tsro
				response.Append<WORD>(9);
				response.AppendArray<const char>("SR_Client", 9);
				response.Append<DWORD>(SILKROAD_VERSION);

				InjectClientToServer(response.GetTotalSize(), response.GetPacket(), true);

				classData.SetNumber("DoPingPacket", true);
				classData.SetNumber("PingPacketDelay", 5000);
				classData.SetNumber("600D", 0);
			}
			else if(name == "AgentServer")
			{
				//printf("Connecting to a %s\n", name.c_str());

				BYTE mac[6] = {0};

				// Multiclient

				for(int x = 0; x < 6; ++x)
				{
					srand ( time(NULL) );
					mac[x] = rand() % 256;
				}
				/*for(int x = 0; x < 6; ++x)
					mac[x] = rand() % 256;*/
				
				DWORD loginid = classData.GetNumber("LoginId");
				std::string uname = classData.GetString("name");
				std::string upass = classData.GetString("pass");

				cStreamBuilder response;
				response.SetOpcode(0x6103);
				response.Append<DWORD>(loginid);
				response.Append<WORD>((WORD)uname.size());
				response.AppendArray<const char>(uname.c_str(), (WORD)uname.size());
				response.Append<WORD>((WORD)upass.size());
				response.AppendArray<const char>(upass.c_str(), (WORD)upass.size());
				response.Append<BYTE>(18);
				response.AppendArray(mac, 6);
				InjectClientToServer(response.GetTotalSize(), response.GetPacket(), true);

				classData.SetNumber("PingPacketDelay", 5000);
				classData.SetNumber("DoPingPacket", true);
				classData.SetNumber("600D", 0);

				printf("Sending your login credentials to the world server...\n");
			}
			else
			{
				printf("Do not know how to handle a connection to %s.\n", name.c_str());
				Disconnect();
			}
		}
		// Patch information
		else if(header->opcode == 0x600D)
		{
			// Add to the patch packet count
			if(classData.ModifyNumber("600D", 1) == 6)
			{
				BYTE operation = reader.Read<BYTE>();
				BYTE mode = reader.Read<BYTE>();
				if(operation == 0 && mode == 1)
				{
					classData.SetNumber("DoRequestStats", true);
					printf("To login please execute the following commands in order:\n\tname=your account name\n\tpass=your account pass\n\tserver=your account server\n\taction=login\n");
					classData.SetString("state", "WaitForLogin");
				}
				else
				{
					printf("The version number sent to the server is too old.\n");
					Disconnect();
				}
			}
		}
		// Server stats
		else if(header->opcode == 0xA101)
		{
			// Length and name of server
			WORD len = 0;
			char name[1024] = {0};

			reader.Read<BYTE>();	// 0x01
			reader.Read<BYTE>();	// 0x15
			len = reader.Read<WORD>();	// Name length
			reader.ReadArray<char>(name, len > 1023 ? 1023 : len);
			reader.Read<BYTE>();	// 0x00

			int sIndex = 0;
			int sCount = 0;
			bool update = false;
			sCount = classData.GetNumber("ServerCount");
			if(sCount)
				update = true;

			// A new server?
			BYTE b = reader.Read<BYTE>();
			while(b)
			{
				memset(name, 0, 1024);

				// Workspace for class data values
				char workspace[1024] = {0};

				// Server id
				WORD serverId = reader.Read<WORD>();

				// Server name
				len = reader.Read<WORD>();
				reader.ReadArray(name, len > 1023 ? 1023 : len);

				// Chop off the (NEW) tag
				for(size_t x = 0; x < strlen(name); ++x)
				{
					if(name[x] == '(')
					{
						name[x] = 0;
						break;
					}
				}

				// Convert to lower case
				for(size_t x = 0; x < strlen(name); ++x)
				{
					name[x] = tolower(name[x]);
				}

				// Read stats
				WORD cur = reader.Read<WORD>();
				WORD max = reader.Read<WORD>();

				// Check or Open
				BYTE state = reader.Read<BYTE>();

				if(update == false)
					classData.ModifyNumber("ServerCount", 1);

				_snprintf(workspace, 1023, "Server_Name_%i", sIndex);
				classData.SetString(workspace, name);

				_snprintf(workspace, 1023, "Server_Id_%i", sIndex);
				classData.SetNumber(workspace, serverId);

				_snprintf(workspace, 1023, "Server_Cur_%i", sIndex);
				classData.SetNumber(workspace, cur);

				_snprintf(workspace, 1023, "Server_Max_%i", sIndex);
				classData.SetNumber(workspace, max);

				_snprintf(workspace, 1023, "Server_State_%i", sIndex);
				classData.SetNumber(workspace, state);

				_snprintf(workspace, 1023, "Server_Index_%s", name);
				classData.SetNumber(workspace, sIndex);

				// A new server?
				b = reader.Read<BYTE>();

				// Next server index
				sIndex++;
			}
		}
		// Login response
		else if(header->opcode == 0xA102)
		{
			BYTE result = reader.Read<BYTE>();
			if(result == 1)
			{
				char * world_name = 0;

				// Read packet info
				DWORD loginId = reader.Read<DWORD>();
				WORD len = reader.Read<WORD>();

				// Allocate memory for the world name
				world_name = new char[len + 1];
				memset(world_name, 0, len + 1);

				reader.ReadArray<char>(world_name, len);
				WORD world_port = reader.Read<WORD>();

				// Remove ping packet
				classData.SetNumber("DoPingPacket", false);

				// Remove server stats packet
				classData.SetNumber("DoRequestStats", false);

				// We are now joining the world server
				classData.SetNumber("IntoWorldServer", true);

				// Disconnect from the login server
				Disconnect();

				classData.SetNumber("LoginId", loginId);
				classData.SetString("LoginIp", world_name);
				classData.SetNumber("LoginPort", world_port);

				printf("Attempting to connect to the world server %s:%i...\n", world_name, world_port);
				if(Connect(world_name, world_port, false) == false) //
				{
					printf("Could not establish a connection to the world server.\n");

					classData.SetNumber("DoPingPacket", false);
					classData.SetNumber("DoRequestStats", false);
					classData.SetNumber("ServerCount", 0);
					classData.SetString("name", "");
					classData.SetString("pass", "");
					classData.SetString("server", "");
					classData.SetString("action", "");
					classData.SetString("state", "");

					printf("Attempting to connect to gwgt1.joymax.com...\n");
					if(Connect("gwgt1.joymax.com", 15779) == false)
					{
						printf("Connection to gwgt1.joymax.com failed.\n");
						printf("Attempting to connect to gwgt2.joymax.com...\n");
						if(Connect("gwgt2.joymax.com", 15779) == false)
						{
							printf("Connection to gwgt2.joymax.com failed.\n");
							printf("Could not connect to any of the Silkroad login servers.\n");
							printf("Please type \"exit\" and rerun the application.\n");
						}
						printf("Connection to gwgt2.joymax.com successful.\n");
					}
					else
					{
						printf("Connection to gwgt1.joymax.com successful.\n");
					}
				}
				else
				{
					printf("Now connected to the world server.\nPlease wait for the login process to complete.\n");
				}

				// Free memory
				delete [] world_name;
			}
			else if(result == 2)
			{
				// Get the error mode
				BYTE mode = reader.Read<BYTE>();

				// Wrong password
				if(mode == 1)
				{
					DWORD curTry;
					DWORD maxTry;
					maxTry = reader.Read<DWORD>();
					curTry = reader.Read<DWORD>();
					printf("The password you entered was not correct.\nYou have %i attempts left.\n", maxTry - curTry);
				}

				// Block reason
				else if(mode == 2)
				{
					mode  = reader.Read<BYTE>();
					if(mode == 1)
					{
						char * error2 = 0;
						WORD len = reader.Read<WORD>();
						error2 = new char[len + 1];
						memset(error2, 0, len + 1);
						reader.ReadArray(error2, len);
						printf("%s", error2);
						delete [] error2;
					}
					else
					{
						printf("There was an error logging into this account. Error Code: %i.\n", mode);
					}
				}

				// C7 error
				else if(mode == 6)
				{
					printf("C7 Error. Joymax login servers having troubles. Please wait until this problem is fixed.\n");
				}

				// Already connected
				else if(mode == 3)
				{
					printf("This account is already connected. Please wait a few minutes to login again if you were just disconnected or choose a new account to login with.\n", mode);
				}

				// Unhandled error code
				else
				{
					printf("There was an error logging into this account. Error Code: %i.\n", mode);
				}

				printf("To login please execute the following commands in order:\n\tname=your account name\n\tpass=your account pass\n\tserver=your account server\n\taction=login\n");
				classData.SetString("state", "WaitForLogin");
			}
		}
		// Image code
		else if(header->opcode == 0x2322)
		{
			DWORD image[200 * 64] = {0};
			int imgIndex = 0;
			BYTE b1 = 0;
			WORD w1 = 0;
			WORD compressed = 0;
			WORD uncompressed = 0;
			DWORD width = 0;
			DWORD height = 0;
			LPBYTE ptr = 0;
			DWORD outLen = 0;
			unsigned char rawbytes_[131072] = {0};
			unsigned char * rawbytes = rawbytes_;

			b1 = reader.Read<BYTE>();
			w1 = reader.Read<WORD>();
			compressed = reader.Read<WORD>();
			uncompressed = reader.Read<WORD>();
			width = reader.Read<WORD>();
			height = reader.Read<WORD>();

			ptr = reader.GetCurrentStream();

			outLen = uncompressed;
			if(uncompress((Bytef*)rawbytes, &outLen, ptr, compressed) != Z_OK)
			{
				printf("Could not uncompress the image code.\n");
				Disconnect();
				return;
			}

			// Loop through the data
			for(int c = 0; c < (int)height; ++c)
			{
				for(int r = 0; r < (int)width; ++r)
				{
					imgIndex = (height - 1 - c) * width + r;
					image[imgIndex] = 0xFF000000;
					if(-((1 << (0xFF & (r & 0x80000007))) & rawbytes[((c * width + r) >> 3)])) 
						image[imgIndex] = 0xFFFFFFFF;
				}
			}

			char filename[MAX_PATH + 1] = {0};
			// Save the image code
			_snprintf(filename, MAX_PATH, "imagecode.bmp");
			if(!WriteBitmapFile(filename, 200, 64, (unsigned char*)image))
			{
				printf("Could not save the image code to a file.\n");
				Disconnect();
				return;
			}
			printf("The image code has been received\n");
			ShellExecute(0,0,"ImageViewer.exe","imagecode.bmp",0,0);
			printf("To enter the image code, please execute the following commands in order:\n\tcode=The image code\n\taction=imagecode\n");
		}

		// Image code results
		else if(header->opcode == 0xA323)
		{
			DeleteFile("imagecode.bmp");
			BYTE result = reader.Read<BYTE>();
			if(result == 1)
			{
				printf("The image code has been successfully entered!\n");
			}
			else if(result == 2)
			{
				DWORD curTry;
				DWORD maxTry;
				maxTry = reader.Read<DWORD>();
				curTry = reader.Read<DWORD>();
				printf("The image code was not correct.\nYou have %i attempts left.\n", maxTry - curTry);
			}
		}

	// World server specific

		// World server response
		else if(header->opcode == 0xA103)
		{
			BYTE mode = reader.Read<BYTE>();

			// Success
			if(mode == 1)
			{
				// Clear out the data
				classData.SetString("name", "");
				classData.SetString("pass", "");

				printf("Login to the world server was successful!\nNow requesting the character listing...\n");

				// Request character listing
				cStreamBuilder response;
				response.SetOpcode(0x72F7);
				response.Append<BYTE>(0x02);
				InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
			}

			// Error
			else if(mode == 2)
			{
				mode = reader.Read<BYTE>();
				// Server traffic
				if(mode == 4)
				{
					printf("Could not connect due to server traffic. Please wait for another connection.\n");
				}
				// C9 Error
				else if(mode == 1)
				{
					printf("C9 Error (Ping Timeout). Please wait for another connection.\n");
				}
				// C10 Error
				else if(mode == 3)
				{
					printf("C10 Error (Multiclient). Please wait for another connection.\n");
				}
				// Unhandled error
				else
				{
					printf("The world server could not be be logged into, error code: %i. Please wait for another connection.\n", mode);
				}

				classData.SetNumber("DoPingPacket", false);
				classData.SetNumber("DoRequestStats", false);
				classData.SetNumber("ServerCount", 0);
				classData.SetString("name", "");
				classData.SetString("pass", "");
				classData.SetString("server", "");
				classData.SetString("action", "");
				classData.SetString("state", "");

				printf("Attempting to connect to gwgt1.joymax.com...\n");
				if(Connect("gwgt1.joymax.com", 15779) == false)
				{
					printf("Connection to gwgt1.joymax.com failed.\n");
					printf("Attempting to connect to gwgt2.joymax.com...\n");
					if(Connect("gwgt2.joymax.com", 15779) == false)
					{
						printf("Connection to gwgt2.joymax.com failed.\n");
						printf("Could not connect to any of the Silkroad login servers.\n");
						printf("Please type \"exit\" and rerun the application.\n");
					}
					printf("Connection to gwgt2.joymax.com successful.\n");
				}
				else
				{
					printf("Connection to gwgt1.joymax.com successful.\n");
				}
			}
		}

		// Player listing
		else if(header->opcode == 0xB2F7)
		{
			BYTE mode = 0;
			mode = reader.Read<BYTE>(); // Result Mode - 02 (char listing operation)
			if(mode == 2)
			{
				mode = reader.Read<BYTE>(); // 01 = char listing success
				if(mode == 1)
				{
					BYTE count = 0;
					count = reader.Read<BYTE>(); // Count

					printf("Received %i characters in the listing.\n", count);
					for(int x = 0; x < count; ++x)
					{
						DWORD charType;
						WORD charNameLength;
						char cname[32] = {0};
						BYTE volume;
						BYTE level;
						double experience;
						WORD Str;
						WORD Int;
						WORD attributePoints;
						DWORD hp;  // Max hp und Mp ?
						DWORD mp;
						BYTE doDelete;
						DWORD minsToDeletion;
						WORD unk1;
						BYTE unk2;
						BYTE itemCount;
						DWORD item_id;
						BYTE item_plus;
						BYTE endOfItemList;

						charType = reader.Read<DWORD>();
						charNameLength = reader.Read<WORD>();
						reader.ReadArray<char>(cname, charNameLength);
						volume = reader.Read<Byte>();
						level = reader.Read<Byte>();
						experience = reader.Read<DOUBLE>();
						Str = reader.Read<WORD>();
						Int = reader.Read<WORD>();
						attributePoints = reader.Read<WORD>();
						hp = reader.Read<DWORD>();
						mp = reader.Read<DWORD>();
						doDelete = reader.Read<Byte>();
						if(doDelete)
							minsToDeletion = reader.Read<DWORD>();
						unk1 = reader.Read<WORD>();
						unk2 = reader.Read<Byte>();
						itemCount = reader.Read<Byte>();
						for(int y = 0; y < itemCount; ++y)
						{
							item_id = reader.Read<DWORD>();
							item_plus = reader.Read<Byte>();
						}
						endOfItemList = reader.Read<Byte>();
						if(endOfItemList != 0)
						{
							for(int y = 0; y < endOfItemList; ++y)
							{
								item_id = reader.Read<DWORD>();
								item_plus = reader.Read<Byte>();
							}
						}

						printf("\t[%i] %s%s\n", level, cname, doDelete ? " (Being deleted)": "");
					}
					printf("\nTo join the world server please execute the following commands in order:\n\tcharname=your character's name (exact case and spelling)\n\taction=join\n");
				}
			}
		}

		// Character selection packet
		else if(header->opcode == 0xB426)
		{
			BYTE mode = reader.Read<BYTE>();
			if(mode == 1)
			{
				printf("You have successfully joined the Server.\nHave Fun\n");
				strcpy(cnames, charname.c_str());
				strcat(cnames, " / CL Powerlevel tool by Painfull");
				SetConsoleTitleA(cnames);
			}
			else if(mode == 2)
			{
				printf("That character could not join the world server.\n");
				printf("To join the world server please execute the following commands in order:\n\tcharname=your character's name (exact case and spelling)\n\taction=join\n");
			}
		}

		// Character ID
		else if(header->opcode == 0x32A6)
		{
			WORD celestialPosition = 0;
			

			id = reader.Read<DWORD>();
			celestialPosition = reader.Read<WORD>();
			hrs = reader.Read<char>();
			mins = reader.Read<char>();

			classData.SetNumber("CharacterId", id);
			classData.SetNumber("JoinCelestialPosition", celestialPosition);
			classData.SetNumber("JoinTimeHours", hrs);
			classData.SetNumber("JoinTimeMinutes", mins);
			classData.SetNumber("JoinTimeRaw", GetTickCount());
		}

		// Start of player packet
		else if(header->opcode == 0x379D)
		{
		}
		// Player packet
		else if(header->opcode == 0x32B3)
		{
			reader.Read<DWORD>(); // Char type
			reader.Read<BYTE>(); // Char hight
			stats.currentlvl = reader.Read<BYTE>(); // current lvl
			reader.Read<BYTE>(); // Highest Lvl
			stats.currentxp = reader.Read<WORD>(); // Current XP
			reader.Read<DWORD>(); // unknown
			reader.Read<BYTE>(); // SP Bar
			reader.Read<BYTE>(); // SP Bar
			reader.Read<DWORD>(); // unknown
			stats.currentgold = reader.Read<long long>(); // Current Gold
			stats.currentsp = reader.Read<DWORD>(); // Current sp
			reader.Read<DWORD>(); // unknown
			reader.Read<WORD>(); // unknown
			reader.Read<DWORD>(); // Max hp
			reader.Read<DWORD>(); // Max MP
			currentlvlupdate(stats.currentlvl);  // set next lvl xp
		}
		// End of player packet
		else if(header->opcode == 0x31DB)
		{
			// Send the spawn packet
			cStreamBuilder response;
			response.SetOpcode(SILKROAD_SPAWN_PACKET);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
		}

		// Exit/Restart client
		else if(header->opcode == 0xB0B7)
		{
			BYTE result = reader.Read<BYTE>();
			if(result == 1)
			{
				BYTE mins = reader.Read<BYTE>();
				BYTE mode = reader.Read<BYTE>();

				printf("%i seconds until logout.\n", mins);
			}
			else if(result == 2)
			{
				printf("Your character cannot currently logout.\n");
			}
		}

		// Final exit/restart packet
		else if(header->opcode == 0x315A)
		{
			printf("Your character has now logged out.\n");
			printf("Please type \"exit\" and rerun the application if you wish to login again.\n");
			Disconnect();
		}

		// Invites ress usw usw usw

		else if(header->opcode == 0x3393) // 02 Share pt
		{
		BYTE mode = reader.Read<BYTE>();
		cStreamBuilder response;
		if(mode == 1) // Exchange 
			{
			response.SetOpcode(0x3457);
			response.Append<BYTE>(0x01);
			response.Append<BYTE>(0x00);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
			}
		else if(mode == 5) // Guild Invite
			{
			// refuse
			response.SetOpcode(0x3393);
			response.Append<BYTE>(0x02);
			response.Append<BYTE>(0x16);
			}
		// mode == 4 is ressurection well its bad coded here
		// i didnt analyzed all the ress packets
		// so it will print succesfully joined even if you got
		// ress, you should add your code here to fix it
		else {
			response.SetOpcode(0x3393);
			response.Append<BYTE>(0x01);
			response.Append<BYTE>(0x01);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
			printf("Succesfully joined a Party\n");
			}
		}
		
		// Xp and SP Update

		else if(header->opcode == 0x30D2)
		{
			
			reader.Read<BYTE>(); // Should be the Current XP
			reader.Read<BYTE>(); // Should be the Current XP
			reader.Read<BYTE>(); // Should be the Current HP
			reader.Read<BYTE>(); // Hits needed?
			xptemp = reader.Read<DWORD>(); // XP got
			sptemp = reader.Read<WORD>(); // SP XP got
			// Current xp sp and lvl updaten
			spmade = (spmade+sptemp);
			xpmade = (xpmade+xptemp);
			xpmade2 = xpmade;
			spmade2 = spmade;
			// checking for a lvl up
			// i found out thats it buggy to
			// cause this here is just for chinese chars,
			// i didnt knew european chars need
			// other xp for lvl ups...
			// you should add your code here
			if((stats.currentxp + xpmade) > nextlvlxp)
			{
				stats.currentlvl = (stats.currentlvl+1);
				cout << "Congratulation, you are lvl " << std::dec << stats.currentlvl << " now\n";
				stats.currentxp = (stats.currentxp-nextlvlxp);
				// Next lvl XP Updaten und lvl ups
				lvlups = (lvlups+1);
				tempnextlvlxp = stats.currentlvl;  //new
				currentlvlupdate(tempnextlvlxp);
			}
			
		}

		else if(header->opcode == 0x343C)
		{
			// i dont know if this data is all right
			// you should check it =)
			reader.Read<DWORD>();  // min phy attack
			reader.Read<DWORD>();  // max phy attack
			reader.Read<DWORD>();  // min mag attack
			reader.Read<DWORD>();  // max mag attack
			reader.Read<WORD>();   // phy def
			reader.Read<WORD>();   // mag def
			reader.Read<WORD>();   // Hit Ratio (+1?)
			reader.Read<WORD>();   // Parry Ratio
			reader.Read<DWORD>();  // Current HP
			reader.Read<DWORD>();  // Current MP
			reader.Read<WORD>();   // Str Points
			reader.Read<WORD>();   // Int Points
		}
		
		// Wenn man Stirbt...
		else if(header->opcode == 0x37CE)
		{
		PlaySound("dead.wav", NULL, SND_FILENAME | SND_ASYNC);
		}

//----------------------------- Chat System ----------------------------------
		else if(header->opcode == 0x3667)
		{
			wchar_t messages[100] = {0};
			char from[40] = {0};
			unsigned short msgsize;
			unsigned short namesize;
			unsigned char mmode = reader.Read<unsigned char>();
			if(mmode == 0x05 || mmode == 5) // Guild
			{
				namesize = reader.Read<unsigned short>();
				char * from = new char[namesize + 1];
				memset(from, 0, namesize + 1);
				reader.ReadArray(from, namesize);
				msgsize = reader.Read<unsigned short>();
				reader.ReadArray<wchar_t>(messages, msgsize);
				printf("%s(Guild):", from);
				//Somehow wprintf with :s wasnt working well
				for(int i = 0; i < msgsize; ++i)
				{
				wprintf(L"%c", messages[i]);
				}
				printf("\n\n");
			}
			else if(mmode == 0x02 || mmode == 2) // PM
			{
				namesize = reader.Read<unsigned short>();
				reader.ReadArray(from, namesize);
				msgsize = reader.Read<unsigned short>();
				reader.ReadArray(messages,msgsize);
				printf("%s(from):", from);
				for(int i = 0; i < msgsize; ++i)
				{
				wprintf(L"%c", messages[i]);
				}
				printf("\n");
			}
			else if(mmode == 0x01 || mmode == 1)  // All Chat
			{
				id = reader.Read<unsigned long>();
				msgsize = reader.Read<unsigned short>();
				reader.ReadArray(messages ,msgsize);
				printf("[Charid]%X(all):", id);
				for(int i = 0; i < msgsize; ++i)
				{
				wprintf(L"%c", messages[i]);
				}
				printf("\n");
			}
			else if(mmode == 0x06 || mmode == 6)
			{
				namesize = reader.Read<unsigned short>();
				reader.ReadArray(from, namesize);
				msgsize = reader.Read<unsigned short>();
				reader.ReadArray(messages,msgsize);
				printf("%s(GLOBAL):", from);
				for(int i = 0; i < msgsize; ++i)
				{
				wprintf(L"%c", messages[i]);
				}
				printf("\n");
			}
			else if(mmode == 0x0B || mmode == 11)
			{
				namesize = reader.Read<unsigned short>();
				reader.ReadArray(from, namesize);
				msgsize = reader.Read<unsigned short>();
				reader.ReadArray(messages,msgsize);
				printf("%s(UNION):", from);
				for(int i = 0; i < msgsize; ++i)
				{
				wprintf(L"%c", messages[i]);
				}
				printf("\n");
			}
			else
			{
				//
			}
		}
//-------------------------- End Of Chat System ------------------------------
		else
		{
			//printf("[Unhandled Packet] %X\n", header->opcode);
		}

		EnterCriticalSection(&pcs);
			std::map<std::string, tPlugin>::iterator itr = plugins.begin();
			while(itr != plugins.end())
			{
				itr->second.onServerToClient(header, data);
				++itr;
			}
		LeaveCriticalSection(&pcs);
	}
}

//-----------------------------------------------------------------------------

// Function called when the timer is invoked as define in the edxTCPNetwork module
void SilkroadClientless::OnTimer()
{
	// Check to see if we should do the ping packet
	if(classData.GetNumber("DoPingPacket"))
	{
		long timeLeft = classData.ModifyNumber("PingPacketDelay", -500);
		if(timeLeft < 0)
		{
			cStreamBuilder response;
			response.SetOpcode(0x2002);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
			classData.SetNumber("PingPacketDelay", 5000);
		}
	}

	// Request server stats
	if(classData.GetNumber("DoRequestStats"))
	{
		// Request server stats
		cStreamBuilder response;
		response.SetOpcode(0x6101);
		InjectClientToServer(response.GetTotalSize(), response.GetPacket(), true);
	}

	// Check to see if the user is ready to login
	if(classData.GetString("action") == "login")
	{
		char workspace[1024] = {0};
		classData.SetString("action", "");
		classData.SetString("state", "Login");

		std::string uname = classData.GetString("name");
		std::string upass = classData.GetString("pass");
		std::string userver = classData.GetString("server");
		std::transform(userver.begin(), userver.end(), userver.begin(), tolower);

		try
		{
			_snprintf(workspace, 1023, "Server_Index_%s", userver.c_str());
			long index = classData.GetNumber(workspace);
			_snprintf(workspace, 1023, "Server_Id_%i", index);
			long serverid = classData.GetNumber(workspace);
			printf("Now sending your login credentials. Please wait for a result or an image code.\n");

			cStreamBuilder response;
			response.SetOpcode(0x6102);
			response.Append<BYTE>(18);
			response.Append<WORD>((WORD)uname.size());
			response.AppendArray<const char>(uname.c_str(), (WORD)uname.size());
			response.Append<WORD>((WORD)upass.size());
			response.AppendArray<const char>(upass.c_str(), (WORD)upass.size());
			response.Append<WORD>((WORD)serverid);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), true);
		}
		catch (std::exception & e)
		{
			printf("%s\n", e.what());
			printf("The server %s was not found. Please try logging again with a valid server.\n", userver.c_str());
			printf("To login please execute the following commands in order:\n\tname=your account name\n\tpass=your account pass\n\tserver=your account server\n\taction=login\n");
			classData.SetString("state", "WaitForLogin");
		}
	}

	// Check to see if the user wants to see the serverstats of a particular server
	else if(classData.GetString("action") == "serverstats")
	{
		char workspace[1024] = {0};
		try
		{
			classData.SetString("action", "");

			std::string userver = classData.GetString("server");
			std::transform(userver.begin(), userver.end(), userver.begin(), tolower);

			_snprintf(workspace, 1023, "Server_Index_%s", userver.c_str());
			long index = classData.GetNumber(workspace);
			
			_snprintf(workspace, 1023, "Server_Id_%i", index);
			long serverid = classData.GetNumber(workspace);

			_snprintf(workspace, 1023, "Server_Cur_%i", index);
			long curSlots = classData.GetNumber(workspace);

			_snprintf(workspace, 1023, "Server_Max_%i", index);
			long maxSlots = classData.GetNumber(workspace);

			printf("[%i] %s - %i / %i\n", serverid, userver.c_str(), curSlots, maxSlots);
		}
		catch (std::exception & e)
		{
			printf("%s\n", e.what());
		}
	}

	// Check to see if the user wants to see the serverstats of all servers
	else if(classData.GetString("action") == "allserverstats")
	{
		char workspace[1024] = {0};
		try
		{
			classData.SetString("action", "");

			long scount = classData.GetNumber("ServerCount");
			for(int x = 0; x < scount; ++x)
			{
				_snprintf(workspace, 1023, "Server_Name_%i", x);
				std::string sname = classData.GetString(workspace);

				_snprintf(workspace, 1023, "Server_Id_%i", x);
				long serverid = classData.GetNumber(workspace);

				_snprintf(workspace, 1023, "Server_Cur_%i", x);
				long curSlots = classData.GetNumber(workspace);

				_snprintf(workspace, 1023, "Server_Max_%i", x);
				long maxSlots = classData.GetNumber(workspace);

				printf("[%i] %s - %i / %i\n", serverid, sname.c_str(), curSlots, maxSlots);
			}
		}
		catch (std::exception & e)
		{
			printf("%s\n", e.what());
		}
	}

	// Check to see if the user wants to enter in the image code
	else if(classData.GetString("action") == "imagecode")
	{
		char workspace[1024] = {0};
		try
		{
			classData.SetString("action", "");

			std::string imagecode = classData.GetString("code");
			classData.SetString("code", "");

			printf("Sending the image code %s...\n", imagecode.c_str());

			cStreamBuilder response;
			response.SetOpcode(0x6323);
			response.Append<WORD>((WORD)imagecode.size());
			response.AppendArray<const char>(imagecode.c_str(), (WORD)imagecode.size());
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
		}
		catch (std::exception & e)
		{
			printf("%s\n", e.what());
			printf("No image code has been entered!\n");
			printf("To the image code, please execute the following commands in order:\n\tcode=the image code\n\taction=imagecode\n");
		}
	}
	
	// Check to see if the user wants to join the world server
	else if(classData.GetString("action") == "join")
	{
		try
		{
			classData.SetString("action", "");
			charname = classData.GetString("charname");
			printf("Attempting to join the world server with character %s...\n", charname.c_str());
			// Select the character to login with
			cStreamBuilder response;
			response.SetOpcode(0x7426);
			response.Append<WORD>((WORD)charname.size());
			response.AppendArray<const char>(charname.c_str(), (WORD)charname.size());
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
		}
		catch(std::exception e)
		{
			printf("No character name has been entered!\n");
			printf("To join the world server please execute the following commands in order:\n\tcharname=your character's name (exact case and spelling)\n\taction=join\n");
		}
	}

	// Sit

	else if(classData.GetString("action") == "sit")
	{
			classData.SetString("action", "");
			cStreamBuilder response;
			response.SetOpcode(0x7017);
			response.Append<BYTE>(4);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
	}

	else if(classData.GetString("action") == "stats")
	{
		classData.SetString("action", "");
		getstats();
	}

	else if(classData.GetString("action") == "clear")
	{
		classData.SetString("action", "");
		system("cls");
	}

	else if(classData.GetString("action") == "log")
	{
		long mins;
		classData.SetString("action", "");
		printf("Since you are logged in you made:\n");
		printf("%d Skillpoints\n", spmade / 400);
		printf("%d XP\n", xpmade);
		printf("%i LVL Ups\n", lvlups);
		printf("%i Masterys upped\n", masteryups);
		long ttime = GetTickCount() - classData.GetNumber("JoinTimeRaw");
		if(ttime < 60000)
		{
		printf("You are logged in since %i seconds\n", ttime / 1000);
		}
		else
		{
			mins = ttime / 1000;
			mins = mins / 60;
			printf("You are logged in since %i minutes\n", mins);
		}
	}
	else if(classData.GetString("action") == "dropgold")
	{
		classData.SetString("action", "");
		DWORD amount;
		cout << "How much Gold you wanna drop ?\n";
		cin >> amount;
		cStreamBuilder drop;
		drop.SetOpcode(0x706D);
		drop.Append<BYTE>(0x0A); // Gold slot
		drop.Append<DWORD>(amount);
		InjectClientToServer(drop.GetTotalSize(), drop.GetPacket(), false);
	}

	// ein Statpoint für STR benutzen

	else if(classData.GetString("action") == "strup")
	{
		classData.SetString("action", "");
		cStreamBuilder struppen;
		struppen.SetOpcode(0x727A);
		InjectClientToServer(struppen.GetTotalSize(), struppen.GetPacket(), false);
		cout << "Succesfully used 1 Statpoint for STR\n";
	}
	else if(classData.GetString("action") == "leave")
	{
		classData.SetString("action", "");
		cStreamBuilder  build;
		build.SetOpcode( 0x704F );
		InjectClientToServer( build.GetTotalSize(), build.GetPacket(), false);
		printf("left the party\n");
	}
				
	else if(classData.GetString("action") == "splist")
	{
		classData.SetString("action", "");
		listsp();
	}

	else if(classData.GetString("action") == "intup")
	{
		classData.SetString("action", "");
		cStreamBuilder intuppen;
		intuppen.SetOpcode(0x7552);
		InjectClientToServer(intuppen.GetTotalSize(), intuppen.GetPacket(), false);
		cout << "Succesfully used 1 Statpoint for INT\n";
	}


	// Commands

	else if(classData.GetString("action") == "commands")
	{
		classData.SetString("action", "");
		cout << "New Commands:\n";
		cout << "action=sit --> Your character will Sit down/Stand up\n";
		cout << "action=strup --> Using 1 Statpoint for STR\n";
		cout << "action=intup --> Using 1 Statpoint for INT\n";
		cout << "action=log --> Displaying how many LVL ups you had\nhow many XP u made and how many SkillPoints\nSince you are logged in\n";
		cout << "action=stats --> Displaying your current lvl XP and SP\n";
		cout << "action=clear --> Clearing the Console Window\n";
		cout << "action=allserverstats --> Displaying the Serverstats\n";
		cout << "action=serverstats --> Displaying the Serverstats\nfrom the Server that is set with server=theserver\n";
		cout << "action=leave --> leaves the current Party\n";
		cout << "action=logout --> self explaining\n";
		cout << ".party partynumber --> joining a party from the PT Matching system\n";
		cout << ".trace charid --> tracing a Character by Char id\n";
		cout << ".mastery mastery --> lvling up the Master level of the Skill\n";

	}


	// Check to see if the user wants to join the world server
	else if(classData.GetString("action") == "logout")
	{
		try
		{
			classData.SetString("action", "");

			printf("Sending logout packet...\n");

			// Send the logout packet
			cStreamBuilder response;
			response.SetOpcode(0x70B7);
			response.Append<BYTE>(1);
			InjectClientToServer(response.GetTotalSize(), response.GetPacket(), false);
		}
		catch(std::exception e)
		{
		}
	}

	EnterCriticalSection(&pcs);
		std::map<std::string, tPlugin>::iterator itr = plugins.begin();
		while(itr != plugins.end())
		{
			itr->second.onTimer();
			++itr;
		}
	LeaveCriticalSection(&pcs);
}

//-----------------------------------------------------------------------------

// Tokenizes a string into a vector
std::vector<std::string> TokenizeString(const std::string & str, const std::string & delim)
{
	// http://www.gamedev.net/community/forums/topic.asp?topic_id=381544#TokenizeString
	using namespace std;
	vector<string> tokens;
	size_t p0 = 0, p1 = string::npos;
	while(p0 != string::npos)
	{
		p1 = str.find_first_of(delim, p0);
		if(p1 != p0)
		{
			string token = str.substr(p0, p1 - p0);
			tokens.push_back(token);
		}
		p0 = str.find_first_not_of(delim, p1);
	}
	return tokens;
}

//-----------------------------------------------------------------------------

// http://glprogramming.com/paste.php?paste=111
// WriteBitmapFile()
// desc: takes image data and saves it into a 24-bit RGB .BMP file
//       with width X height dimensions
int WriteBitmapFile(const char *filename, int width, int height, unsigned char *imageData)
{
	FILE             *filePtr;        // file pointer
	BITMAPFILEHEADER bitmapFileHeader;    // bitmap file header
	BITMAPINFOHEADER bitmapInfoHeader;    // bitmap info header
	DWORD                 imageIdx;    // used for swapping RGB->BGR
	unsigned char     tempRGB;            // used for swapping

	// open file for writing binary mode
	filePtr = fopen(filename, "wb");
	if (!filePtr)
		return 0;

	// define the bitmap file header
	bitmapFileHeader.bfSize = sizeof(BITMAPFILEHEADER);
	bitmapFileHeader.bfType = 0x4D42;
	bitmapFileHeader.bfReserved1 = 0;
	bitmapFileHeader.bfReserved2 = 0;
	bitmapFileHeader.bfOffBits = sizeof(BITMAPFILEHEADER) + sizeof(BITMAPINFOHEADER);

	// define the bitmap information header
	bitmapInfoHeader.biSize = sizeof(BITMAPINFOHEADER);
	bitmapInfoHeader.biPlanes = 1;
	bitmapInfoHeader.biBitCount = 32;                        // 24-bit
	bitmapInfoHeader.biCompression = BI_RGB;                // no compression
	bitmapInfoHeader.biSizeImage = width * abs(height) * 4;    // width * height * (RGB bytes)
	bitmapInfoHeader.biXPelsPerMeter = 0;
	bitmapInfoHeader.biYPelsPerMeter = 0;
	bitmapInfoHeader.biClrUsed = 0;
	bitmapInfoHeader.biClrImportant = 0;
	bitmapInfoHeader.biWidth = width;                        // bitmap width
	bitmapInfoHeader.biHeight = height;                    // bitmap height

	// switch the image data from RGB to BGR
	for(imageIdx = 0; imageIdx < bitmapInfoHeader.biSizeImage; imageIdx+=4)
	{
		tempRGB = imageData[imageIdx];
		imageData[imageIdx] = imageData[imageIdx + 2];
		imageData[imageIdx + 2] = tempRGB;
	}

	// write the bitmap file header
	fwrite(&bitmapFileHeader, 1, sizeof(BITMAPFILEHEADER), filePtr);

	// write the bitmap info header
	fwrite(&bitmapInfoHeader, 1, sizeof(BITMAPINFOHEADER), filePtr);

	// write the image data
	fwrite(imageData, 1, bitmapInfoHeader.biSizeImage, filePtr);

	// close our file
	fclose(filePtr);

	// Success
	return 1;
}

//-----------------------------------------------------------------------------

// Loads a plugin
bool LoadPlugin(cEntity & classData, void (*InjectClientToServerFunc)(unsigned short, unsigned char *, bool), const char * filename, const char * refname)
{
	char error[1024] = {0};
	tPlugin tmpDll;

	// Check the reference name
	if(plugins.find(refname) != plugins.end())
	{
		printf("The reference name %s already exists in the plugin manager. Please choose a different reference name for this plugin.\n", refname);
		return false;
	}

	// Load the dll
	tmpDll.hDLL = LoadLibrary(filename);
	if(tmpDll.hDLL == NULL)
	{
		printf("The plugin %s could not be loaded by the system.\n", filename);
		return false;
	}

	tmpDll.onLoad = (void(*)(void))GetProcAddress(tmpDll.hDLL, "OnLoad");
	if(tmpDll.onLoad == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnLoad");
		return false;
	}

	tmpDll.onUnload = (void(*)(void))GetProcAddress(tmpDll.hDLL, "OnUnload");
	if(tmpDll.onUnload == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnUnload");
		return false;
	}

	tmpDll.onSetup = (void (*)(cEntity *, void (*)(unsigned short, unsigned char *, bool)))GetProcAddress(tmpDll.hDLL, "OnSetup");
	if(tmpDll.onSetup == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnSetup");
		return false;
	}

	tmpDll.onServerToClient = (void(*)(tSilkroadPacketHeader *, LPBYTE))GetProcAddress(tmpDll.hDLL, "OnServerToClient");
	if(tmpDll.onServerToClient == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnServerToClient");
		return false;
	}

	tmpDll.onInput = (void (*)(const char *))GetProcAddress(tmpDll.hDLL, "OnInput");
	if(tmpDll.onInput == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnInput");
		return false;
	}

	tmpDll.onTimer = (void (*)())GetProcAddress(tmpDll.hDLL, "OnTimer");
	if(tmpDll.onTimer == NULL)
	{
		FreeLibrary(tmpDll.hDLL);
		printf("The plugin export function %s could not be obtained. Please contact the maker of this plugin with this error.\n", "OnTimer");
		return false;
	}

	// Save the plugin 
	EnterCriticalSection(&pcs);
		plugins.insert(std::make_pair(refname, tmpDll));
	LeaveCriticalSection(&pcs);

	// Setup the DLL with this dll's module
	tmpDll.onSetup(&classData, InjectClientToServerFunc);

	// Call the plugin load function
	tmpDll.onLoad();

	// Success
	return true;
}

//-----------------------------------------------------------------------------

// Unloads a plugin
bool UnloadPlugin(const char * refname)
{
	EnterCriticalSection(&pcs);
		std::map<std::string, tPlugin>::iterator itr = plugins.find(refname);
		if(itr == plugins.end())
		{
			LeaveCriticalSection(&pcs);
			printf("The reference name %s does not exist plugin manager. Please choose a reference name that exists.\n", refname);
			return false;
		}
		itr->second.onUnload();
		FreeLibrary(itr->second.hDLL);
		plugins.erase(itr);
	LeaveCriticalSection(&pcs);
	return true;
}

//-----------------------------------------------------------------------------

// The callback function for when a file is found in the plugins folder
void OnAutoLoadPlugin(const char * filename)
{
	char tmpfilename[MAX_PATH + 1] = {0};
	_snprintf(tmpfilename, MAX_PATH, "%s", filename);
	int length = (int)strlen(tmpfilename);
	for(int x = 0; x < length; ++x)
		tmpfilename[x] = (char)tolower(tmpfilename[x]);
	std::string strDllName;
	for(size_t x = strlen(tmpfilename) - 1; x > 0; --x)
	{
		if(tmpfilename[x] == '\\' || tmpfilename[x] == '/' )
		{
			strDllName = (tmpfilename + x + 1);
			break;
		}
	}
	_snprintf(tmpfilename, MAX_PATH, "%s", strDllName.c_str());
	for(size_t x = strlen(tmpfilename) - 1; x > 0; --x)
	{
		if(tmpfilename[x] == '.')
		{
			strDllName = (tmpfilename + x + 1);
			if(strDllName != "dll")
				return;
			tmpfilename[x] = 0;
			break;
		}
	}
	LoadPlugin(clientless->classData, GlobalInjectClientToServer, filename, tmpfilename);
}

//-----------------------------------------------------------------------------

// This function will find all *.ext files and call UserFunc with the file name.
void FindAllFiles(const char* searchThisDir, bool searchSubDirs, void (*UserFunc)(const char*))
{
	// What we need to search for files
	WIN32_FIND_DATA FindFileData = {0};
	HANDLE hFind = INVALID_HANDLE_VALUE;

	// Build the file search string
	char searchDir[2048] = {0};

	// If it already is a path that ends with \, only add the *
	if(searchThisDir[strlen(searchThisDir) - 1] == '\\')
	{
		_snprintf(searchDir, 2047, "%s*", searchThisDir);
	}
	// Otherwise, add the \* to the end of the path
	else
	{
		_snprintf(searchDir, 2047, "%s\\*", searchThisDir);
	}

	// Find the first file in the directory.
	hFind = FindFirstFile(searchDir, &FindFileData);

	// If there is no file, return
	if (hFind == INVALID_HANDLE_VALUE)
	{
		return;
	}

	// Find files!
	do
	{
		// If it's the "." directory, continue
		if(strcmp(FindFileData.cFileName, ".") == 0)
		{
			continue;
		}

		// If it's the ".." directory, continue
		if(strcmp(FindFileData.cFileName, "..") == 0)
		{
			continue;
		}		

		// If we find a directory
		if(FindFileData.dwFileAttributes == FILE_ATTRIBUTE_DIRECTORY)
		{
			// If we want to search subdirectories
			if(searchSubDirs)
			{
				// Holds the new directory to search
				char searchDir2[2048] = {0};

				// If it already is a path that ends with \, only add the *
				if(searchThisDir[strlen(searchThisDir) - 1] == '\\')
				{
					_snprintf(searchDir2, 2047, "%s%s", searchThisDir, FindFileData.cFileName);
				}
				// Otherwise, add the \* to the end of the path
				else
				{
					_snprintf(searchDir2, 2047, "%s\\%s", searchThisDir, FindFileData.cFileName);
				}
				FindAllFiles(searchDir2, true, UserFunc);
			}

			// Do not need to process anymore
			continue;
		}

		// Create an path to the file
		char filePath[2048] = {0};
		_snprintf(filePath, 2047, "%s\\%s", searchThisDir, FindFileData.cFileName);

		// If there is a file found, pass it to the user function
		if(UserFunc)
		{
			UserFunc(filePath);
		}
	}
	// Loop while we find more files
	while(FindNextFile(hFind, &FindFileData) != 0);

	// We are done with the finding
	FindClose(hFind);
}
//-----------------------------------------------------------------------------
