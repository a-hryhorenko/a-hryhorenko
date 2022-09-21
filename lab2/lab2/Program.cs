using System;

namespace lab2
{
     class Program
    {
        static void Main()
        {
            double NN = 0, NK = 0, Result = 0;
            bool isNNOk = false, isNKOk = false;
            do {
                Console.Write("Введiть значення NN:");
                string strNN = Console.ReadLine();
                isNNOk = double.TryParse(strNN, out NN);
                if (NN < 0 || !isNNOk)
                    Console.Write("Помилка введення:");
            } while (NN < 0 || !isNNOk);
            do {
                Console.Write("Введiть значення NK:");
                string strNK = Console.ReadLine();
                isNKOk = double.TryParse(strNK, out NK);
                if (NK < 0 || !isNKOk)
                    Console.Write("Помилка введення:");
                else if (NN > NK)
                    Console.Write("Помилка введення, NK повина бути бiльше нiж NN:");
            } while (NK < 0 || NN > NK || !isNKOk);
            for (double k = NN; k < NK; k++)
                Result += ((Math.Pow(NK, 2) - 1) / (Math.Pow(-1, NK + 1) * Math.Pow(NK, 2) + 7));
            Console.Write("Сума ряду:" + Result);
            Console.ReadKey();
        }
    }
}