using System;

namespace lab1
{
    internal class Program
    {
        static void Main()
        {
            double R = 0;
            bool isROk = false;
            do
            {
                Console.Write("Радiус: ");
                string strR = Console.ReadLine();
                isROk = double.TryParse(strR, out R);
                if (!isROk)
                Console.WriteLine("Помилка введення напруги");
            } while (!isROk);
            double S = 4 * Math.PI * (R * R), V = 4 * Math.PI * (R * R * R) / 3;
            Console.WriteLine("Площа кулi: {0} Об'єм кулi: {1}", S, V);
            Console.ReadKey();
                }
            }
        }
    }
}


