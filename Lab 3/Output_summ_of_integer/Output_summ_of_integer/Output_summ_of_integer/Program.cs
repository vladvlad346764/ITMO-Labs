using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_summ_of_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            // не совсем понял как реализовать самоввод числа программой,
            //поэтому число вводится вручную пользователем

            Console.WriteLine("Введите целое число");
            int digital_int = int.Parse(Console.ReadLine());
            int summafinal = 0;
            while (digital_int > 0)
            {

                summafinal += digital_int % 10;
                digital_int /= 10;

            }
            Console.WriteLine(summafinal);
            Console.ReadKey();
        }
    }
}
