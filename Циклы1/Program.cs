using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int Number;
            int Number2 = 1;
            int Number3 = 0;
            for (int i = 0; i < N; i++)
            {
                Number = Number2 + (2 * N - 1);
                Number3 = Number3 + 2;
                Number2 += Number3 + 1;
                Console.WriteLine("Квадрат равен {0}", Number);
            }
            {
            }
            {
                Console.ReadKey();
            }
        }
    }
}
