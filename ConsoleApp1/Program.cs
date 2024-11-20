using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { // Тумаков - Лабораторная 4 глава
          // Упражнение 4.1. Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует февраля(високосный год не учитывать).
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int dayOfYear = int.Parse(Console.ReadLine()); //Без проверки

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "", "января", "февраля", "марта", "апреля", "мая", "июня",
                                "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            int month = 1;
            int dayOfMonth = 0;

            while (dayOfYear > daysInMonth[month])
            {
                dayOfYear -= daysInMonth[month];
                month++;
            }

            dayOfMonth = dayOfYear;
            Console.WriteLine($"Это {dayOfMonth} {monthNames[month]}");
            // Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать исключение, и выдавать на экран сообщение
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayOfYear1) && dayOfYear1 >= 1 && dayOfYear1 <= 365)
            {
                int[] daysInMonth1 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] monthNames1 = { "", "января", "февраля", "марта", "апреля", "мая", "июня",
                                    "июля", "августа", "сентября", "октября", "ноября", "декабря" };

                int month1 = 1;
                int dayOfMonth1 = 0;

                while (dayOfYear1 > daysInMonth1[month1])
                {
                    dayOfYear1 -= daysInMonth1[month1];
                    month1++;
                }

                dayOfMonth1 = dayOfYear1;
                Console.WriteLine($"Это {dayOfMonth1} {monthNames1[month1]}");
            }
            else
            {
                Console.WriteLine("Некорректный номер дня.");
            }
            // Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год.Однако, если он делится без остатка на 400, это високосный год.)
            Console.Write("Введите номер дня в году (от 1 до 366): ");
            string dayOfYearStr2 = Console.ReadLine();
            Console.Write("Введите год: ");
            string yearStr2 = Console.ReadLine();


            if (int.TryParse(dayOfYearStr2, out int dayOfYear2) && int.TryParse(yearStr2, out int year2) && dayOfYear2 >= 1)
            {
                int[] daysInMonth2 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] monthNames2 = { "", "января", "февраля", "марта", "апреля", "мая", "июня",
                  "июля", "августа", "сентября", "октября", "ноября", "декабря" };

                bool isLeap = (year2 % 4 == 0 && year2 % 100 != 0) || year2 % 400 == 0;
                if (isLeap) daysInMonth2[2] = 29; //Учитываем високосный год

                if (dayOfYear2 > daysInMonth2.Sum() - daysInMonth2[0])
                {
                    Console.WriteLine("Некорректный номер дня для данного года.");
                    return;
                }

                int month2 = 1;
                int dayOfMonth2 = 0;

                while (dayOfYear2 > daysInMonth2[month])
                {
                    dayOfYear2 -= daysInMonth2[month];
                    month2++;
                }

                dayOfMonth2 = dayOfYear2;
                Console.WriteLine($"Это {dayOfMonth2} {monthNames2[month2]} {year2} года");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
            
        }
    }
   
}
    

