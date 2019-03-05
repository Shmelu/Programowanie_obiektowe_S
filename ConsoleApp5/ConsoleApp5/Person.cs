using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Person
    {
        private string _firstname;
        private string _lastname;
        private DateTime _birthDate;

        public Person()
        {
            _firstname = "brak";
            _lastname = "brak";
            _birthDate = new DateTime(0, 0, 0);
        }
        public Person(string fn, string ln, int d, int m, int y)
        {
            _firstname = fn;
            _lastname = ln;
            _birthDate = new DateTime(y, m, d);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"First name: {_firstname}");
            Console.WriteLine($"Last name: {_lastname}");
            Console.WriteLine($"Date of birth: {_birthDate}");
        }
    }
}
