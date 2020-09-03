using System;

namespace AgeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, may I ask your name?");
            string user = Console.ReadLine();

            Console.WriteLine("Please enter your birth year");
            int year = Convert.ToInt32(Console.ReadLine());

            var age = DateTime.Now.Year - year;

            Console.WriteLine("Hello " + user + " you are " + age + " old");

        }
    }
}
