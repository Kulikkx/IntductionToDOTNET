//#define CALC_IF_ELSE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // КАЛЬКУЛЯТОР IF/ELSE
#if CALC_IF_ELSE
            Console.Write("Введите выражение: ");
            string expresion = Console.ReadLine();
            Console.Write(expresion + " = ");
            String[] tokens = expresion.Split('+', '-', '*', '/');
            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    Console.Write(tokens[i] + "\t");
            //}
            Console.WriteLine();
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);
            //метод Contains() класса 'string' 
            if (expresion.Contains('+')) Console.WriteLine(a + b);
            else if (expresion.Contains('-')) Console.WriteLine(a - b);
            else if (expresion.Contains('*')) Console.WriteLine(a * b);
            else if (expresion.Contains('/')) Console.WriteLine(a / b);
            else Console.WriteLine("No operation"); 
#endif

            // КАЛЬКУЛЯТОР SWITCH
            // Ввод первого числа
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            // Ввод второго числа
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            // Ввод оператора
            Console.Write("Введите оператор (+, -, *, /): ");
            char op = Console.ReadKey(true).KeyChar;

            // Выполнение вычисления
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор.");
                    break;
            }
            Console.WriteLine();
            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }
    }
}