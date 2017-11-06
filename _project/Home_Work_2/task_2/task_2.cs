using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    #region *** Балеев Владимир --- Задание №2 ***
    /* Написать метод подсчета количества цифр числа */
    #endregion
    class task_2
    {
        static void Main(string[] args)
        {
            Console.Write(String.Format("Введите число: "));
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            
            for (i = 0; number > 0; i++)
            {
                number /= 10;
            }

            Console.WriteLine(String.Format($"Количества цифр числа: {i}"));
            Console.ReadKey();
        }
    }
}
