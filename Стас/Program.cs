using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стас
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, C;
            Console.Write("Введите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            C = a + b;
            Console.Write(C);
            Console.ReadKey();
        }
    }
}
