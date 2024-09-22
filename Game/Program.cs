using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = Random.Next(Console.BufferWidth);
            int y = rand.Next(Console.BufferHeight);
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            Console.WriteLine(symbol);
            ConsoleKey.key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key.ToString());
                switch(key)
                {
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.A: x--; break;
                    case ConsoleKey.D: x++; break;
                }
                if (y < 0) y = 0;
                if (x<0) x = 0;
                if (y > Console.BufferHeight - 1) y = Console.BufferHeight - 1;
                if (x > Console.BufferWidth - 1) x = Console.BufferWidth - 1;
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);
        }
    }
}
