#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <turbo.h>
#include <stdlib.h>
#include <string.h>

#define H 6

char L[1][6][13] = { {"å ���� �Է�", "å ���� ���", "å ���� ����", "å ���� �˻�", "å ���� ����", "å ���� �ݱ�"} };
char B[100][3][100];

int h = 0;

void menu()
{
	int i;

	clrscr();

	for (i = 0; i < 6; i++)
	{
		gotoxy(0, 0 + 5 * i);
		printf("%s", L[0][i]);
	}

	gotoxy(0, 0);
	settextcolor(0, 15);
	printf("%s", L[0][0]);
	settextcolor(15, 0);
}

void reset()
{
	settextcolor(15, 0);
	gotoxy(0, 0 + 5 * h);
	printf("%s", L[0][h]);
}

void set()
{
	settextcolor(0, 15);
	gotoxy(0, 0 + 5 * h);
	printf("%s", L[0][h]);
}

void entry()
{
	int i = 0;
	int f;
	int l;

	clrscr();

	printf("�� ���� å������ �Է��Ͻðڽ��ϱ�?\n");
	scanf("%d", &i);

	for (f = 0; f < i; f++)
	{
		printf("å ����: ");
		scanf("%s", &B[f][0]);
		printf("\n����: ");
		scanf("%s", &B[f][1]);
		printf("\n����: ");
		scanf("%s", &B[f][2]);
	}

	printf("\n\nå �����Է��� �Ϸ��Ͽ����ϴ�.");
	printf("\n Press any key to main Menu");
	l = _getch();
	if (l != NULL)
	{
		menu();
	}
	h = 1;
}

void output()
{
	char i[100] = {0,};
	int l;

	settextcolor(15, 0);
	clrscr();

	printf("� å�� ������ ã�ƺ��ðڽ��ϱ�??\n");
	printf("å ����: ");
	scanf("%s", &i);

	for (int f = 0; f < 101; f++)
	{
		if (strcmp(i, B[f][0]) == 0)
		{
			printf("\n\nå ����: %s", B[f][0]);
			printf("\n����: %s", B[f][1]);
			printf("\n����: %s", B[f][2]);
		}
	}

	printf("\n\nå ������ �����Խ��ϴ�");
	printf("\nPress any key to main Menu");
	l = _getch();
	if (l != NULL)
	{
		menu();
	}
}

void del()
{

}

void search()
{

}

void main()
{
	int i;

	menu();
	setcursortype(0);

	while (1)
	{
		if (_kbhit())
		{
			i = _getch();
			switch (i)
			{
			case 13:
				if (h == 0)
				{
					entry();
				}
				else if (h == 1)
				{
					output();
				}
				else if (h == 2)
				{
					del();
					}
				else if (h == 3)
				{
					search();
				}
				else if (h == 4)
				{

				}
				else if (h == 5)
				{
					exit(0);
				}
			case 72:
				reset();
				if (--h < 0)
				{
					h = H - 1;
				}
				set();
				break;
			case 80:
				reset();
				if (++h == H)
				{
					h = 0;
				}
				set();
				break;
			}
		}

	}
}