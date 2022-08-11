#include <stdio.h>
#include <conio.h>
#include <turbo.h>

void draw(char x1, char y1, char r, char h)
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
	int i;

	for (i = 0; i < 10; i++)
	{
		clrscr();
		draw(i, i, 40 - 2 * i, 20 - i);

		delay(200);
	}
}