using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,z1,z2;
            Console.WriteLine("¬ведите число a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¬ведите число b");
            b = Convert.ToDouble(Console.ReadLine());
            z1 = Math.Pow((Math.Cos(a) - Math.Cos(b)), 2) - Math.Pow((Math.Sin(a) - Math.Sin(b)), 2);
            Console.WriteLine("z1=" + z1);
            z2 = -4 * (Math.Sin((a - b) / 2) * Math.Sin((a - b) / 2)) * Math.Cos(a + b);
            Console.WriteLine("z2=" + z2);
            Console.ReadLine();
        }
    }
}
