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
            Console.WriteLine("��������� � ������");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("������� x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("������� �=");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("������� R=");
                R = Convert.ToDouble(Console.ReadLine());
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
                    if ((x >= 0 && y >= x) || (x < 0 && y <= x))
                        Console.WriteLine("���������");
                    else
                        Console.WriteLine("������");
            }
    }
}
}