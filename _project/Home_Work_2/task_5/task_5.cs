using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    #region *** Балеев Владимир --- Задание №5 ***
    /* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
     *набрать вес или все в норме;
     * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. */
    #endregion
    class task_5
    {
        /// <summary>
        /// Высчитываем на сколько кг надо похудеть или сколько набрать
        /// </summary>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        static void normalWeight(double height, double BMI, double weight)
        {
            if (BMI < 18.5)
            {
                int a = 19;
                int idealWeight = Convert.ToInt32(a * height * height);
                Console.WriteLine(string.Format($"Необходимо набрать {idealWeight - weight} кг."));
            }
            else 
            {
                int a = 24;
                int idealWeight = Convert.ToInt32(a * height * height);
                Console.WriteLine(string.Format($"Необходимо похудеть на {weight - idealWeight} кг."));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите Ваш рост в сантиметрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            height /= 100;

            Console.Write("Введите Ваш вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);

            Console.WriteLine(string.Format($"Индекс массы тела: {BMI:#.##}"));
            
            switch (BMI)
            {
                case double d when BMI < 16 :
                    Console.WriteLine(string.Format("Выраженный дефицит массы тела.")); normalWeight(height, BMI, weight); break;
                case double d when BMI >= 16 && BMI < 18.5:
                    Console.WriteLine(string.Format("Недостаточная (дефицит) масса тела.")); normalWeight(height, BMI, weight); break;
                case double d when BMI >= 25 && BMI < 30:
                    Console.WriteLine(string.Format("Избыточная масса тела.")); normalWeight(height, BMI, weight); break;
                case double d when BMI >= 30 && BMI < 35:
                    Console.WriteLine(string.Format("Ожирение первой степени.")); normalWeight(height, BMI, weight); break;
                case double d when BMI >= 35 && BMI < 40:
                    Console.WriteLine(string.Format("Ожирение второй степени.")); normalWeight(height, BMI, weight); break;
                case double d when BMI >= 40:
                    Console.WriteLine(string.Format("Увы, у Вас ожирение третьей степени (морбидное).")); normalWeight(height, BMI, weight); break;
                default:
                    Console.WriteLine(string.Format("Поздравляю, Ваше соотношение массы и роста в норме!!!"));
                    break;
            }
            Console.ReadKey();
        }
    }
}
