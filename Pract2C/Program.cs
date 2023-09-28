using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace QWE
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserChoice = 123;
            do
            {
                Console.WriteLine("Выберите действие: \n" +
                    "1. Игра Угадай число \n" +
                    "2. Вывод таблицы умножения \n" +
                    "3. Вывод делителей числа \n" +
                    "4. Выход");
                int.TryParse(Console.ReadLine(), out UserChoice);
                if (UserChoice == 1)
                {
                    Chislo();
                }
                else if (UserChoice == 3)
                {
                    Delit();
                }
                else if (UserChoice == 2)
                {
                    Umnoj();
                }
            } while (UserChoice != 4);
        }

        static void Chislo()
        {
            int UserChisloU;
            Random rand = new Random();
            int randomChislo = rand.Next(1, 100);
            do
            {
                int.TryParse(Console.ReadLine(), out UserChisloU);
                if (UserChisloU == randomChislo)
                {
                    Console.WriteLine("Вы угадали!");
                }
                else if (UserChisloU < randomChislo)
                {
                    Console.WriteLine("Число больше");
                }
                else if (UserChisloU > randomChislo)
                {
                    Console.WriteLine("Число меньше");
                }
            } while (UserChisloU != randomChislo);
        }
        static void Delit()
        {
            int UserChisloD;
            string UserChoiceP = "fsdf";
            do
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out UserChisloD);
                Console.Write("Делители числа: ");
                for (int i = 1; i <= UserChisloD; i++)
                {
                    if ((UserChisloD % i) == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("Хотите продолжить? (Если нет - введите NO)");
                UserChoiceP = Console.ReadLine();
            } while (UserChoiceP != "NO");
        }
        static void Umnoj()
        {
            int[,] mass = new int[10, 10];
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mass[i - 1, j - 1] = i * j;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}