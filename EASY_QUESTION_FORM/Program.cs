using System;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Location, Age;
            Console.WriteLine("What is your full name?"); 
            Name = Console.ReadLine();
            Console.WriteLine("Where you are live (write your country and city)?");
            Location = Console.ReadLine();
            Console.WriteLine("Your age (only numbers)?");
            Age = Console.ReadLine();
            Console.WriteLine("{0} - from {1} and {2} y.o.\n\n", Name, Location, Age);

            Console.WriteLine("Press to continue...");
            Console.ReadKey();
        }
    }
}
