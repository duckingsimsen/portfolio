#include <stdio.h>
#include <conio.h>
#include <turbo.h>
#include <stdlib.h>

#define H1 7
#define H2 8
#define H3 6
#define R 3

char M[1][3][20] = { {"File", "Edit", "Shell" } };
char F[1][7][20] = { {"New File", "Open", "Recent Files", "Save", "Save As", "Close", "Exit"} };
char E[1][8][20] = { {"Undo", "Redo", "Cut", "Copy", "Paste", "Find", "Replace", "2021033"} };
char S[1][6][50] = { {"View Last Restart", "Restart Shell", "Previous History", "Next History", "Software Interrupt Execution", "Hardware Interrupt Execution"} };

int h = -1;
int r = 0;
int x = 0;

void Menu()
{
	int i;

	clrscr();

	for (i = 0; i < 3; i++)
	{
		gotoxy(0 + 20 * i, 0);
		printf("%s", M[0][i]);
	}
	gotoxy(0, 0);
	settextcolor(0, 15);
	printf("%s", M[0][0]);
	settextcolor(15, 0);
}

void reset1()
{
	settextcolor(15, 0);//°ËÁ¤¹ÙÅÁ ÇÏ¾á±Û¾¾
	gotoxy(0 + 20 * r, 0);
	printf("%s", M[0][r]);
}

void set1()
{
	settextcolor(0, 15);//ÇÏ¾á¹ÙÅÁ °ËÁ¤±Û¾¾
	gotoxy(0 + 20 * r, 0);
	printf("%s", M[0][r]);
}

void reset2()
{
	settextcolor(15, 0);
	gotoxy(0, 1 + h);
	printf("%s", F[0][h]);
}

void set2()
{
	settextcolor(0, 15);
	gotoxy(0, 1 + h);
	printf("%s", F[0][h]);
}

void reset3()
{
	settextcolor(15, 0);
	gotoxy(20, 1 + h);
	printf("%s", E[0][h]);
}

void set3()
{
	settextcolor(0, 15);
	gotoxy(20, 1 + h);
	printf("%s", E[0][h]);
}

void reset4()
{
	settextcolor(15, 0);
	gotoxy(40, 1 + h);
	printf("%s", S[0][h]);
}

void set4()
{
	settextcolor(0, 15);
	gotoxy(40, 1 + h);
	printf("%s", S[0][h]);
}

void enter1()
{
	int j;

	settextcolor(15, 0);
	for (j = 0; j < 7; j++)
	{
		gotoxy(0, 1 + j);
		printf("%s", F[0][j]);
	}
}

void enter2()
{
	int j;

	settextcolor(15, 0);
	for (j = 0; j < 8; j++)
	{
		gotoxy(20, 1 + j);
		printf("%s", E[0][j]);
	}
}

void enter3()
{
	int j;

	settextcolor(15, 0);
	for (j = 0; j < 6; j++)
	{
		gotoxy(40, 1 + j);
		printf("%s", S[0][j]);
	}
}


void main()
{
	int i;

	Menu();
	setcursortype(0);

	while (1)
	{
		if (_kbhit())
		{
			i = _getch();
			switch (i)
			{
			case 75:
				if (h == -1)
				{
					reset1();
					if (--r < 0)
					{
						r = R - 1;
					}
					set1();
					x = 0;
					h = -1;
				}
				break;
			case 77:

				if (h == -1)
				{
					reset1();
					if (++r >= R)
					{
						r = 0;
					}
					set1();
					x = 0;
					h = -1;
				}
				break;
			case 13:
				if (r == 0)
				{
					enter1();
				}
				else if (r == 1)
				{
					enter2();
				}
				else if (r == 2)
				{
					enter3();
				}
				break;
			}

			gotoxy(0 + 20 * r, 0);
			settextcolor(0, 15);
			printf("%s", M[0][r]);
			settextcolor(15, 0);

			switch (r)
			{
			case 0:
				if (i == 72)
				{
					gotoxy(25, 16);
					printf("                                       ");
					reset2();
					if (--h < 0)
					{
						h = H1 - 1;
					}
					set2();
				}
				else if (i == 80)
				{
					gotoxy(25, 16);
					printf("                                       ");
					reset2();
					if (++h >= H1)
					{
						h = 0;
					}
					set2();
				}
				else if (i == 13)
				{
					x++;
					gotoxy(25, 16);
					if (x >=2)
					{
						printf("%s -> %s", M[0][r], F[0][h]);
					}

					char a[5] = { "Exit" };

					if (strcmp(F[0][h], a) == 0)
					{
						exit(0);
					}
				}
				break;
			case 1:
				if (i == 72)
				{
					gotoxy(25, 16);
					printf("                                       ");
					reset3();
					if (--h < 0)
					{
						h = H2 - 1;
					}
					set3();
				}
				else if (i == 80)
				{
					gotoxy(25, 16);
					printf("                                       ");
					reset3();
					if (++h > H2 - 1)
					{
						h = 0;
					}
					set3();
				}
				else if (i == 13)
				{
					x++;
					gotoxy(25, 16);
					if (x >= 2)
					{
						printf("%s -> %s", M[0][r], E[0][h]);
					}
				}
				break;
			case 2:
				if (i == 72)
				{
					reset4();
					if (--h < 0)
					{
						if (--h < 1)
						{
							h = H3 - 1;
						}
					}
					set4();
				}
				else if (i == 80)
				{
					reset4();
					if (++h > H3)
					{
						h = 0;
					}
					set4();
				}
				else if (i == 13)
				{
					x++;
					gotoxy(25, 16);
					if (x >= 2)
					{
						printf("%s -> %s", M[0][r], S[0][h]);
					}
				}
				break;
			}
		}
	}
}