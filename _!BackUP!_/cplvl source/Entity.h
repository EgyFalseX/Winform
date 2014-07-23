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

#ifndef ENTITY_H_
#define ENTITY_H_

//-----------------------------------------------------------------------------

#ifndef _STRING_
	#include <string>
#endif

#ifndef _MAP_
	#include <map>
#endif

#ifndef _WINDOWS_
	#include <windows.h>
#endif

//-----------------------------------------------------------------------------

class cEntity
{
private:
	CRITICAL_SECTION cs;
	std::map<std::string, std::string> classStrings;
	std::map<std::string, long> classNumbers;
	std::map<std::string, double> classDecimals;

public:
	cEntity();
	~cEntity();

	// Clears all associated numbers with the class
	void ClearNumbers();
	// Clears all decimals numbers with the class
	void ClearDecimals();
	// Clears all associated strings with the class
	void ClearStrings();

	// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
	void SetNumber(const std::string & key, long data);
	
	// Removes the entry with the specific key. Returns true if the key was successfully
	// removed or false if the key was not found
	bool RemoveNumber(const std::string & key);

	// Modifies an existing entry's data. If the key is not found a const char * std::exception is thrown
	long ModifyNumber(const std::string & key, long data);

	// Returns the number data associated with the key of name. Throws a const char * std::exception if the 
	// name does not exist.
	long GetNumber(const std::string & key);

	// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
	void SetDecimal(const std::string & key, double data);
	
	// Removes the entry with the specific key. Returns true if the key was successfully
	// removed or false if the key was not found
	bool RemoveDecimal(const std::string & key);

	// Modifies an existing entry's data. If the key is not found a const char * std::exception is thrown
	double ModifyDecimal(const std::string & key, double data);
	
	// Returns the decimal data associated with the key of name. Throws a const char * std::exception if the 
	// name does not exist.
	double GetDecimal(const std::string & key);

	// Sets a key data pair. If the key exists, its previous contents are overwritten with the new data
	void SetString(const std::string & key, std::string data);

	// Removes the entry with the specific key. Returns true if the key was successfully
	// removed or false if the key was not found
	bool RemoveString(const std::string & key);

	// Returns the string data associated with the key of name. Throws a std::string std::exception if the 
	// name does not exist.
	std::string GetString(const std::string & key);

	// Saves the entity's data to a file. Any entries prefixed with TMP_ are not saved.
	// If the file cannot be saved, false is returned, otherwise true indicates success.
	bool Save(const std::string & filename);

	// Loads data from a file. Any entries prefixed with TMP_ are not loaded. Returns
	// false if the file could not be loaded or true on success.
	bool Load(const std::string & filename);
};

//-----------------------------------------------------------------------------

#endif
