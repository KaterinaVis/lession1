Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
int xa = 40, ya = 1, // по иксу отступ (по горизонтали) // по игрику отступ (по горизонтали) так мы определяем одну из вершин треугольника
    xb = 1, yb = 30,// по иксу отступ (по горизонтали)  // по игрику отступ (по горизонтали) так мы определяем вторую из вершин треугольника. Можно все писать в строчку ч/з запятую
    xc = 80, yc = 30; // следующая точка

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // случайные точки 

int count = 0; // счетчик

while(count < 10000) // цикл
{
int what = new Random().Next(0, 3); //будут выдаваться случайные сичла 0,1 или 2
if(what==0)
{
    x = (x+xa)/2;
    y = (y+ya)/2;
}

if(what==1)
{
    x = (x+xb)/2;
    y = (y+yb)/2;
}

if(what==2)
{
    x = (x+xc)/2;
    y = (y+yc)/2;
}

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}