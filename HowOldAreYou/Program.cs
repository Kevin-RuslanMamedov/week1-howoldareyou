using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName + "!");
            //string.interpolation
            Console.WriteLine($"Hello, {UserName} !");

            Console.WriteLine("How old are you? Enter digits only");

            int Age = Int32.Parse(Console.ReadLine());

            int YearOfBirth = 2021 - Age;
            //Console.WriteLine("You were born in " + YearOfBirth );
            Console.WriteLine($"You were born in {YearOfBirth}");


     
                
        }
    }
}
