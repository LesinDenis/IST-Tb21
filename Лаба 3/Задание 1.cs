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
            Console.WriteLine("Введите значение R");
            double R = 0;

            R = Convert.ToDouble(Console.ReadLine());
            if (R < 3)
            {
                Console.WriteLine("Не допустимое значение R ");
            }
            else

                Console.WriteLine("Таблица значений кусочной функции");
            Console.WriteLine("     ____________");
            Console.WriteLine("     |  x |   y |");
            Console.WriteLine("     |____|_____|");
            double Y = 0;
            for (double X = -9, dX = 1; X <= 9; X = X + dX)
            {
                if (-9 <= X && X < -6)
                {

                    Y = -Math.Sqrt(Math.Pow(R, 2) - Math.Pow((X + 6), 2));
                }
                else if (-6 <= X && X < -3)
                {
                    Y = X + 3;
                }
                else if (-3 < X && X < 0)
                {
                    Y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(X, 2));
                }
                else if (0 <= X && X < 3)
                {
                    Y = -X + 3;
                }


                else if (3 <= X && X <= 9)
                {
                    Y = 0.5 * X - 1.5;
                }
                Console.WriteLine("     |" + String.Format("{0,4:0.#}", X) + "|" + String.Format("{0,5:0.##}", Y) + "|");
                Console.WriteLine("     |____|_____|");

            }
            Console.ReadKey(true);
        }
    }
}
