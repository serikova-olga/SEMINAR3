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

if(x>0 && y >0)
{
    Console.WriteLine("первая четверть");
}
if(x < 0 && y >0)
{
    Console.WriteLine("вторая четверть");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("третья четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть");
}

