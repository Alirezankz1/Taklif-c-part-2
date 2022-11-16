using System;
class test{

public static void Main()
{
string a = Console.ReadLine();
int x = Convert.ToInt32(a);
Console.Write(year(x));
Console.Write("/");
Console.Write(Month(x));
Console.Write("/");
Console.Write(week(x));
Console.Write("/");
Console.Write(day(x));
Console.Write("/");
Console.WriteLine(x);
Console.Write(year(x));
Console.Write("/");
int y = x - (int)year(x) * 360;
Console.Write(Month(x));
Console.Write("/");
int m = y - (int)Month(x) * 30;
Console.Write(week(x));
Console.Write("/");
int w = m - (int)(week(x)) * 7;
Console.Write(day(x));
Console.Write("/");
int p = w - (int)(day(x)) * 1;
Console.WriteLine(p);

}

private static int year(int x){

return (int)(x / 360);

}

private static int Month(int x){


return (int)(x / 30);


}


private static int week(int x){

return (int)(x / 7);


}

private static int day(int x){

return (int)(x / 1);


}


}


