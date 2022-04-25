
using System;

namespace TestingWhileCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 123, inputPassword;
            bool psw = false;

            while (!psw)
            {
                try
                {
                    Console.WriteLine("Input pass :");
                    inputPassword = int.Parse(Console.ReadLine());
                    if (password == inputPassword)
                    {
                        Console.WriteLine("Correct password");
                        psw = true;
                        //break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid, try again");
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Invalid, use only digits");
                }
            }
        }
    }
}
