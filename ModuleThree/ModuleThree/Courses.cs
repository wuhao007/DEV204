using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class Courses
    {
        public Courses()
        {
            GetCourseInfo();
        }
        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the course's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course's department");
            string department = Console.ReadLine();
            // Code to finish getting the rest of the student data
            Console.WriteLine("Enter the course's university");
            string university = Console.ReadLine();
            PrintCourseDetails(name, department, university);
        }
        static void PrintCourseDetails(string name, string department, string university)
        {
            Console.WriteLine("{0}, {1}, {2}", name, department, university);
        }
    }
}
