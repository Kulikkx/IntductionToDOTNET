//#define GEOMETRY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static readonly string delimiter1 = "\n-------------------------------\n";
        static void Main(string[] args)
        {

#if GEOMETRY
            Console.Write("Введите размер фигуры: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(" ");
                for (int j = i; j < n; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++) Console.Write(" ");
                for (int j = 0; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
                for (int j = 0; j < 2 * i; j++) Console.Write(" "); Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
                for (int j = 0; j < (n - 1 - i) * 2; j++) Console.Write(" "); Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i % 2 == j % 2 ? "+ " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            //Console.OutputEncoding = System.Text.Encoding.ASCII;
                                     // шахматная доска_1
            Console.Write("Введите размер шахматной доски: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("┌─");
            for (int i = 0; i < size; i++) Console.Write("──");
            Console.Write("─┐");
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write("│ ");

                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue; // синий фон
                        Console.ForegroundColor = ConsoleColor.Yellow; // желтыq текст
                    }
                    else Console.ResetColor(); //сброс настроек цвета                 
                    Console.Write("  ");
                }
                Console.ResetColor();
                Console.Write(" │");
                Console.WriteLine();
            }
            Console.Write("└─");
            for (int i = 0; i < size; i++) Console.Write("──");
            Console.Write("─┘");
            Console.WriteLine();
            Console.ResetColor(); 

                             // шахматная доска_2
            Console.WriteLine("Введите размер шахматной доски: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("8)");
            for (int i = 0; i <= size; ++i)
            {
                for (int j = 0; j <= size; ++j)
                {
                    if ( i == 0 && j == 0) Console.Write(Convert.ToChar("┌"));      //charmap в поиске - таблица символов
                    else if ( i == 0 && j == size) Console.Write(Convert.ToChar("┐")); 
                    else if ( i == size && j == size) Console.Write(Convert.ToChar("┘")); 
                    else if ( i == size && j == 0) Console.Write(Convert.ToChar("└")); 
                    else if ( i == 0 || i == size) Console.Write(Convert.ToChar("─")); 
                    else if ( j == 0 || j == size) Console.Write(Convert.ToChar("│")); 
                    else Console.Write(i % 2 == j % 2 ? Convert.ToChar(0x2588) : ' ');
                }
                Console.WriteLine();
            }
#endif

            // Большая шахматная доска

            Console.Write("Введите размер шахматной доски: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int il = 0; il < size; il++)
                {
                    for (int j = 0; j < size; ++j)
                    {
                        for (int jl = 0; jl < size; jl++)
                        {
                            if (i % 2 == 0 & j % 2 == 0 || i % 2 == 1 & j % 2 == 1) Console.Write("  ");
                            else Console.Write("* ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // Большая шахматная доска через два for'а с побитовыми операторами

            Console.Write("Введите размер шахматной доски: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < size * size; i++)
            {
                for (int j = 0; j < size * size; j++)
                {
                    Console.Write((i / size + j / size) % 2 == 1 ? "  " : " *");
                }
                Console.WriteLine();
            }

        }
    }
}