using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    #region *** Балеев Владимир --- Задание №4 ***
    /* Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел
     * (Логин:root, Password:GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
     * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками. */
    #endregion
    class task_4
    {
        static void Main(string[] args)
        {
            string login = "";
            string password = "";
            bool access = false;
            int i = 3;

            do
            {
                Console.Write(String.Format("Введите логин: "));
                login = Console.ReadLine().ToLower();

                Console.Write(String.Format("Введите пароль: "));
                password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains") { access = true; break; }
                else { i--; Console.Clear(); }
            } while (i != 0);


            if (access) { Console.WriteLine(String.Format($"Добро пожаловать в систему {login}")); }
            else { Console.WriteLine(String.Format("Доступ запрещен!")); }

            Console.ReadKey();
        }
    }
}
