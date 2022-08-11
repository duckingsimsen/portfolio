#include <stdio.h>
#include <conio.h>
#include <turbo.h>

void main()
{
	int a = 0;
	while (1)
	{
		

		if (_kbhit())
		{
			a = _getch();

			if (a == 72)
			{
				printf("up");
			}
			else if (a == 80)
			{
				printf("down");
			}
		}
	}
}