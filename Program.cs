// 1
using System.Diagnostics;

decimal r=Convert.ToDecimal(Console.ReadLine());
decimal s=r*r*(decimal)Math.PI;
System.Console.WriteLine(s);

//2
Console.Write("Enter the amount of your money: ");
int sum=Convert.ToInt32(Console.ReadLine());
System.Console.Write("enter the course: ");
int course=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"your money is worth {sum*course}");

//3
System.Console.WriteLine("enter your birth year: ");
int birth=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter the current year: ");
int now=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"you have lived {(now-birth)*365} days so far");
