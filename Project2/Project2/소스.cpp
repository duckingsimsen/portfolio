#include <stdio.h>
#include <turbo.h>
#include <stdlib.h>
#include <conio.h>

void main()
{
	char q[4] = { '-', '\\', '|', '/'};
	int a;
	int cnt = 0;
	int speed = 1000;
	int left_right = -1;
	int key_left = 3;
	int key_right = 0;
	int key_value = 0;

	clrscr;

	while (1)
	{
		cnt++;

		if (left_right == 0)
		{
			for (int a = key_right; a < 4; a++)
			{
				gotoxy(30, 10);
				printf("%c", q[a]);
				if (_kbhit())
				{
					key_value = _getch();
					if (key_value == 72)//up
					{
						if (speed > 200)
						{
							speed -= 100;
						}
					}
					else if (key_value == 80)//down
					{
						speed += 100;
					}
				}
				Sleep(speed);
				key_left = a;

				if (a == 3)
				{
					key_right = 0;
				}
			}
		}
		else if(left_right == 1)
		{
			for (int a = key_left; a >= 0; a--)
			{
				gotoxy(30, 10);
				printf("%c", q[a]);
				if(_kbhit())
				{
					key_value = _getch();
					if (key_value == 72)//up
					{
						if (speed > 200)
						{
							speed -= 100;
						}
					}
					else if (key_value == 80)//down
					{
						speed += 100;
					}
				}
				Sleep(speed);
				key_right = a;

				if (a == 0)
				{
					key_left = 3;
				}
			}
		}

		if (_kbhit())
		{
			key_value = _getch();

			if (key_value == 75)
			{
				left_right = 1;
			}
			else if (key_value == 77)
			{
				left_right = 0;
			}
		}
	}
}