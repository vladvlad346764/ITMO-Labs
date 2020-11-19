using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollar_Rub
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. цикл for

            /* 
            double dollaramount;
            int ir = 5;
            Console.WriteLine("Введите курс доллара");
            dollaramount = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++) {
                double emr = ir * dollaramount;
                Console.WriteLine("{0} = {1}", ir, emr);
                ir += 5;
            }
            */


            //2. цикл while

            /*
            int ir = 5;
            double dollaramount;
            Console.WriteLine("Введите курс доллара");
            dollaramount = double.Parse(Console.ReadLine());
            int i = 1;
             while (i <=20) 
             {
                double emr = ir * dollaramount;
                Console.WriteLine("{0} = {1}", ir, emr);
                ir += 5;
                i++;
            } 
            */

            // 3 . цикл do while
            /*
            int ir = 5;
            double dollaramount;
            Console.WriteLine("Введите курс доллара");
            dollaramount = double.Parse(Console.ReadLine());
            int i = 1;
            do {
                double emr = ir * dollaramount;
                Console.WriteLine("{0} = {1}", ir, emr);
                ir += 5;
                i++;
            } while (i <= 20);
            */
            Console.ReadKey();
        }
    }
}
