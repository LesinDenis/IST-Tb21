using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] n = new double[10];
            int min = 0, max = 0;
            double sum = 0;

            // summa
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rand.Next(-10, 30);
                if (n[i] < n[min]) min = i;
                if (n[i] > n[max]) max = i;
                if (n[i] < 0) sum += n[i];
            }

            Console.WriteLine(string.Join(" ", n));

            // Proizvedenie
            double proizv = 1;
            for (int i = Math.Min(min, max); i < Math.Max(min, max); i++)
                proizv = proizv * n[i];

            // Sortirovka
            for (int i = 0; i < n.Length; i++)
                for (int j = i + 1; j < n.Length; j++)
                    if (n[i] > n[j])
                    {
                        var tmp = n[i];
                        n[i] = n[j];
                        n[j] = tmp;
                    }

            Console.WriteLine("Сумма = {0}", sum);
            Console.WriteLine("Произведение = {0}", proizv);
            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", n));
            Console.ReadKey();
        }
    }
}
