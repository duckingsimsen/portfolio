#include <stdio.h>
#include <conio.h>
#include <turbo.h>

char a[20] = { "string color text.!" };

void main()
{
	int i, j;

	clrscr();

	for (i = 0; i < 10; i++)
	{
		settextcolor(i + 1, i);
		gotoxy(10, 10 + i);
		for (j = 0; j < 20; j++)
		{
			printf("%c", a[j]);
		}
		printf("\n");
		delay(300);
	}
}