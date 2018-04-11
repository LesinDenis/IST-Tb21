using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;
            Console.WriteLine("Попадания в мишень");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите у=");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите R=");
                R = Convert.ToDouble(Console.ReadLine());
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
                    if ((x >= 0 && y >= x) || (x < 0 && y <= x))
                        Console.WriteLine("Попадание");
                    else
                        Console.WriteLine("Промах");
            }
    }
}
}