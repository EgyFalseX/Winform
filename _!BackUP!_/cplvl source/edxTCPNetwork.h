/*
	Copyright (c) 2008 Drew Benton (pushedx)

	This software is provided 'as-is', without any express or implied
	warranty. In no event will the authors be held liable for any damages
	arising from the use of this software.

	Permission is granted to anyone to use this software for any purpose,
	including commercial applications, and to alter it and redistribute it
	freely, subject to the following restrictions:

	1. The origin of this software must not be misrepresented; you must not
	claim that you wrote the original software. If you use this software
	in a product, an acknowledgment in the product documentation would be
	appreciated but is not required.

	2. Altered source versions must be plainly marked as such, and must not be
	misrepresented as being the original software.

	3. This notice may not be removed or altered from any source
	distribution.
*/

//-----------------------------------------------------------------------------

#pragma once

#ifndef EDDX_TCP_NETWORK_H_7CC10E24_F99A_4460_9333_1531F94E1E00
#define EDDX_TCP_NETWORK_H_7CC10E24_F99A_4460_9333_1531F94E1E00

//-----------------------------------------------------------------------------

#ifndef _WINSOCK2API_
	#include <winsock2.h>
#endif

#ifndef _WS2TCPIP_H_
	#include <ws2tcpip.h>
#endif

#ifndef _WINDOWS_
	#include <windows.h>
#endif

#ifndef _INC_TCHAR
	#include <tchar.h>
#endif

#ifndef _QUEUE_
	#include <queue>
#endif

#ifndef _MAP_
	#include <map>
#endif

//-----------------------------------------------------------------------------

// Keep global namespace clear
namespace edx
{
	// Forward declarations
	class TCPClientInterface;
	struct tPacketBuffer;

	//-----------------------------------------------------------------------------

	// Initialize the Winsock library
	// Returns ERROR_SUCCESS on success or the specific error encountered.
	bool InitializeWinsock(BYTE major, BYTE minor);

	// Deinitialize the Winsock library
	void DeinitializeWinsock();

	//-----------------------------------------------------------------------------

	// Base TCP interface
	class TCPInterface
	{
	public:
		// Default ctor
		TCPInterface();

		// Default dtor
		virtual ~TCPInterface();

		// User function called when a client connects to the server. Client should never be null.
		virtual bool TCPOnConnect(TCPClientInterface * client, const CHAR * ip, WORD port) = 0;

		// User function called when a client sends data to the server. Client should never be null.
		virtual int TCPOnProcessStream(TCPClientInterface * client, WORD size, LPBYTE stream) = 0;

		// User function called when a client closes the connection. Client should never be null.
		virtual void TCPOnClose(TCPClientInterface * client) = 0;

		// User function called when a client encounters an error on the server. 'client' may be
		// null, so check before you use it.
		virtual void TCPOnError(TCPClientInterface * client, CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error) = 0;

		// Function to be called on a timer
		virtual void OnTimer() = 0;
	};

	//-----------------------------------------------------------------------------

	// Abstract server object - this class does not process network data
	class BaseTCPServer : public TCPInterface
	{
	protected:
		// The window class for the network event window
		WNDCLASS NetworkWindowClass;

		// Listening socket for the server
		SOCKET sSocket;

		// Port of the server
		WORD port;

		// Handle to the thread
		HANDLE hNetworkThread;

		// Thread ID
		DWORD hNetworkThreadId;

		// Network window for messages
		HWND hNetworkWnd;

		// Exit flag for the server
		BOOL bExit;

		// Temp flag for syncing threads
		BOOL bTmpVar;

		// Temp event to syncing threads
		HANDLE hTmpEvent;

		// Should we accept connections?
		HANDLE hAcceptEvent;

		// Network window class name
		TCHAR className[32];

	private:
		// This is the network message handling callback function
		static LRESULT CALLBACK ServerWndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

		// The thread function that accepts incoming connections
		static DWORD WINAPI ServerAcceptThread(LPVOID lpParam);

		// The thread function that handles network traffic for the server
		static DWORD WINAPI ServerThread(LPVOID lpParam);

	public:
		// Default ctor
		BaseTCPServer();

		// Default dtor
		virtual ~BaseTCPServer();

		// Creates a server on the specific port and returns the socket
		bool Create(WORD listenPort, bool bAllowConnections = true);

		// Destroys the server
		void Destroy();

		// Allows or disallows incoming connections
		void AllowConnections(bool bAllow);

		// Function called when a client has connected to the server
		virtual void OnConnect(SOCKET s) = 0;

		// Function called when a socket is ready for reading
		virtual void OnRead(SOCKET s) = 0;

		// Function called when a socket is ready for writing
		virtual void OnWrite(SOCKET s) = 0;

		// Function called when a socket was closed
		virtual void OnClose(SOCKET s) = 0;

		// The error handling function
		virtual void OnErrorFunction(CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error) = 0;
	};

	//-----------------------------------------------------------------------------

	// Abstract client object - this class does not process network data
	class BaseTCPClient : public TCPInterface
	{
	protected:
		// Main socket for the client
		SOCKET sSocket;

