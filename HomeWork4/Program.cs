using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK #1

            int number = Int32.Parse(Console.ReadLine());

            if (number > 0 && number <= 30)
            {
                Console.WriteLine($"Number {number} between 0 and 30");
            }
            else if (number >= 31 && number <= 60)
            {
                Console.WriteLine($"Number {number} between 31 and 60");
            }
            else if (number >= 61 && number <= 100)
            {
                Console.WriteLine($"Number {number} between 61 and 100");
            }
            else
            {
                Console.WriteLine($"I don't know this number - {number}!");
            }

            //TASK #2

            int number1 = 200;
            string inputDate = string.Empty;

            while (number1 < 500)
            {
                if (number1 % 17 == 0)
                {
                    inputDate = inputDate + number1 + ", ";
                }
                number1++;
            }
            Console.WriteLine(inputDate);
        }
    }
}
