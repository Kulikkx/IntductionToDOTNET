using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{

class Fraction
    {
        public int Integer { get; set; } //Автосвойство, которые не требует объявления переменной, посколькому сами ее объявляют
    public int Numerator {  get; set; }
        int denominator;
        //обычне свойства, которые применяются к переменной denominator
        public int Denominator
        { 
            get=>denominator; 
            set=>denominator=value==0 ? 1: value; 
        }
        // Constructor

        // Methods:
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                Console.Write("(");
                Console.Write( $"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");

            }
            else if(Integer==0)
        }
    }
 }