		// The window class for the network event window
		WNDCLASS NetworkWindowClass;

		// Network window class name
		TCHAR className[32];

		// Handle to the thread
		HANDLE hNetworkThread;

		// Thread ID
		DWORD hNetworkThreadId;

		// Network window for messages
		HWND hNetworkWnd;

		// Temp flag for syncing threads
		BOOL bTmpVar;

		// Temp event to syncing threads
		HANDLE hTmpEvent;

		// Exit flag for the client
		BOOL bExit;

		// Instance of module
		HINSTANCE hInstance;

		// Is the client connected to the server? 
		// -1 for not yet, 0 means failed, 1 means success
		int iConnected;

	private:
		// This is the network message handling callback function
		static LRESULT CALLBACK ClientWndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

		// The thread function that handles network traffic
		static DWORD WINAPI ClientThread(LPVOID lpParam);

	public:
		// Default ctor
		BaseTCPClient();

		// Default dtor
		virtual ~BaseTCPClient();

		// Connect to a destination IP address and port. By default we want to resolve the host, but
		// if you have a direct address to connect to, pass 'false' to doHostLookUp.
		bool Connect(const CHAR * ipaddress, int port, bool doHostLookUp = true);

		// Destroys the client
		void Destroy();

		// When the client has been accepted by the server
		virtual void OnConnect() = 0;

		// Function called when a socket is ready for reading
		virtual void OnRead() = 0;

		// Function called when a socket is ready for writing
		virtual void OnWrite() = 0;

		// Function called when a socket was closed
		virtual void OnClose() = 0;

		// The error handling function
		virtual void OnErrorFunction(CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error) = 0;

		// Returns true of this client was able to connect to the server.
		bool IsConnected() const;
	};

	//-----------------------------------------------------------------------------

	// A client interface to the network
	class TCPClientInterface
	{
	private:
		// This object's socket
		SOCKET sSocket;

		// Main recv buffer
		CHAR * recvBuffer;

		// Recv buffer work space
		CHAR * localRecvBuffer;

		// Index the recv buffer is at
		int recvIndex;

		// Queue of packets to be sent
		std::queue<tPacketBuffer *> sendQueue;

		// Make sure access to the sendQueue is atomic
		CRITICAL_SECTION sendQueueCS;

		// Number of queued bytes to send
		size_t sendQueueSize;

		// The parent interface to invoke the event functions of
		TCPInterface * parentInterface;

	public:
		// Overloaded ctor to accept construction with a socket; we don't want objects without a socket!
		TCPClientInterface(SOCKET s, TCPInterface * parent);

		// Default dtor
		~TCPClientInterface();

		// Called when a client connects to the server
		bool OnConnect();

		// Called when a client sends data to the server
		void OnRead();

		// Called when a client is ready for more data to be sent
		void OnWrite();

		// Called when a client closes the connection to the server
		void OnClose();

		// Sends a packet through this client interface
		void Send(WORD size, LPBYTE stream);

		// Disconnect the socket
		void Disconnect();

		// Returns the socket of this object
		SOCKET GetSocket() const;

		// Returns how many packets are queued for sending
		size_t GetSendQueueSize();

		// Returns how many packets are queued for sending
		size_t GetSendQueueCount();

		// Function to be called when the timer executes
		void OnTimer();
	};

	//-----------------------------------------------------------------------------

	// Server class that we can derive from for network ready TCP functionality
	class TCPServer : public BaseTCPServer
	{
	protected:
		// Map of connections
		std::map<SOCKET, TCPClientInterface *> connections;

	public:
		// Default ctor
		TCPServer();

		// Default dtor
		virtual ~TCPServer();

		// Function called when a client has connected to the server
		void OnConnect(SOCKET s);

		// Function called when a socket is ready for reading
		void OnRead(SOCKET s);

		// Function called when a socket is ready for writing
		void OnWrite(SOCKET s);

		// Function called when a socket was closed
		void OnClose(SOCKET s);

		// Function called when an error occurs
		virtual void OnErrorFunction(CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error);
	};

	//-----------------------------------------------------------------------------

	// Client class
	class TCPClient : public BaseTCPClient
	{
	protected:
		// The interface for this client
		TCPClientInterface * clientInterface;

	public:
		// Default ctor
		TCPClient();

		// Default dtor
		virtual ~TCPClient();

		// Function called when a client has connected to the server
		void OnConnect();

		// Function called when a socket is ready for reading
		void OnRead();

		// Function called when a socket is ready for writing
		void OnWrite();

		// Function called when a socket was closed
		void OnClose();

		// Function called when an error occurs
		virtual void OnErrorFunction(CONST CHAR * file, CONST CHAR * function, CONST INT line, CONST TCHAR * error);

		// Sends a packet through the client interface
		void Send(WORD size, LPBYTE stream);

		// Disconnect the socket
		void Disconnect();

		// Returns the socket of this object
		SOCKET GetSocket() const;

		// Returns how many packets are queued for sending
		size_t GetSendQueueSize();

		// Returns how many packets are queued for sending
		size_t GetSendQueueCount();
	};
}

//-----------------------------------------------------------------------------

#endif
