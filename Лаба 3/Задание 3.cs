Double x=2, dx = 1, x_кон = 10, log, e = 0.001;
            Console.WriteLine("\n\tРасчеты для ряда Тейлора");
            Console.WriteLine("      ______________________________ ");
            Console.WriteLine("     |  x  |    y   |  n  |   log   |");
            Console.WriteLine("     |_____|________|_____|_________|");
            while (x <= x_кон)
            {
                Double y = 0, dy;
                int n = 0;
                do
                {
                    dy = 2 * (1 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1)));
                    y += dy;
                    n++;
                } while (Math.Abs(dy) > e);
                log = Math.Log((x+1) / (x-1));
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", x) + "|" + String.Format("{0,8:0.####}", y) + "|" + String.Format("{0,5:0}", n) + "|" + String.Format("{0,9:0.####}", log) + "|");
                Console.WriteLine("     |_____|________|_____|_________|");
                x = x + dx;
            }
            Console.ReadKey(true);