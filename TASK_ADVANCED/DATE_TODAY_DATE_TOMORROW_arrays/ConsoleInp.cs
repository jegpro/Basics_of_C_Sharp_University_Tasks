using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInp
{
    class ConsoleInput
    {
        public static int ReadInt()
        {
            int N = 0;
            string str;
            bool flag;
            do
            {
                flag = true;
                Console.Write("");
                str = Console.ReadLine();
                try
                {
                    N = Int32.Parse(str);
                    // 2 способ  //N = Convert.ToInt32(str);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    flag = false;
                }
            }
            while (!flag);      //flag == false

            return N;
        }

        public static double ReadDouble()     // 1. 2
        {
            double N = 0;                    // 3 int => double
            string str;
            bool flag;
            do
            {
                flag = true;
                Console.Write("");
                str = Console.ReadLine();
                try
                {
                    N = Double.Parse(str);   // 4
                                             // 2 способ  //N = Convert.ToDouble(str);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    flag = false;
                }
            }
            while (!flag);      //flag == false

            return N;
        }
    }
}
    
