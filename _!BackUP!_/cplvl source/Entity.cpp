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

#ifndef ENTITY_H_
	#include "Entity.h"
#endif

#include <fstream>

//-----------------------------------------------------------------------------

cEntity::cEntity()
{
	InitializeCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

cEntity::~cEntity()
{
	DeleteCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// Saves the entity's data to a file. Any entries prefixed with TMP_ are not saved.
// If the file cannot be saved, false is returned, otherwise true indicates success.
bool cEntity::Save(const std::string & filename)
{
	EnterCriticalSection(&cs);
	std::ofstream outFile(filename.c_str());
	if(outFile.is_open() == false)
	{
		LeaveCriticalSection(&cs);
		return false;
	}
	// Scope limiter
	{
		std::map<std::string, long>::iterator itr = classNumbers.begin();
		outFile << classNumbers.size() << std::endl;
		while(itr != classNumbers.end())
		{
			if(itr->first.substr(0, 4) != "TMP_")
			{
				outFile << itr->first << std::endl;
				outFile << itr->second << std::endl;
			}
			itr++;
		}
	}
	// Scope limiter
	{
		outFile << classDecimals.size() << std::endl;
		std::map<std::string, double>::iterator itr = classDecimals.begin();
		while(itr != classDecimals.end())
		{
			if(itr->first.substr(0, 4) != "TMP_")
			{
				outFile << itr->first << std::endl;
				outFile << itr->second << std::endl;
			}
			itr++;
		}
	}
	// Scope limiter
	{
		outFile << classStrings.size() << std::endl;
		std::map<std::string, std::string>::iterator itr = classStrings.begin();
		while(itr != classStrings.end())
		{
			if(itr->first.substr(0, 4) != "TMP_")
			{
				outFile << itr->first << std::endl;
				outFile << itr->second << std::endl;
			}
			itr++;
		}
	}
	outFile.close();
	LeaveCriticalSection(&cs);
	return true;
}

//-----------------------------------------------------------------------------

// Loads data from a file. Any entries prefixed with TMP_ are not loaded. Returns
// false if the file could not be loaded or true on success.
bool cEntity::Load(const std::string & filename)
{
	EnterCriticalSection(&cs);
	std::ifstream inFile(filename.c_str());
	if(!inFile.is_open())
	{
		LeaveCriticalSection(&cs);
		return false;
	}
	// Scope limiter
	{
		long count;
		std::string key;
		long data;
		inFile >> count;
		for(int x = 0; x < count; ++x)
		{
			std::getline(inFile, key);
			std::getline(inFile, key);
			inFile >> data;
			if(key.substr(0, 4) != "TMP_")
				classNumbers[key] = data;
		}
	}
	// Scope limiter
	{
		long count;
		std::string key;
		double data;
		inFile >> count;
		for(int x = 0; x < count; ++x)
		{
			std::getline(inFile, key);
			std::getline(inFile, key);
			inFile >> data;
			if(key.substr(0, 4) != "TMP_")
				classDecimals[key] = data;
		}
	}
	// Scope limiter
	{
		long count;
		std::string key;
		std::string data;
		inFile >> count;
		std::getline(inFile, key);
		for(int x = 0; x < count; ++x)
		{
			std::getline(inFile, key);
			std::getline(inFile, data);
			if(key.substr(0, 4) != "TMP_")
				classStrings[key] = data;
		}
	}
	LeaveCriticalSection(&cs);
	return true;
}

//-----------------------------------------------------------------------------

// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
void cEntity::SetNumber(const std::string & key, long data)
{
	EnterCriticalSection(&cs);
	std::map<std::string, long>::iterator itr = classNumbers.find(key);
	if(itr == classNumbers.end())
	{
		classNumbers.insert(std::make_pair(key, data));
	}
	else
	{
		itr->second = data;
	}
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------
// Removes the entry with the specific key. Returns true if the key was successfully
// removed or false if the key was not found
bool cEntity::RemoveNumber(const std::string & key)
{
	EnterCriticalSection(&cs);
	std::map<std::string, long>::iterator itr = classNumbers.find(key);
	if(itr == classNumbers.end())
	{
		LeaveCriticalSection(&cs);
		return false;
	}
	classNumbers.erase(itr);
	LeaveCriticalSection(&cs);
	return true;
}

//-----------------------------------------------------------------------------

// Modifies an existing entry's data. If the key is not found a const char * std::exception is thrown
long cEntity::ModifyNumber(const std::string & key, long data)
{
	long retValue = 0;
	EnterCriticalSection(&cs);
	std::map<std::string, long>::iterator itr = classNumbers.find(key);
	if(itr == classNumbers.end())
	{
		LeaveCriticalSection(&cs);
		throw(std::exception(std::string("cEntity::ModifyNumber no key with a name of " + key + " exists").c_str()));
	}
	itr->second += data;
	retValue = itr->second;
	LeaveCriticalSection(&cs);
	return retValue;
}

//-----------------------------------------------------------------------------

// Returns the number data associated with the key of name. Throws a const char * std::exception if the 
// name does not exist.
long cEntity::GetNumber(const std::string & key)
{
	long retValue = 0;
	EnterCriticalSection(&cs);
	std::map<std::string, long>::iterator itr = classNumbers.find(key);
	if(itr == classNumbers.end())
	{
		LeaveCriticalSection(&cs);
		throw(std::exception(std::string("cEntity::GetNumber no key with a name of " + key + " exists").c_str()));
	}
	retValue = itr->second;
	LeaveCriticalSection(&cs);
	return retValue;
}


//-----------------------------------------------------------------------------

// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
void cEntity::SetDecimal(const std::string & key, double data)
{
	EnterCriticalSection(&cs);
	std::map<std::string, double>::iterator itr = classDecimals.find(key);
	if(itr == classDecimals.end())
	{
		classDecimals.insert(std::make_pair(key, data));
	}
	else
	{
		itr->second = data;
	}
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// Removes the entry with the specific key. Returns true if the key was successfully
// removed or false if the key was not found
bool cEntity::RemoveDecimal(const std::string & key)
{
	EnterCriticalSection(&cs);
	std::map<std::string, double>::iterator itr = classDecimals.find(key);
	if(itr == classDecimals.end())
	{
		LeaveCriticalSection(&cs);
		return false;
	}
	classDecimals.erase(itr);
	LeaveCriticalSection(&cs);
	return true;
}

//-----------------------------------------------------------------------------

// Modifies an existing entry's data. If the key is not found a const char * std::exception is thrown
double cEntity::ModifyDecimal(const std::string & key, double data)
{
	double retValue = 0;
	EnterCriticalSection(&cs);
	std::map<std::string, double>::iterator itr = classDecimals.find(key);
	if(itr == classDecimals.end())
	{
		LeaveCriticalSection(&cs);
		throw(std::exception(std::string("cEntity::ModifyDecimal no key with a name of " + key + " exists").c_str()));
	}
	itr->second += data;
	retValue = itr->second;
	LeaveCriticalSection(&cs);
	return retValue;
}

//-----------------------------------------------------------------------------

// Returns the decimal data associated with the key of name. Throws a const char * std::exception if the 
// name does not exist.
double cEntity::GetDecimal(const std::string & key)
{
	double retValue = 0;
	EnterCriticalSection(&cs);
	std::map<std::string, double>::iterator itr = classDecimals.find(key);
	if(itr == classDecimals.end())
	{
		LeaveCriticalSection(&cs);
		throw(std::exception(std::string("cEntity::GetDecimal no key with a name of " + key + " exists").c_str()));
	}
	retValue = itr->second;
	LeaveCriticalSection(&cs);
	return retValue;
}

//-----------------------------------------------------------------------------

// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
void cEntity::SetString(const std::string & key, std::string data)
{
	EnterCriticalSection(&cs);
	std::map<std::string, std::string>::iterator itr = classStrings.find(key);
	if(itr == classStrings.end())
		classStrings.insert(std::make_pair(key, data));
	else
		itr->second = data;
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// Removes the entry with the specific key. Returns true if the key was successfully
// removed or false if the key was not found
bool cEntity::RemoveString(const std::string & key)
{
	EnterCriticalSection(&cs);
	std::map<std::string, std::string>::iterator itr = classStrings.find(key);
	if(itr == classStrings.end())
	{
		LeaveCriticalSection(&cs);
		return false;
	}
	classStrings.erase(itr);
	LeaveCriticalSection(&cs);
	return true;
}

//-----------------------------------------------------------------------------

// Returns the string data associated with the key of name. Throws a const char * std::exception if the 
// name does not exist.
std::string cEntity::GetString(const std::string & key)
{
	std::string retValue;
	EnterCriticalSection(&cs);
	std::map<std::string, std::string>::iterator itr = classStrings.find(key);
	if(itr == classStrings.end())
	{
		LeaveCriticalSection(&cs);
		throw(std::exception(std::string("cEntity::GetString no key with a name of " + key + " exists").c_str()));
	}
	retValue = itr->second;
	LeaveCriticalSection(&cs);
	return retValue;
}

//-----------------------------------------------------------------------------

// Clears all associated numbers with the class
void cEntity::ClearNumbers()
{
	EnterCriticalSection(&cs);
		classNumbers.clear();
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// Clears all associated decimals with the class
void cEntity::ClearDecimals()
{
	EnterCriticalSection(&cs);
		classDecimals.clear();
	LeaveCriticalSection(&cs);
}

//-----------------------------------------------------------------------------

// Clears all associated strings with the class
void cEntity::ClearStrings()
{
	EnterCriticalSection(&cs);
		classStrings.clear();
	LeaveCriticalSection(&cs);
}

//--------------------- setnumber2 ----------------------------