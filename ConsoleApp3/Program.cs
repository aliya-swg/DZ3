using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        
        }
        static void Task1()
        {
            // Задание 1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность. Использовать break.
            int[] sequence = new int[10];
            Console.WriteLine("Введите 10 чисел:");

            for (int i = 0; i < 10; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out sequence[i]))
                {
                    Console.WriteLine("Некорректный ввод. Повторите ввод:");
                }
            }


            bool isOrdered = true;
            int violationIndex = -1;

            for (int i = 1; i < 10; i++)
            {
                if (sequence[i] < sequence[i - 1])
                {
                    isOrdered = false;
                    violationIndex = i;
                    break; // Прерываем цикл после обнаружения нарушения
                }
            }

            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность НЕ упорядочена. Первое нарушение на позиции {violationIndex + 1} ({sequence[violationIndex]})");
            }
            //Задание 2 Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты. Использовать try-catch-finally.
            Console.Write("Введите порядковый номер карты (от 6 до 14): ");
            string input1 = Console.ReadLine();

            try
            {
                int cardNumber = int.Parse(input1);
                if (cardNumber >= 6 && cardNumber <= 14)
                {
                    string cardRank;
                    switch (cardNumber)
                    {
                        case 11: cardRank = "Валет"; break;
                        case 12: cardRank = "Дама"; break;
                        case 13: cardRank = "Король"; break;
                        case 14: cardRank = "Туз"; break;
                        default: cardRank = cardNumber.ToString(); break; // Для чисел от 6 до 10
                    }
                    Console.WriteLine($"Достоинство карты: {cardRank}");
                }
                else
                {
                    Console.WriteLine("Некорректный номер карты.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат ввода. Введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
            // Задание 3. Напишите программу, которая принимает на входе строку и производит выходные данные
            Console.WriteLine("Введите строку:");
            string input2 = Console.ReadLine().ToLower(); //преобразуем к нижнему регистру для нечувствительности к регистру

            string output;

            switch (input2)
            {
                case "jabroni":
                    output = "\"Patron Tequila\"";
                    break;
                case "school counselor":
                    output = "\"Anything with Alcohol\"";
                    break;
                case "programmer":
                    output = "\"Hipster Craft Beer\"";
                    break;
                case "bike gang member":
                    output = "\"Moonshine\"";
                    break;
                case "politician":
                    output = "\"Your tax dollars\"";
                    break;
                case "rapper":
                    output = "\"Cristal\"";
                    break;
                default:
                    output = "\"Beer\"";
                    break;
            }

            Console.WriteLine(output);
        }
        // Задание 4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье). Использовать enum.

        enum Day
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Task2()
        {
            Console.Write("Введите порядковый номер дня недели (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                // Преобразование номера в значение enum
                Day day = (Day)dayNumber;
                Console.WriteLine($"Это {day}");
            }
            else
            {
                Console.WriteLine("Некорректный номер дня недели.");
            }
            // Задание 5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к результату.Вывести на экран сколько кукол в “сумке”
            string[] toys = { "Hello Kitty", "Teddy Bear", "Barbie doll", "Car", "Hello Kitty", "Lego" };
            List<string> bag = new List<string>(); // "Сумка" - используем List для динамического добавления

            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    bag.Add(toy); // Добавляем куклу в сумку
                }
            }

            Console.WriteLine($"В сумке {bag.Count} кукол.");
        }
    }
}
