//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
            Fraction A = new Fraction();
            A.Print();
            Console.WriteLine(A);

            Fraction B = new Fraction(5);
            B.Print();
            Console.WriteLine(B);

            Fraction C = new Fraction(1, 2);
            C.Print();
            Console.WriteLine(C);

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
            Console.WriteLine(D.ToString());
            Console.WriteLine(D.GetType()); 
#endif
            Fraction A = new Fraction(2, 3, 4);
            Fraction B = new Fraction(3, 4, 5);
            Fraction C = new Fraction(A * B);
            Fraction D = new Fraction(A / B);
            Fraction E = new Fraction(A + B);
            Fraction F = new Fraction(A - B);
            Fraction G = new Fraction(--A);
            Fraction H = new Fraction(++A);
            Fraction I = new Fraction(A += B);
            Fraction J = new Fraction(A -= B);

            A.Print();
            B.Print();
            C.Print();
            Console.WriteLine(C.Inverted());
            D.Print();
            E.Print();
            F.Print();
            G.Print();
            H.Print();
            I.Print();
            J.Print();
            A *= B;
            A.Print();
            A /= B;
            A.Print();
            for (Fraction i = new Fraction(1, 2); i < new Fraction(10); i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}