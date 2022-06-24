/* Напишите программу, которая принимает на вход точки (X Y), причем и выдает номер четверти плоскости, в которой находится точка*/
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int x = Input("введите координау x: ");
int y = Input("введите координау y: ");

if(x == 0 && y == 0)
{
    Console.WriteLine("x и y не могут быть равны 0");
    return;
}

int result = GetNumberQuarter(x, y);
Console.WriteLine($"{result} четверть");

int GetNumberQuarter(int x, int y)
{
    int result = 0;
    if(x>0 && y >0)
    {
        result = 1;
    }
    if(x < 0 && y >0)
    {
        result = 2;
    }
    if(x < 0 && y < 0)
    {
        result = 3;
    }
    if(x > 0 && y < 0)
    {
        result = 4;
    }
    return result;
}



