using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    #region *** Балеев Владимир --- Задание №3 ***
    /* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. */
    #endregion
    class task_3
    {
        static void Main(string[] args)
        {
            int number;
            int summ = 0;

            do
            {
                Console.Write(String.Format("Введите число: "));
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 & number % 2 != 0) { summ += number; }
            } while (number != 0);

            Console.WriteLine(String.Format($"Сумма всех нечетных положительных чисел равна: {summ}"));
            Console.ReadLine();
        }
    }
}
