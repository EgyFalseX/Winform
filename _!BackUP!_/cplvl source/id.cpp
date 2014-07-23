#include <windows.h>
#include <vector>
#include <string>
#include <sstream>
#include "SilkroadPacket.h"
#include "Entity.h"
#include "StreamBuilder.h"
#include "StreamReader.h"

////-----------------------------------------------------------------------------
struct ClientData
{
	DWORD selfObjectID;
}
map<DWORD,ClientData> clients;

// Tokenizes a string into a vector
std::vector<std::string> TokenizeString(const std::string& str, const std::string& delim);

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

// Template function to convert a string into any datatype
template <class type>
std::string NumberToString(type number)
{
	std::stringstream ss;
	ss << number;
	return ss.str();
}
//-----------------------------------------------------------------------------

// This plugins dll instance
HINSTANCE dllInstance = 0;
cEntity * clientlessData;

typedef void (*InjectClientToServerFunc)(unsigned short, unsigned char *, bool);
InjectClientToServerFunc InjectClientToServer;

//-----------------------------------------------------------------------------

// Function to make the character sit/stand
void charid();
void InjectFakeNotice(DWORD client, const char * message);

//-----------------------------------------------------------------------------

// Called when the plugin is loaded
extern "C" __declspec(dllexport) void __cdecl OnSetup(cEntity * classData, InjectClientToServerFunc funcPtr)
{
	clientlessData = classData;
	InjectClientToServer = funcPtr;
}

//-----------------------------------------------------------------------------

// Called when the plugin is loaded
extern "C" __declspec(dllexport) void __cdecl OnLoad()
{
	
}

//-----------------------------------------------------------------------------

// Called when the plugin is unloaded
extern "C" __declspec(dllexport) void __cdecl OnUnload()
{
	
}

//-----------------------------------------------------------------------------

// Server to Client packet
extern "C" __declspec(dllexport) void __cdecl OnServerToClient(tSilkroadPacketHeader * header, LPBYTE data)
{
	
}

//-----------------------------------------------------------------------------
extern "C" __declspec(dllexport) bool __cdecl OnServerToClient(DWORD client, tPacket * packet, bool encrypted, bool injected, bool broadcasted)
	{

	// Accept the packet
	// Get Player ID
	PacketReader reader(packet);
	if (reader.GetPacketOpcode() == 0x32A6)
	{
		// Get Player ID
		clients[client].selfObjectID = reader.ReadDword();
	}
//------------------------------------------------------------------------------


// Command function
extern "C" __declspec(dllexport) void __cdecl OnInput(const char * input)
{
	// Break up the command based on spaces
	std::vector<std::string> args = TokenizeString(input, " ");

	// Always make sure there are tokens to process
	if(!args.size()) return;

	// Simple commands
	if(args[0] == ".id")
	{
		if(args.size() != 1)
		{
			printf("Usage: .id\n");
		}
		else
		{
			charid();
		}
	}

	// Face a direction
	else if(args[0] == "/face")
	{
		if(args.size() == 2)
		{
			Face(StringToNumber<double>(args[1]));
		}
		else
		{
			printf("Usage: /face degree\n");
		}
	}

	else if(args[0] == "/statusyy")
	{
		try
		{
			long ttime = GetTickCount() - clientlessData->GetNumber("JoinTimeRaw");
			printf("You have been connected for %i seconds\n", ttime / 1000);
		}
		catch (std::exception & e)
		{
			printf("%s\n", e.what());
		}
	}
}

//-----------------------------------------------------------------------------

// Function when the timer is called
extern "C" __declspec(dllexport) void __cdecl OnTimer()
{
	try
	{
		// If the state hits the 'WaitForLogin' value, we can set the data used by the login process,
		// cool, don't you think?
		if(clientlessData->GetString("state") == "WaitForLogin")
		{
			//clientlessData->SetString("name", "");
			//clientlessData->SetString("pass", "");
			//clientlessData->SetString("server", "");
			//clientlessData->SetString("action", "login");
		}
	}
	catch (std::exception & e)
	{
		printf("%s\n", e.what());
	}
}

//-----------------------------------------------------------------------------

// DLL entry point
// (You should not need to modify this function)
BOOL WINAPI DllMain(HINSTANCE hinst, DWORD dwReason, LPVOID reserved)
{
	if(dwReason == DLL_PROCESS_ATTACH){ DisableThreadLibraryCalls(hinst); dllInstance = hinst; }
	return TRUE;
}

//-----------------------------------------------------------------------------

// Tokenizes a string into a vector
std::vector<std::string> TokenizeString(const std::string& str, const std::string& delim)
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
charid()
{
	InjectFakeNotice(clients[client], clients[client].selfObjectID);
}
// Fake a global message to the client 

InjectFakeNotice(DWORD client, const char * message)
{
	// Covert the ascii message into unicode since that is what the server expects
	wchar_t buffer[1024] = {0};
	mbstowcs(buffer, message, 1023);

	PacketBuilder builder;
	builder.SetOpcode(0x3667);										// Chat opcode
	builder.AppendByte(0x07);										// Notice
	builder.AppendWord((WORD)strlen(message));						// Save length of message
	builder.AppendWideString(buffer);								// Save the converted message
	PluginInjectServerToClient(client, builder.GetPacket(), false);		// Inject the packet
}