using System;

namespace lab1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                {
                    Console.Write("Радiус: ");
                    double R = Convert.ToDouble(Console.ReadLine());
                    if (R > 0) {
                        double S = 4 * Math.PI * (R * R);
                        double V = 4 * Math.PI * (R * R * R) / 3;
                        Console.WriteLine("Площа кулi: {0} Об'єм кулi: {1}", S, V);
                        Console.ReadKey();
                        return;             
                    }
                    else
                        Console.WriteLine("Введiть вiрне: ");
                }
            }
        }
    }
}


