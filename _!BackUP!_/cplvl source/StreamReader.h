#ifndef STREAMREADER_H_
#define STREAMREADER_H_

//-----------------------------------------------------------------------------

#ifndef _EXCEPTION_
	#include <exception>
#endif

//-----------------------------------------------------------------------------

class cStreamReader
{
	int index;
	int size;
	unsigned char * stream;

public:
	cStreamReader(unsigned char * buffer, int count)
	{
		stream = buffer;
		size = count;
		index = 0;
	}

	~cStreamReader()
	{
	}

	template <class type>
	type Read()
	{
		type t;
		int s = sizeof(type);
		if(index + s > size)
			throw(std::exception("cStreamReader::Read past end of stream."));
		memcpy(&t, stream + index, s);
		index += s;
		return t;
	}

	template <class type>
	void ReadArray(type * array, unsigned short count)
	{
		int s = sizeof(type) * count;
		if(index + s > size)
			throw(std::exception("cStreamReader::ReadArray past end of stream."));
		memcpy(array, stream + index, s);
		index += s;
	}

	int GetBytesLeft()
	{
		return size - index;
	}

	int GetIndex()
	{
		return index;
	}

	void ModifyIndex(int i)
	{
		if(index + i >= 0 && index + i < size)
			index += i;
		else
			throw(std::exception("cStreamReader::ModifyIndex invalid stream index."));
	}

	void SetIndex(int i)
	{
		if(i >= 0 && i < size)
			index = i;
		else
			throw(std::exception("cStreamReader::SetIndex invalid stream index."));
	}

	unsigned char * GetCurrentStream()
	{
		return stream + index;
	}

	unsigned char * GetStream()
	{
		return stream;
	}

	void Reset()
	{
		index = 0;
	}
};

//-----------------------------------------------------------------------------

#endif
