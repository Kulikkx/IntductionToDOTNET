
using Academy_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student : Human
    {
        static readonly int SPECIALITY_WIDTH = 20;
        static readonly int GROUP_WIDTH = 8;
        static readonly int RATING_WIDTH = 5;
        static readonly int ATTENDENCE_WIDTH = 5;
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student
            (
            string lastName, string firstName, uint age,
            string speciality, string group, double rating, double attendance
            ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        public Student(Human human, string speciality, string group, double rating, double attendance) : base(human)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        ~Student()
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality.PadRight(SPECIALITY_WIDTH)} {Group.PadRight(GROUP_WIDTH)} {Rating.ToString().PadLeft(RATING_WIDTH)} {Attendance.ToString().PadLeft(ATTENDENCE_WIDTH)}";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $", {Speciality}, {Group}, {Rating}, {Attendance}";
        }
    }
}