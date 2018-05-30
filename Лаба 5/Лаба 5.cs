using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            int str = 5, stolb = 6;
            int[,] massiv = new int[str, stolb];
            Random rnd = new Random();

            // Задаем случайную матрицу и выводим на экран
            for (int i = 0; i < str; ++i)
            {
                for (int j = 0; j < stolb; ++j)
                {
                    massiv[i, j] = rnd.Next(-10, 30);
                    Console.Write(" \t" + massiv[i, j]);
                }
                Console.WriteLine();
            }

            // Перебираем каждый элемент матрицы и если он равен 0, тогда инкрементируем локальную переменную kolElem и 
            // выводим потом на экран в каждой строке. Если строка не содержит нулевые элементы матрицы, инкрементируем 
            // локальную переменную kolStr
            int kolElem = 0;
            int kolStr = 0;
            for (int i = 0; i < str; ++i)
            {
                for (int j = 0; j < stolb; ++j)
                {
                    if (massiv[i, j] == 0)
                    {
                        ++kolElem;
                    }
                }
                Console.WriteLine("Строка {0} содержит {1} нулевой(ых) элемент(ов)", (i + 1), kolElem);
                if (kolElem == 0)
                {
                    ++kolStr;
                }
                else
                {
                    kolElem = 0;
                }
            }

            // Выводим на экран локальную переменную kolStr
            Console.WriteLine("Количество строк не содержащих нулевые элементы: " + kolStr);
            Console.WriteLine();

            //Находим максимальное значение в матрице
            int maxElem = 0;
            int kolVstrech = 0;
            for (int i = 0; i < str; ++i)
            {
                for (int j = 0; j < stolb; ++j)
                {
                    if (massiv[i, j] == maxElem)
                    {
                        ++kolVstrech;
                    }

                    if (massiv[i, j] > maxElem)
                    {
                        maxElem = massiv[i, j];
                        kolVstrech = 1;
                    }

                }
            }
            while (kolVstrech < 2)
            {
                if (kolVstrech <= 1)
                {
                    Console.WriteLine("Максимальное значение: {0} встречается 1 раз, поэтому ищем новое максимальное значение, встречающееся более одного раза", maxElem);
                    int maxElemPrediduschiy = maxElem;
                    maxElem = 0;
                    kolVstrech = 0;
                    for (int i = 0; i < str; ++i)
                    {
                        for (int j = 0; j < stolb; ++j)
                        {
                            if ((massiv[i, j] == maxElem) && (massiv[i, j] < maxElemPrediduschiy))
                            {
                                ++kolVstrech;
                            }

                            if ((massiv[i, j] > maxElem) && (massiv[i, j] < maxElemPrediduschiy))
                            {
                                maxElem = massiv[i, j];
                                kolVstrech = 1;
                            }

                        }
                    }
                }
            }

            // Находим максимальное 
            Console.WriteLine("Максимальный элемент: {0}, встречается {1} раз(а)", maxElem, kolVstrech);
            Console.ReadKey();
        }
    }
}