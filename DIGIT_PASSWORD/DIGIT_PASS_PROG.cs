using System;
using System.Text;

namespace ConsoleApp1
{
    class DigitPasswordProgramm
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            int password = 123;

            do
            {
                try
                {
                    Console.WriteLine("Input your password :");
                    password = int.Parse(Console.ReadLine());
                    if (password == 123)
                    {
                        Console.WriteLine("Password is correct.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid password, try again.\n---------------");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid password.\nPassword must contain only digits.\n---------------");
                }
            } while (password != 123);
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
