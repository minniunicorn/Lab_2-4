using System;

namespace Lab_2_4
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определения, в каком из двух чисел больше цифр");
            Console.WriteLine("Введите первое число");
            string chislo1 = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string chislo2 = Console.ReadLine();

            int numbers1 = ClassTask1.Numbers(chislo1);
            int number2 = ClassTask1.Numbers(chislo2);

            Console.WriteLine();
            if (numbers1 > number2)
            {
                Console.WriteLine("В первом числе цифр больше");
            }
            else
            {
                Console.WriteLine("Во втором числе цифр больше");
            }
            Console.ReadKey();
        }
    }
}
