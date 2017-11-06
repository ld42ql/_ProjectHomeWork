
using System;

namespace task_7
{
    #region *** Балеев Владимир --- Задание №7 ***
    /* a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
       б) *Разработать рекурсивный метод, который считает сумму чисел от a до b */
    #endregion
    class task_7
    {
        const int s = 0;
        static void rekursMetod(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) rekursMetod(a + 1, b);
        }
        

        static void rekursSummMetod(int a, int b, int s)
        {
            Console.Write($"{a} ");
            if (a < b)
            {
                s = s + a;
                rekursSummMetod(a + 1, b, s);
            }
            else
            {
                s = s + a;
                Console.WriteLine($"\nСумма = {s}");
            }

        }
        static void Main(string[] args)
        {
            rekursSummMetod(5, 8, s);
            Console.ReadKey();
        }
    }
}
