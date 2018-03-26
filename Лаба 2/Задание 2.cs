using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;
            Console.Write("Введите x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите у=");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите R=");
            R = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
                if ((x >= 0 && y >= x) || (x < 0 && y <= x))
                    Console.WriteLine("Пара (х;у) принадлежит области");
            else
                Console.WriteLine("Пара (х;у) не принадлежит области");

            Console.ReadKey(true);
        }
    }
}
