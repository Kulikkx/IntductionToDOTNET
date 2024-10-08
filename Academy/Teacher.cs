﻿using Academy_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Teacher : Human
    {
        static readonly int SPECIALITY_WIDTH = 20;
        static readonly int EXPERIANCE_WIDTH = 8;
        public string Speciality { get; set; }
        public uint Experience { get; set; }
        public Teacher
            (
            string lastName, string firstName, uint age,
            string speciality, uint experience
            ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        public Teacher(Human human, string speciality, uint experience) : base(human)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality.PadRight(SPECIALITY_WIDTH)} " +
                $"{Experience}";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $" {Speciality.PadRight(SPECIALITY_WIDTH)} " +
                $"{Experience}";
        }
    }
}