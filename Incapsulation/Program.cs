//#define CONSTRUCTORSCHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORSCHECK
            //Stack - статическая память
            //Heap - динамическая память
            /*Point A = new Point(); //оператор 'new' вызывает конструктор класса.
            A.SetX(2);
            A.SetY(3);
            Console.WriteLine($"X={A.GetX()}, Y={A.GetY()}");
            A.Print();*/

            Point B = new Point(); //Default constructor
            B.X = 7;
            B.Y = 8;
            B.Print();

            Point C = new Point(11, 13);
            C.Print();

            double distance = B.Distance(C);
            double static_distance = B.Distance(C);
            Console.WriteLine($"Расстояние между точками: {distance}");
            Console.WriteLine($"Расстояние между точками (Static): {static_distance}");

            //Console.SetWindowSize(200, 120);

            Point D = C; // Здесь копируется НЕ объект, а ссылка на него
            D.Print();
            D.X = 111;
            C.Print();

            // Объекты копируются следующим образом:
            Point E = new Point(D);   // Здесь вызывается конструктор копирования
            E.Print();
            E.X = 11;
            D.Print(); 
#endif
            Point A = new Point(2, 3);
            Point B = new Point(7, 8);
            Point C = new Point(A + B);
            C.Print();
            Point n = new Point(10, 10);
            //for (Point i = new Point(); i.X < 10; i++) // ПОСТФИКСНЫЙ
            for (Point i = new Point(); i != n; ++i) // ПРЕФИКСНЫЙ
            {
                i.Print();
            }
        }
    }
}