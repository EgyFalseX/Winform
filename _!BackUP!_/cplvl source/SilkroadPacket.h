#pragma pack(push, 1)
struct tSilkroadPacketHeader
{
	unsigned short size;
	unsigned short opcode;
	unsigned char securityCount;
	unsigned char securityCRC;
};
#pragma pack(pop)