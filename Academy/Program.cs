//#define INHERITANCE_1
#define INHERITANCE_2

using Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //пространство имен SysteInputOut
using System.Diagnostics; //пространство имен для чтения файла

namespace Academy_1
{
    class Program
    {
        static void Main(string[] args)
        {
#if INHERITANCE_1
			Human human = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			Console.WriteLine(teacher); 
#endif

#if INHERITANCE_2
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_tommy);
            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(ricardo);

            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons distribution", 20);
            Console.WriteLine(teacher_ricardo);
            Human gaz = new Human("Gaz", "Fring", 40);
            Console.WriteLine(gaz);

            Student student_gaz = new Student(gaz, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_gaz);

            Graduate graduate = new Graduate(student_gaz, "Red", 2020);
            Console.WriteLine(graduate);
#endif
            Human[] group = new Human[]
            {
                new Student(tommy, "Theft", "Vice", 44, 55),
                new Teacher("Diaz", "Ricardo", 40, "Gangster", 18),
                new Graduate(student_gaz, "Blue", 2023)
            };
            foreach (Human i in group)
            {
                Console.WriteLine(i);
            }
            StreamWriter sw = new StreamWriter("File.txt");   // запись в файл

            for (int i = 0; i < group.Length; i++)
            {
                sw.WriteLine(group[i]);
            }
            sw.Close();                                      // закрытие потока
            Process.Start("notepad", "File.txt");            // открытие файла 

            StreamReader sr = new StreamReader("File.txt"); // чтение из файла
            while (!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();                                     // закрытие потока

        }
    }

}