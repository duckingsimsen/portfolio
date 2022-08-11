#include <stdio.h>
#include <conio.h>
#include <turbo.h>

void draw(char x1, char y1, char h, char r)//r ,h
{
	int i, y;

	gotoxy(x1, y1);
	printf("¦£");
	for (i = 0; i < r; i++)
	{
		printf("¦¡");
	}
	printf("¦¤");

	gotoxy(x1, h);
	printf("¦¦");
	for (i = 0; i < r; i++)
	{
		gotoxy(x1 + i, h);
		printf("¦¡");
	}
	printf("¦¥");


	for (y = y1 + 1; y < h; y++)
	{
		gotoxy(x1, y);
		printf("¦¢");
		gotoxy(x1 + r + 1, y);
		printf("¦¢");
	}
}

void main()
{
	int a;
	
	for (a = 1; a < 10; a++)
	{
		clrscr();
		draw(a, a, 20 - a, 40 - 2 * a);
		delay(500);
	}
	
}