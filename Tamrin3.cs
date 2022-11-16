using System;
class test{

public static void Main(){

Console.WriteLine("mojodi:");
string a = Console.ReadLine();
Console.WriteLine("bahre:");
string b = Console.ReadLine();
Console.WriteLine("mojodi jadid:");
string c = Console.ReadLine();
int x = Convert.ToInt32(a);
double y = Convert.ToDouble(b);
double z = Convert.ToInt32(c);
Console.WriteLine("sal:");
Console.WriteLine(mohasehat(x,y,z));
}
private static int mohasehat(int  x , double y , double z );
{
 double a = 0;
 int b=0; 
 for(int i = 1; x < z; i++);
 {
a = x * (y/100);
x = (int)(x + a);
b = i;
 }
 return b;

}


}
 



