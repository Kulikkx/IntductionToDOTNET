﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Human
    {
        static readonly int TUPE_WIDTH = 10;
        static readonly int LAST_NAME_WIDTH = 10;
        static readonly int FIRST_NAME_WIDTH = 10;
        static readonly int AGE_WIDTH = 3;
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }
        public Human(string lastName, string firstName, uint age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{GetHashCode()}");
        }
        public Human(Human other)
        {
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine($"HCopyConstructor:\t{GetHashCode()}");
        }
        ~Human()
        {
            Console.WriteLine($"HDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return (base.ToString().Split(' ') + ":").PadRight(TUPE_WIDTH) +
                $"{LastName.PadRight(LAST_NAME_WIDTH)} {FirstName.PadRight(FIRST_NAME_WIDTH)}" +
                $" {Age.ToString().PadLeft(AGE_WIDTH)} y/o";
        }
        public virtual String ToFileString() // пишем строку которую будем загонять в файл
        {
            return base.ToString().Split('.').Last() + $":{LastName}, {FirstName}, {Age}";
        }
    }
}