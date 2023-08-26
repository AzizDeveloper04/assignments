﻿// 1
   System.Console.WriteLine("enter message: ");
   string text=Console.ReadLine();
   System.Console.WriteLine("enter number");
   int n=Convert.ToInt32(Console.ReadLine());
   string answer= n>text.Length ? text.ToUpper():text.ToLower();
   System.Console.WriteLine(answer);

// 2
System.Console.WriteLine("x=");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("y=");
int y=Convert.ToInt32(Console.ReadLine());
string result="";
if(x>y)
{
  result="x>y";
}
else 
if(x<y)
{
    result="y>x";
}
else if(x==y)
{
   result="x=y";
}
else
{
    result="x and y are not comparable!!!";
}
System.Console.WriteLine(result);

// 3
System.Console.WriteLine("Hafta kunini kiriting: ");
string day=Console.ReadLine();
string translateday=day switch
{
      "dushanba" => "monday",
      "seshanba" => "tuesday",
    "chorshanba" => "wednesday",
     "payshanba" => "thursday",
          "juma" => "firday",
        "shanba" => "saturday",
      "yakshaba" => "sunday",
               _ => "the day not found"
};
System.Console.WriteLine(translateday);
