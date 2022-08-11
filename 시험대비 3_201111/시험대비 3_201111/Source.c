#include <stdio.h>
#include <conio.h>
#include <turbo.h>

#define M_NO 4
#define P_NO 5
#define S_NO 20

char a[4][5][20] = {
	{"Menu1	", "Menu2	","Menu3	", "Menu4	","Menu5	"},
	{"S1-menu1", "S1-menu2", "S1-menu3", "S1-menu4", "S1-menu5"},
	{"S2-menu1", "S2-menu2", "S2-menu3", "S2-menu4", "S2-menu5"},
	{"S3-menu1", "S3-menu2", "S3-menu3", "S3-menu4", "S3-menu5"} };

int sel_p = 0;
int sel_m = 0;

void init_menu()
{
	int i = 0, j = 0;

	clrscr();

	for (i = 0; i < P_NO; i++)
	{
		for (j = 0; j < M_NO; j++)
		{
			gotoxy(20 * i, 5 + j);
			printf("%s", a[j][i]);
		}
	}
	settextcolor(0, 15);
	gotoxy(20 * sel_p, 5 + sel_m);
	printf("%s", a[sel_m][sel_p]);
	settextcolor(15, 0);
}

void reset_menu()
{
	settextcolor(15, 0);//앞 글자, 뒤 바탕, 0 검정
	gotoxy(20 * sel_p, 5 + sel_m);
	printf("%s", a[sel_m][sel_p]);
}

void set_menu()
{
	settextcolor(0, 15);
	gotoxy(20 * sel_p, 5 + sel_m);
	printf("%s", a[sel_m][sel_p]);
}

void main()
{
	int ch = 0;
	int i = 0, j = 0;

	init_menu();
	gotoxy(1, 20);
	setcursortype(0);

	while (1)
	{
		if (_kbhit())
		{
			ch = _getch();
			if (ch == 0)
			{
				
			}
			else if (ch == 27)
			{
				break;
			}
			else if(ch == 224)
			{
				reset_menu();
				ch = _getch();
				switch (ch)
				{
				case 75:
					if (--sel_p < 0)
					{
						sel_p = P_NO - 1;
					}
					break;
				case 77:
					if (++sel_p >= P_NO)
					{
						sel_p = 0;
					}
					break;
				case 72:
					if (--sel_m < 0)
					{
						sel_m = M_NO - 1;
					}
					break;
				case 80:
					if (++sel_m >= M_NO)
					{
						sel_m = 0;
					}
					break;
				}
				set_menu();
			}
		}
	}
	setcursortype(2);
}