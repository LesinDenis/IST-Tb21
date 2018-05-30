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

            // ������ ��������� ������� � ������� �� �����
            for (int i = 0; i < str; ++i)
            {
                for (int j = 0; j < stolb; ++j)
                {
                    massiv[i, j] = rnd.Next(-10, 30);
                    Console.Write(" \t" + massiv[i, j]);
                }
                Console.WriteLine();
            }

            // ���������� ������ ������� ������� � ���� �� ����� 0, ����� �������������� ��������� ���������� kolElem � 
            // ������� ����� �� ����� � ������ ������. ���� ������ �� �������� ������� �������� �������, �������������� 
            // ��������� ���������� kolStr
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
                Console.WriteLine("������ {0} �������� {1} �������(��) �������(��)", (i + 1), kolElem);
                if (kolElem == 0)
                {
                    ++kolStr;
                }
                else
                {
                    kolElem = 0;
                }
            }

            // ������� �� ����� ��������� ���������� kolStr
            Console.WriteLine("���������� ����� �� ���������� ������� ��������: " + kolStr);
            Console.WriteLine();

            //������� ������������ �������� � �������
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
                    Console.WriteLine("������������ ��������: {0} ����������� 1 ���, ������� ���� ����� ������������ ��������, ������������� ����� ������ ����", maxElem);
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

            // ������� ������������ 
            Console.WriteLine("������������ �������: {0}, ����������� {1} ���(�)", maxElem, kolVstrech);
            Console.ReadKey();
        }
    }
}