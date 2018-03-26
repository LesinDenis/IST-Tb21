2 часть

using System;
 
class Program
{
    static void Main()
    {
        try
        {
            const double dR = 8;    // Радиус окружности
 
            Console.Write("X: ");
            double dX = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double dY = double.Parse(Console.ReadLine());
            Console.WriteLine();
 
            bool bResult = false;
            if (Math.Pow(dX, 2) + Math.Pow(dY, 2) <= Math.Pow(dR, 2))
                if ((dX >= 0 && dY >= dX) || (dX < 0 && dY <= dX))
                    bResult = true;
 
            Console.WriteLine(bResult ? "Попадает" : "Не попадает");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("\nОшибка: " + e.Message);
        }
        Console.ReadLine();
    }
}