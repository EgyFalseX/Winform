#ifndef cStreamBuilder_H_
#define cStreamBuilder_H_

//-----------------------------------------------------------------------------

class cStreamBuilder
{
private:
	unsigned char workspace[8192];
	int index;
	WORD opcode_;

public:
	cStreamBuilder()
	{
		memset(workspace, 0, 8192);
		index = 6;
		opcode_ = 0;
	}

	~cStreamBuilder()
	{
	}

	void Reset()
	{
		memset(workspace, 0, 8192);
		index = 6;
		opcode_ = 0;
	}

	template <class type>
	void Append(type t)
	{
		int sizeoft = sizeof(t);
		if(index + sizeoft >= 8192)
			throw(std::exception("cStreamBuilder::Append past end of stream"));
		memcpy(workspace + index, &t, sizeoft);
		index += sizeoft;
	}

	template <class type>
	void AppendArray(type * t, unsigned short count)
	{
		int sizeoft = sizeof(t[0]) * count;
		if(index + sizeoft >= 8192)
			throw(std::exception("cStreamBuilder::AppendArray past end of stream"));
		memcpy(workspace + index, t, sizeoft);
		index += sizeoft;
	}

	int GetTotalSize()
	{
		return index;
	}

	WORD GetOpcode()
	{
		return opcode_;
	}

	void SetOpcode(unsigned short opcode)
	{
		memcpy(workspace + 2, &opcode, 2);
		opcode_ = opcode;
	}

	unsigned char * GetPacket()
	{
		int tmpindex = index - 6;
		memcpy(workspace, &tmpindex, 2);
		return workspace;
	}
};

//-----------------------------------------------------------------------------

#endif