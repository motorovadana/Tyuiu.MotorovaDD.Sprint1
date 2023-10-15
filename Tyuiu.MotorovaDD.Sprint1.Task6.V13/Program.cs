using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint1.Task6.V13.Lib;

namespace Tyuiu.MotorovaDD.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнил: Моторова Дана Дмитриевна | СМАРТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Моторова Дана Дмитриевна | СМАРТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы      *");
            Console.WriteLine("* строки упорядочены по алфавиту                                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string text;

            Console.WriteLine("Enter the text: ");
            text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("The text is sorted alphabetically: " + ds.CheckWordsAlphabet(text));
            Console.ReadKey();
        }
    }
}
