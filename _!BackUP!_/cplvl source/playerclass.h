class player
{
public:
	int currentlvl;
	int currentxp;
	int currentsp;
	long long currentgold;
	int nextlvlxp;
	int spneeded;
} stats;
void listsp();
void getstats();
int spmade2;
int xpmade2;
void getstats() {
	spmade2 = spmade2 / 400;
	printf("%d Skillpoints\n", stats.currentsp + spmade2);
	printf("%d XP\n", stats.currentxp + xpmade2);
	printf("LVL: %d\n", stats.currentlvl);
}
void listsp()
{
	printf("LVL 1: 0 SP\n");
	printf("LVL 2: 1 SP\n");
	printf("LVL 3: 1 SP\n");
	printf("LVL 4: 1 SP\n");
	printf("LVL 5: 2 SP\n");
	printf("LVL 6: 2 SP\n");
	printf("LVL 7: 4 SP\n");
	printf("LVL 8: 5 SP\n");
	printf("LVL 9: 6 SP\n");
	printf("LVL 10: 7 SP\n");
	printf("LVL 11: 9 SP\n");
	printf("LVL 12: 12 SP\n");
	printf("LVL 13: 15 SP\n");
	printf("LVL 14: 18 SP\n");
	printf("LVL 15: 21 SP\n");
	printf("LVL 16: 24 SP\n");
	printf("LVL 17: 30 SP\n");
	printf("LVL 18: 35 SP\n");
	printf("LVL 19: 41 SP\n");
	printf("LVL 20: 47 SP\n");
	printf("LVL 21: 53 SP\n");
	printf("LVL 22: 62 SP\n");
	printf("LVL 23: 71 SP\n");
	printf("LVL 24: 80 SP\n");
	printf("LVL 25: 89 SP\n");
	printf("LVL 26: 98 SP\n");
	printf("LVL 27: 108 SP\n");
	printf("LVL 28: 117 SP\n");
	printf("LVL 29: 126 SP\n");
	printf("LVL 30: 135 SP\n");
	printf("LVL 31: 144 SP\n");
	printf("LVL 32: 158 SP\n");
	printf("LVL 33: 172 SP\n");
	printf("LVL 34: 185 SP\n");
	printf("LVL 35: 199 SP\n");
	printf("LVL 36: 212 SP\n");
	printf("LVL 37: 226 SP\n");
	printf("LVL 38: 239 SP\n");
	printf("LVL 39: 253 SP\n");
	printf("LVL 40: 266 SP\n");
	printf("LVL 41: 280 SP\n");
	printf("LVL 42: 299 SP\n");
	printf("LVL 43: 318 SP\n");
	printf("LVL 44: 336 SP\n");
	printf("LVL 45: 355 SP\n");
	printf("LVL 46: 374 SP\n");
	printf("LVL 47: 393 SP\n");
	printf("LVL 48: 412 SP\n");
	printf("LVL 49: 431 SP\n");
	printf("LVL 50: 449 SP\n");
	printf("LVL 51: 468 SP\n");
	printf("LVL 52: 494 SP\n");
	printf("LVL 53: 520 SP\n");
	printf("LVL 54: 546 SP\n");
	printf("LVL 55: 571 SP\n");
	printf("LVL 56: 597 SP\n");
	printf("LVL 57: 623 SP\n");
	printf("LVL 58: 649 SP\n");
	printf("LVL 59: 675 SP\n");
	printf("LVL 60: 700 SP\n");
}
