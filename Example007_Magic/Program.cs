Console.Clear();

int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x =xa, y = xb;                 // первая координата (случайная точко и для определенности ложим первую координату)

int count = 0;                      // счетчик считает какое именно количество раз необходимо находить отрезки и делить пополам

while(count < 10000)
{
    int what = new Random().Next(0, 3);    // генерируем случайное число (полуинтервал от 0 до 2)
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;

    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;        
}


