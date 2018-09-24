using System;

namespace c_random
{
 class Program
 {
  static void Main(string[] args)
  {
   Random random = new Random();
   int returnValue = random.Next(0, 50);
   int Guess = 0;
   Console.WriteLine("Throwing ya a number between 0 and 50, What is that number?");
   while (Guess != returnValue)
   {
    Guess = Convert.ToInt32(Console.Read());
    if (Guess < returnValue)
    {
     Console.WriteLine("Easy hot shot, it aint " + Guess + ", try a little higher.")
    }
    else if (Guess < returnValue)
    {
     Console.WriteLine("Negative ghost rider, not " + Guess + ", try a little lower.")
    }
   }
   Console.WriteLine("Hey there ya go, those pesty ol " + returnValue + "s");
   Console.ReadLine();
  }
 }
}
