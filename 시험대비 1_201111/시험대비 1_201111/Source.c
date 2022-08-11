#include <stdio.h>
#include <conio.h>
#include <turbo.h>

void draw_box(char x1, char y1, char b_width, char b_height)
{
	int a, y;

	gotoxy(x1, y1);
	printf("¦£");
	for (a = 0; a < b_width; a++)
	{
		printf("¦¡");
	}
	printf("¦¤");

	gotoxy(x1, b_height);
	printf("¦¦");
	for (a = 0; a < b_width; a++)
	{
		printf("¦¡");
	}
	printf("¦¥");

	for (y = y1 + 1; y < b_height; y++)
	{
		gotoxy(x1, y);
		printf("¦¢");
		gotoxy(x1 + b_width + 1, y);
		printf("¦¢");
	}
}

void main()
{
	int a;

	for (a = 1; a < 10; a++)
	{
		clrscr();
		draw_box(a, a, 40 - a * 2, 20 - a);
		delay(500);
	}
	gotoxy(10, 20);
}