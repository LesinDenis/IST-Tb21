using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("J:\\Alg\\Строки.txt", System.Text.Encoding.GetEncoding(1251));
            string text = sr.ReadLine();
            string[] predl = text.Split( '.', '!', '?');
            Console.WriteLine("Исходный текст");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(predl[i]);
            }
            sr.Close();
            Console.WriteLine(";");
            Console.WriteLine("Преобразованный текст");
            for (int i = predl.Length - 1; i >= 0; i--)
            {
                if (i < 3)
                {
                    Console.Write(predl[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}