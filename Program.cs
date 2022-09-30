using System.Linq.Expressions;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в меню программы!\r\n");

            bool check = true;

            do
            {
                Console.WriteLine("Выберите программу которую хотите запустить:\r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Вывод делителей числа\r\n4. Выход из программы");
                
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Randomizer();
                }

                else if (choice == 2)
                {
                    Table();
                }

                else if (choice == 3)
                {
                    Divisors();
                }

                else if (choice == 4)
                {
                    check = false;
                }

                else
                {
                    Console.WriteLine("Введено некорректное значение!\r\n");
                }
            }
            while (check);
        }

        static void Randomizer()
        {
            Random random1 = new Random();
            int value = random1.Next(1, 100);

            Console.WriteLine("Угадай число от 1 до 100");

            bool check = true;

            do
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (value > input)
                {
                    Console.WriteLine("Надо больше!");
                }

                else if (value < input)
                {
                    Console.WriteLine("Надо меньше!");
                }

                else if (value == input)
                {
                    Console.WriteLine("Вы угадали!\r\n");
                    check = false;
                }
            }
            while (check);
        }

        static void Table()
        {
            Console.WriteLine("\n");

            int[,] table = new int[9, 9];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int n = 0; n < table.GetLength(1); n++)
                {
                    table[i, n] = (i + 1) * (n + 1);
                    Console.Write(table[i, n] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Divisors()
        {
            Console.WriteLine("Для выхода из программы, ввведите: \"выйти\"");

            do
            {
                var input = Console.ReadLine();

                if (input == "выйти")
                {
                    break;
                }

                int number = Convert.ToInt32(input);
                List<int> divisors = new List<int>();

                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        divisors.Add(i);
                    }
                }

                divisors.Add(number);

                foreach (int divisor in divisors)
                {
                    Console.Write(divisor + "\t");
                }

                Console.WriteLine("\r");
            }
            while (true);
        }
    }
}