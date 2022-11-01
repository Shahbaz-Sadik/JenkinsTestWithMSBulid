using System;

namespace JeniknsJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Calculator");

            Calculation cal = new Calculation();
            Console.WriteLine(cal.Add(5 , 3));
            Console.WriteLine(cal.Sub(5 , 3));

            Console.WriteLine("Bye Bye From Calculator");
        }
    }
}
