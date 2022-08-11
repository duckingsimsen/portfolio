#include <stdio.h>
#include <turbo.h>
#include <conio.h>

int ch = 0, direction = 0, k = 0, n = 0, m = 0, e = 0;

char a[10][10] = {
"#### # ",
"   # # ",
"   # # ",
"   # ##",
"  #  # ",
" #   # ",
"#    # " };

void left()
{
    clrscr();
    int i = 0, j = 0, xx = 0, yy = 0;

    for (i = m; i < 9; i++)
    {
        for (j = k; j < 9; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
            
        }
        for (j = 0; j < k; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    for (i = 0; i < m; i++)
    {
        for (j = k; j < 9; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < k; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
        
    }

    if (++k > 9)
    {
        k = 0;
    }
    if (++yy > 9)
    {
        yy = 0;
    }

    e = k;
    delay(50);
}

void right()
{
    clrscr();
    int i = 0, j = 0, xx = 0, yy = 0;

    for (i = m; i < 9; i++)
    {
        for (j = 9 - k; j < 9; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < 9 - k; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    for (i = 0; i < m; i++)
    {
        for (j = 9 - k; j < 9; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < 9 - k; j++)
        {
            gotoxy(xx, yy);
            if (a[i][j] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    if (++k > 9)
    {
        k = 0;
    }
    if (++yy > 9)
    {
        yy = 0;
    }
    
    e = k;
    delay(50);
}

void up()
{
    clrscr();

    int i = 0, j = 0, xx = 0, yy = 0;

    for (i = e; i < 9; i++)
    {
        for (j = n; j < 9; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < n; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    for (i = 0; i < e; i++)
    {
        for (j = n; j < 9; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < n; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    if (++n > 9)
    {
        n = 0;
    }

    if (++yy > 9)
    {
        yy = 0;
    }
    m = n;
    delay(50);
}

void down()
{
    clrscr();

    int i = 0, j = 0, xx = 0, yy = 0;

    for (i = e; i < 9; i++)
    {
        for (j = 9 - n; j < 9; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < 9 - n; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    for (i = 0; i < e; i++)
    {
        for (j = 9 - n; j < 9; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        for (j = 0; j < 9 - n; j++)
        {
            gotoxy(yy, xx);
            if (a[j][i] == '#')
            {
                printf("бс");
            }
            else
            {
                printf(" ");
            }
            xx += 1;
        }
        xx = 0;
        yy += 1;
    }

    if (++n > 9)
    {
        n = 0;
    }

    if (++yy > 9)
    {
        yy = 0;
    }

    m = n;
    delay(50);
}

int main()
{
    clrscr();
    left();

    do
    {
        if (_kbhit())
        {
            switch (ch = _getch())
            {
            case 75: direction = 0; break;
            case 77: direction = 1; break;
            case 72: direction = 2; break;
            case 80: direction = 3; break;
            case 27: return 0;
            }
        }
        if (direction == 0)
        {
            left();
        }
        else if (direction == 1)
        {
            right();
        }
        else if (direction == 2)
        {
            up();
        }
        else
        {
            down();
        }

    } while (ch != 27);
}