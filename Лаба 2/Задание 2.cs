2 �����

using System;
 
class Program
{
    static void Main()
    {
        try
        {
            const double dR = 8;    // ������ ����������
 
            Console.Write("X: ");
            double dX = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double dY = double.Parse(Console.ReadLine());
            Console.WriteLine();
 
            bool bResult = false;
            if (Math.Pow(dX, 2) + Math.Pow(dY, 2) <= Math.Pow(dR, 2))
                if ((dX >= 0 && dY >= dX) || (dX < 0 && dY <= dX))
                    bResult = true;
 
            Console.WriteLine(bResult ? "��������" : "�� ��������");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("\n������: " + e.Message);
        }
        Console.ReadLine();
    }
}