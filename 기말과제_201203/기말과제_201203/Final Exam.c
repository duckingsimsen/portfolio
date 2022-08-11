#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <turbo.h>
#include <stdlib.h>
#include <string.h>

#define H 6

char L[1][6][13] = { {"책 정보 입력", "책 정보 출력", "책 정보 삭제", "책 정보 검색", "책 정보 수정", "책 정보 닫기"} };
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

	printf("몇 개의 책정보를 입력하시겠습니까?\n");
	scanf("%d", &i);

	for (f = 0; f < i; f++)
	{
		printf("책 제목: ");
		scanf("%s", &B[f][0]);
		printf("\n저자: ");
		scanf("%s", &B[f][1]);
		printf("\n가격: ");
		scanf("%s", &B[f][2]);
	}

	printf("\n\n책 정보입력을 완료하였습니다.");
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

	printf("어떤 책의 정보를 찾아보시겠습니까??\n");
	printf("책 제목: ");
	scanf("%s", &i);

	for (int f = 0; f < 101; f++)
	{
		if (strcmp(i, B[f][0]) == 0)
		{
			printf("\n\n책 제목: %s", B[f][0]);
			printf("\n저자: %s", B[f][1]);
			printf("\n가격: %s", B[f][2]);
		}
	}

	printf("\n\n책 정보를 가져왔습니다");
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