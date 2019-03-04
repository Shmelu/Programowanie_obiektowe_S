using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS02
{
    class Pearson
    {
        //Definicja danych
        protected string _Name;
        protected string _Surname;
        protected DateTime _dateOfBirth;
        //Definicja metod dostępowych
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        //Definicja konstruktorów
        public Pearson()
        {
            Name = "VOID";
            Surname = "VOID";
            DateOfBirth = new DateTime();
        }
        public Pearson(string Name,string Surname, DateTime DateOfBirth )
        {
            Name = _Name;
            Surname = _Surname;
            DateOfBirth = _dateOfBirth;
        }
        //Definicja wyświetlania
        public override string ToString()
        {
            return $"                                   PEARSON         \r\n | Name:    {Name}, Surname:    {Surname}, Date of Birth:   {DateOfBirth} |";
        }
        public virtual void DisplayData()
        {
            Console.WriteLine(this);
        }
    }   
}
