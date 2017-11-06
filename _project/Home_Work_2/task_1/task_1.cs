using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    #region *** Балеев Владимир --- Задание №1 ***
    /* Написать метод возвращающий минимальное из трех чисел. */
    #endregion
    class task_1
    {
        static void Main(string[] args)
        {
            Console.Write(String.Format("Введите первое число: "));
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(String.Format("\nВведите второе число: "));
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write(String.Format("\nВведите третье число: "));
            int c = Convert.ToInt32(Console.ReadLine());

            //int min = (a < b && a < c) ? a : ((b < c) ? b : c);

            Console.WriteLine(String.Format($"Минимальное число из трех: {minNumber(a, b, c)}"));
            Console.ReadKey();
        }
#region *Как возвращающися метод*
        static int minNumber(int a, int b, int c)
        {
            return (a < b && a < c) ? a : ((b < c) ? b : c);
        }
#endregion
    }
}
