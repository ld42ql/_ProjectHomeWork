using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{

    #region *** Балеев Владимир --- Задание №6 ***
    /* Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
     * Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет времени выполнения программы, используя структуру DateTime. */
    #endregion
    class task_6
    {
        

        static void Main(string[] args)
        {
            var timeStart = DateTime.Now;
            Console.WriteLine(timeStart);
            int k = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                
                    int summ = 0;
                    int n = i;
               
                    do
                    {
                        summ += n % 10;
                        n /= 10;
                    } while (n > 0);
                    if (i % summ == 0)
                    {
                    k++;
                    }                              
            }
            var timeEnd = DateTime.Now;
            

            TimeSpan total = timeEnd - timeStart;


            Console.WriteLine(timeStart);
            Console.WriteLine(timeEnd);
            Console.WriteLine(total.TotalMilliseconds);
            Console.WriteLine(total.TotalMinutes);
            Console.WriteLine($"Количество \"хороших\" чисел: {k}");
            Console.ReadKey();

        }
    }
}
