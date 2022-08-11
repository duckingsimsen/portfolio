#include <stdio.h>
#include <conio.h>
#include <turbo.h>

#define M_NO 4
#define P_NO 5
#define S_NO 20


char a[4][5][20] = {
{"Menu1	","Menu2	","Menu3	","Menu4	","Menu5	"},
{"S1-menu1","S1-menu2","S1-menu3","S1-menu4","S1-menu5"},
{"S2-menu1","S2-menu2","S2-menu3","S2-menu4","S2-menu5"},
{"S3-menu1","S3-menu2","S3-menu3","S3-menu4","S3-menu5"} };

char M[1][5][20] = { { "Menu1	","Menu2	","Menu3	","Menu4	","Menu5	" } };
char S1[1][3][20] = { {"S1-menu1","S2-menu1","S3-menu1"} };
char S2[1][3][20] = { {"S1-menu2","S2-menu2","S3-menu2"} };
char S3[1][3][20] = { {"S1-menu3","S2-menu3","S3-menu3"} };
char S4[1][3][20] = { {"S1-menu4","S2-menu4","S3-menu4"} };
char S5[1][3][20] = { {"S1-menu5","S2-menu5","S3-menu5"} }; 

int sel_p = 0;
int sel_m = 0;

void Menu()
{
	int i = 0, j = 0;

	clrscr();

	for (i = 0; i < P_NO; i++)
	{
		gotoxy(20 * i, 5);
		printf("%s", M[0][i]);
	}
}

void reset()
{
	settextcolor(15, 0);//검정바탕 하양 글자
	gotoxy(20 * sel_p, 5 + sel_m);
	printf("%s", a[sel_m][sel_p]);
}

void set()
{
	settextcolor(0, 15);//하양바탕 검정 글자
	gotoxy(20 * sel_p, 5 + sel_m);
	printf("%s", a[sel_m][sel_p]);
}

void main()
{
	int ch = 0;
	int j = 0, k = 0;

	Menu();
	setcursortype(0);

	while (1)
	{
		int m = 0;

		if (sel_p < 5 || sel_p > -1)
		{
			if (sel_p == 0)
			{
				for (int k = 0; k < 3; k++)
				{
					m++;
					if (sel_m == m)
					{
						settextcolor(0, 15);
					}
					else
					{
						settextcolor(15, 0);
					}
					gotoxy(20 * sel_p, 5 + m);
					printf("%s", S1[0][k]);
				}
			}
			else if (sel_p == 1)
			{
				for (int k = 0; k < 3; k++)
				{
					m++;
					if (sel_m == m)
					{
						settextcolor(0, 15);
					}
					else
					{
						settextcolor(15, 0);
					}
					gotoxy(20 * sel_p, 5 + m);
					printf("%s", S2[0][k]);
				}
			}
			else if (sel_p == 2)
			{
				for (int k = 0; k < 3; k++)
				{
					m++;
					if (sel_m == m)
					{
						settextcolor(0, 15);
					}
					else
					{
						settextcolor(15, 0);
					}
					gotoxy(20 * sel_p, 5 + m);
					printf("%s", S3[0][k]);
				}
			}
			else if (sel_p == 3)
			{
				for (int k = 0; k < 3; k++)
				{
					m++;
					if (sel_m == m)
					{
						settextcolor(0, 15);
					}
					else
					{
						settextcolor(15, 0);
					}
					gotoxy(20 * sel_p, 5 + m);
					printf("%s", S4[0][k]);
				}
			}
			else if (sel_p == 4)
			{
				for (int k = 0; k < 3; k++)
				{
					m++;
					if (sel_m == m)
					{
						settextcolor(0, 15);
					}
					else
					{
						settextcolor(15, 0);
					}
					gotoxy(20 * sel_p, 5 + m);
					printf("%s", S5[0][k]);
				}
			}
		}

		if (_kbhit())
		{
			ch = _getch();

			reset();
			ch = _getch();

			switch (ch)
			{
			case 75://Left Key
				if (--sel_p < 0)
				{
					sel_p = P_NO - 1;
				}
				break;
				
			case 77://Right Key
				if (++sel_p >= P_NO)
				{
					sel_p = 0;
				}
				break;
				
			case 72://Up Key
				if (--sel_m < 0)
				{
					sel_m = M_NO - 1;
				}
				break;
			case 80://Down Key
				if (++sel_m >= M_NO)
				{
					sel_m = 0;
				}
				break;
			case 27://Exit Key
				break;
			}
			Menu();
		}
		set();
	}
}
