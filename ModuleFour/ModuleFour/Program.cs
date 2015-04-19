using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[4].Name = "Albert Einstein";
            Console.WriteLine(students[4].Name);
        }
    }
    struct Student
    {
        public string Name { get; set; }
    }
    struct Teacher
    {
        public string Name { get; set; }
    }
    struct SchoolProgram
    {
        public string Name { get; set; }
    }
    struct Course
    {
        public string Name { get; set; }
    }
}
