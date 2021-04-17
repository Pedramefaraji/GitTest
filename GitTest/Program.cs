using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name : ");
            string UserName = Console.ReadLine();
            Console.WriteLine($"{UserName} , Welcome to New World!");
            Console.ReadLine();
        }
    }
}
