using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected DateTime dateOfBirth;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Person(string name_, string surname_, DateTime dateOfBirth_)
        {
            name = name_;
            surname = surname_;
            dateOfBirth = dateOfBirth_;
        }
        public Person()
        {
            name = "none";
            surname = "none";
            dateOfBirth = new DateTime();
        }

        public override string ToString()
        {
            return $"First name: {name}, Last name: {surname}, Date of birth: {dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Date of birth: " + dateOfBirth);
            Console.WriteLine(this.ToString());

        }
    }
}
