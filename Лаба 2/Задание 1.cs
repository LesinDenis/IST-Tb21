1 часть
 
double Y = 0;          
            Console.Write("¬ведите значение аргумента: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
 
            if (-9 <= X && X < -6)
            {
                Console.Write("¬ведите значение величины R: ");
                double R = Convert.ToDouble(Console.ReadLine());
                Y = -Math.Sqrt(Math.Pow(R, 2) - Math.Pow((X + 6), 2));
            }
            else if (-6 <= X && X <= -3)
            {
                Y = X + 3;
            }
            else if (-3 < X && X < 0)
            {
                Console.Write("¬ведите значение величины R: ");
                double R = Convert.ToDouble(Console.ReadLine());
                Y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(X, 2));
            }
            else if (0 <= X && X <= 3)
            {
                Y = -X + 3;
            }
            else
            {
                Y = 0.5 * X - 1.5;
            }
 
            Console.WriteLine();
            Console.WriteLine("«начение ординаты: " + Y);
            Console.ReadLine();