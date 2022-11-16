using System;
class test {
public static void Main(){
string x = Console.ReadLine();
int a = Convert.ToInt32(x);
Console.WriteLine(tavan_2(a));
Console.WriteLine(tavan_3(a));
}
private static double tavan_2(int a)
{
double y = Math.Pow(a,2);
return (y);

}
private static double tavan_3(int a){

double y  = Math.Pow(a,3);
return y;

}

}
