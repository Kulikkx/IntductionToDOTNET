//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n__________________________________\n";
        static readonly string delimiter2 = "\n----------------------------------\n";
        static void Main(string[] args)
        {
#if NUMERIC_TYPES
//...
            Console.WriteLine("C# DataTypes");


            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(1));
            //Console.WriteLine(bool.Parse(0)); 
            #endregion

            #region Char
            ////Unicode
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(Char.MaxValue); 
            #endregion


            #region int
            //Console.Write($"Перепенная типа 'char' занимает {sizeof(short)} байта, "});
            //Console.WriteLine($ "и принимает значения в диапазоне: {short.MinValue}...{short.MaxValue}.");
            //Console.Write($"Диапазон принимаемых значений 'ushort': {ushort.MaxValue};" );
            //Console.WriteLine(delimiter1);
            //Console.Write($ "Перепенная типа 'char' занимает {sizeof(int16)} байта памяти, "});
            //Console.WriteLine($ "и принимает значения в диапазоне: {int16.MinValue}...{int16.MaxValue}.");
            //Console.Write($ "Диапазон принимаемых значений 'Uint16': {uint16.MaxValue};" ); 
            #endregion

            #region IntegralTypes
            //Console.Write($"Переменная типа 'int' занимает {sizeof(int)} байта памяти,");
            //Console.WriteLine($"и принимает значения в диаазоне: {int.MinValue}....{int.MaxValue},");
            //Console.WriteLine($"Диапазон принимаемых значений 'UInt16' "); 
            #endregion

            double a = 12.56;
            Console.WriteLine(a * 100000);
#endif
#if LITERALS
//...

            Console.WriteLine(123.GetType()); 
#endif

            #region Conversions1
            //Console.WriteLine(((byte)5).GetType().Name); 
            #endregion
            try
            {

            int a = int.MaxValue;
            uint b = uint.MaxValue;
            Console.WriteLine(a + b);
            Console.WriteLine((a + b).GetType().Name);
            long c = long.MaxValue;
            Console.WriteLine(b + c);
            Console.WriteLine((b + c).GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Buy");
        }
    }
}
