#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
            Console.Title = "Introduction to.NET";
            Console.WriteLine("\t\tHello.NET");
            //Console.BackgroundColor= ConsoleColor.Green;//цвет фона
            //Console.ForegroundColor= ConsoleColor.Blue;//цвет текста

            Console.SetCursorPosition(16, 5);
            Console.CursorLeft = 24; //координата курсора по оси х
            Console.CursorTop = 5; //координата курсора по оси у
            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor(); //применяет цветовую схему по умолчанию

            //ЗАДАЕМ РАЗМЕРЫ ОКНА
            //Console.WindowWidth = 44;
            //Console.WindowHeight=16;
            Console.SetWindowSize(64, 16);

            // Для того чтобы свернуть часть кода, этот код нужно поместить в region
            #region CodeSnippet
            //ЗАДАЕМ ПОЛОЖЕНИЕ ОКНА НА ЭКРАНЕ
            //Console.WindowLeft = 10;
            //Console.WindowTop=10;
            #endregion

            //Console.SetWindowPosition(10, 10);
            //Задаем размер буфера консоли
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
#endif

            Console.Write("Введите Ваше имя: ");
            string first_name=Console.ReadLine(); // Метод ReadLine читает строку с клавитатуры до нажатия Enter и возвращает прочитанную строку
            Console.WriteLine(first_name);

            Console.Write(" Введите Вашу фамилию: ");
            String last_name = Console.ReadLine();
            Console.WriteLine(last_name);

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Класс convert представляет соой набор статических методов для преобразования типов. 
            // Этот класс используется тогда, когда другие преобразования не работают.

            //Console.WriteLine(a);

            //Операции над строками
            Console.WriteLine(last_name + " " + first_name + " " + age + " years"); //Конкатенации строк
            // Кроме конкатенации строк, С# поддерживает форматирование строк.

            Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

            Console.WriteLine($"{last_name} {first_name} {age} years"); // Интерполяция - это изменение искажения

        }
    }
}
