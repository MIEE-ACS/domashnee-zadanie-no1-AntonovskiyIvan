﻿using System;

namespace The_First_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус первого круга \n"); // программа получает из консоли первый радиус
            int R1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус второго круга \n");  // программа получает из консоли второй радиус
            int R2 = int.Parse(Console.ReadLine()); // условие ввода R1 > R2
            while (R1 <= R2)
            {
                Console.WriteLine("Введите радиус второго круга заново \n");
                R2 = int.Parse(Console.ReadLine());
            }

            //вывод площадей на экран
            Console.WriteLine("Площадь первого круга S1 равна {0:.00}", R1 * R1 * Math.PI);
            Console.WriteLine("Площадь второго круга S2 равна {0:.00}", R2 * R2 * Math.PI);
            Console.WriteLine("Площадь кольца с внешним радиусом R1 и внутренним R2 равна {0:.00}", Math.PI * (R1 * R1 - R2 * R2));

        }

    }
}