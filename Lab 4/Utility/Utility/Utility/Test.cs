﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;

            if (n < 0)
                ok = false;

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {

                f = 0;
                ok = false;
            }

            answer = f;

            return ok;
        }
    }
    
    

    public class Test
    {
        static void Main( )
        {
            try
            {
                int x;
                int y;
                int greater;
                Console.WriteLine("Enter first number:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                y = int.Parse(Console.ReadLine());
                greater = Utils.Greater(x, y);
                Console.WriteLine("The greater value is " + greater);

                Console.WriteLine("Before swap: " + x + "," + y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After swap: " + x + "," + y);

                int f;
                bool ok;
                Console.WriteLine("Number for factorial:");
                x = int.Parse(Console.ReadLine());
                ok = Utils.Factorial(x, out f);
                if (ok)
                    Console.WriteLine("Factorial(" + x + ") = " + f);
                else
                    Console.WriteLine("Cannot compute this factorial");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error was encountered: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
