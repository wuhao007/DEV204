using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Birthdate");
            string Birthdate = Console.ReadLine();
            Console.WriteLine("Address Line 1");
            string AddressLine1 = Console.ReadLine();
            Console.WriteLine("Address Line 2");
            string AddressLine2 = Console.ReadLine();
            Console.WriteLine("City");
            string City = Console.ReadLine();
            Console.WriteLine("State/Province");
            string State = Console.ReadLine();
            Console.WriteLine("Zip/Postal");
            string Zip = Console.ReadLine();
            Console.WriteLine("Country");
            string Country = Console.ReadLine();
            Console.WriteLine("Professor");
            string Professor = Console.ReadLine();
            Console.WriteLine(FirstName + LastName);
        }
    }
}
