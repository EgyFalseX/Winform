#include <iostream>
#include <windows.h>
int nextlvlxp;
int spneeded;
using namespace std;
void currentlvlupdate(int y);
void currentlvlupdate(int y)
{
	switch ( y )
	{
	case 1:
		nextlvlxp = 118;
		spneeded = 1;
		break;
	case 2:
		nextlvlxp = 470;
		spneeded = 1;
		break;
	case 3:
		nextlvlxp = 1058;
		spneeded = 1;
		break;
	case 4:
		nextlvlxp = 1880;
		spneeded = 2;
		break;
	case 5:
		nextlvlxp = 2938;
		spneeded = 2;
		break;
	case 6:
		nextlvlxp = 5640;
		spneeded = 4;
		break;
	case 7:
		nextlvlxp = 9048;
		spneeded = 5;
		break;
	case 8:
		nextlvlxp = 13160;
		spneeded = 6;
		break;
	case 9:
		nextlvlxp = 17978;
		spneeded = 7;
		break;
	case 10:
		nextlvlxp = 23500;
		spneeded = 9;
		break;
	case 11:
		nextlvlxp = 34898;
		spneeded = 12;
		break;
	case 12:
		nextlvlxp = 47940;
		spneeded = 15;
		break;
	case 13:
		nextlvlxp = 62628;
		spneeded = 18;
		break;
	case 14:
		nextlvlxp = 78960;
		spneeded = 21;
		break;
	case 15:
		nextlvlxp = 96938;
		spneeded = 24;
		break;
	case 16:
		nextlvlxp = 127840;
		spneeded = 30;
		break;
	case 17:
		nextlvlxp = 161798;
		spneeded = 35;
		break;
	case 18:
		nextlvlxp = 198810;
		spneeded = 41;
		break;
	case 19:
		nextlvlxp = 238878;
		spneeded = 47;
		break;
	case 20:
		nextlvlxp = 282000;
		spneeded = 53;
		break;
	case 21:
		nextlvlxp = 351231;
		spneeded = 62;
		break;
	case 22:
		nextlvlxp = 427755;
		spneeded = 71;
		break;
	case 23:
		nextlvlxp = 512196;
		spneeded = 80;
		break;
	case 24:
		nextlvlxp = 605232;
		spneeded = 89;
		break;
	case 25:
		nextlvlxp = 707587;
		spneeded = 98;
		break;
	case 26:
		nextlvlxp = 820046;
		spneeded = 108;
		break;
	case 27:
		nextlvlxp = 943453;
		spneeded = 117;
		break;
	case 28:
		nextlvlxp = 1078717;
		spneeded = 126;
		break;
	case 29:
		nextlvlxp = 1226815;
		spneeded = 135;
		break;
	case 30:
		nextlvlxp = 1388803;
		spneeded = 144;
		break;
	case 31:
		nextlvlxp = 1595229;
		spneeded = 172;
		break;
	case 32:
		nextlvlxp = 1818827;
		spneeded = 185;
		break;
	case 33:
		nextlvlxp = 2060796;
		spneeded = 199;
		break;
	case 34:
		nextlvlxp = 2322414;
		spneeded = 212;
		break;
	case 35:
		nextlvlxp = 2605043;
		spneeded = 226;
		break;
	case 36:
		nextlvlxp = 2910129;
		spneeded = 239;
		break;
	case 37:
		nextlvlxp = 3239210;
		spneeded = 253;
		break;
	case 38:
		nextlvlxp = 3593924;
		spneeded = 266;
		break;
	case 39:
		nextlvlxp = 3976012;
		spneeded = 280;
		break;
	case 40:
		nextlvlxp = 4387323;
		spneeded = 299;
		break;
	case 41:
		nextlvlxp = 4869381;
		spneeded = 318;
		break;
	case 42:
		nextlvlxp = 5382982;
		spneeded = 336;
		break;
	case 43:
		nextlvlxp = 5929882;
		spneeded = 355;
		break;
	case 44:
		nextlvlxp = 6511920;
		spneeded = 374;
		break;
	case 45:
		nextlvlxp = 7131034;
		spneeded = 393;
		break;
	case 46:
		nextlvlxp = 7789258;
		spneeded = 412;
		break;
	case 47:
		nextlvlxp = 8488730;
		spneeded = 431;
		break;
	case 48:
		nextlvlxp = 9231697;
		spneeded = 449;
		break;
	case 49:
		nextlvlxp = 10020519;
		spneeded = 468;
		break;
	case 50:
		nextlvlxp = 10857676;
		spneeded = 494;
		break;
	case 51:
		nextlvlxp = 11857343;
		spneeded = 520;
		break;
	case 52:
		nextlvlxp = 12913686;
		spneeded = 546;
		break;
	case 53:
		nextlvlxp = 14029449;
		spneeded = 571;
		break;
	case 54:
		nextlvlxp = 15207495;
		spneeded = 597;
		break;
	case 55:
		nextlvlxp = 16450818;
		spneeded = 649;
		break;
	case 56:
		nextlvlxp = 17762545;
		spneeded = 675;
		break;
	case 57:
		nextlvlxp = 19145941;
		spneeded = 700;
		break;
	case 58:
		nextlvlxp = 20604414;
		spneeded = 726;
		break;
	case 59:
		nextlvlxp = 22141527;
		spneeded = 770;
		break;
	case 60:
		nextlvlxp = 23760997;
		spneeded = 813;
		break;
	case 61:
		nextlvlxp = 25933410;
		break;
	case 62:
		nextlvlxp = 28214785;
		break;
	case 63:
		nextlvlxp = 30609702;
		break;
	case 64:
		nextlvlxp = 39747505;
		break;
	case 65:
		nextlvlxp = 51493509;
		break;
	case 66:
		nextlvlxp = 55474876;
		break;
	case 67:
		nextlvlxp = 59648780;
		break;
	case 68:
		nextlvlxp = 64023195;
		break;
	case 69:
		nextlvlxp = 68606389;
		break;
	case 70:
		nextlvlxp = 73406955;
		break;
	case 71:
		nextlvlxp = 79345238;
		break;
	case 72:
		nextlvlxp = 85573753;
		break;
	case 73:
		nextlvlxp = 92104572;
		break;
	case 74:
		nextlvlxp = 98950215;
		break;
	case 75:
		nextlvlxp = 106123703;
		break;
	case 76:
		nextlvlxp = 113638552;
		break;
	case 77:
		nextlvlxp = 121508783;
		break;
	case 78:
		nextlvlxp = 129748946;
		break;
	case 79:
		nextlvlxp = 138374168;
		break;
	case 80:
		nextlvlxp = 147400127;
		break;
	case 81:
		nextlvlxp = 158227752;
		break;
	case 82:
		nextlvlxp = 169572387;
		break;
	case 83:
		nextlvlxp = 181455292;
		break;
	case 84:
		nextlvlxp = 193898546;
		break;
	case 85:
		nextlvlxp = 206925087;
		break;
	case 86:
		nextlvlxp = 220558723;
		break;
	case 87:
		nextlvlxp = 234824141;
		break;
	case 88:
		nextlvlxp = 249746989;
		break;
	case 89:
		nextlvlxp = 265353867;
		break;
	case 90:
		nextlvlxp = 281672373;
		break;
	case 91:
		nextlvlxp = 369337595;
		break;
	case 92:
		nextlvlxp = 473538898;
		break;
	case 93:
		nextlvlxp = 430636533;
		break;
	case 94:
		nextlvlxp = 688586209;
		break;
	case 95:
		nextlvlxp = 686078166;
		break;
	case 96:
		nextlvlxp = 630281734;
		break;
	case 97:
		nextlvlxp = 843249355;
		break;
	case 98:
		nextlvlxp = 963955058;
		break;
	case 99:
		nextlvlxp = 1322659532;
		break;
	case 100:
		nextlvlxp = 1406035568;
		break;
	case 101:
		nextlvlxp = 1507651756;
		break;
	case 102:
		nextlvlxp = 1614099432;
		break;
	case 103:
		nextlvlxp = 1725577160;
		break;
	case 104:
		nextlvlxp = 1842290785;
		break;
	case 105:
		nextlvlxp = 1964454143;
		break;
	case 106:
		nextlvlxp = 2092289330;
		break;
	case 107:
		nextlvlxp = 2226026602;
		break;
	case 108:
		nextlvlxp = 2365904969;
		break;
	case 109:
		nextlvlxp = 2512172674;
		break;
	case 110:
		nextlvlxp = 2665087076;
		break;
	default:
		nextlvlxp = 2665087076;
		break;
	}
};