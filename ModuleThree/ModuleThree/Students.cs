using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class Students
    {
        public Students()
        {
            GetStudentInfo();
        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            // Code to finish getting the rest of the student data
            Console.WriteLine("Enter the student's birthday");
            Console.WriteLine("Month");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Day");
            int day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Year");
            int year = Convert.ToInt16(Console.ReadLine());
            DateTime birthday = new DateTime(year, month, day);
            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
    }
}
