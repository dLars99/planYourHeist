using System;

namespace planYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Team test = new Team();
            test.AddHench();
        }
    }
}