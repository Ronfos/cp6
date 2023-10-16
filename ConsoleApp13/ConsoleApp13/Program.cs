using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.1.Вывести на экран в столбик целые числа из интервала от 1 до n(для решения задачи использовать операторы циклов: for, while, do -while).
            //Console.Write("Введите число n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int x = 1; x <= n; x++)
            //{ Console.WriteLine(x); }
            //1.2.
            //Console.Write("Введите число n: ");
            //int n = int.Parse(Console.ReadLine());
            //int x = 1;
            //while (x <= n)
            //{ 
            //    Console.WriteLine(x);
            //    x++;
            //}
            //1.3.
            //Console.Write("Введите число n: ");
            //int n = int.Parse(Console.ReadLine());
            //int x = 1;
            //do
            //{ 
            //    Console.WriteLine(x);
            //    x++;
            //}
            //while (x <= n);

            //Задача 2.Вывести четные двузначные числа и подсчитать их количество.
            //int k = 0;
            //for (int x = 10; x < 100; x++)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //        k++;
            //    }
            //}
            //Console.WriteLine($"Колличество чётных двузначных чисел={k}");

            //Задача 3.Составьте таблицу значений функции y = 2х2 + 4x - 5 на отрезке[-5; 5] с шагом h = 0,2(для решения задачи использовать операторы циклов: for, while, do -while).
            //for (double x = -5; x <= 5.2; x += 0.2)
            //{ Console.WriteLine($"x={x:f1}\ty={Math.Pow(x,2)+4*x-5:f2}"); }

            //Задача 4.Найти сумму чисел, кратных 5, в пределах от 0 до 1000.
            //int sum = 0;
            //for (int x = 0; x <= 1000; x++)
            //{if (x % 5 == 0)
            //    { sum = sum + x; }
            //}
            //Console.WriteLine($"Сумма всех пятикратных чисел от 0 до 1000 равна {sum}");
            //Задача 5.Определить количество цифр заданного числа.  
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine($"Количество цифр введенного числа : {i}");
            Console.ReadKey();
        }
    }
}
