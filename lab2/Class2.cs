using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {
        private int year;
        private int group;
        private int indexNoumber;
        private List<Grade> grade = new List<Grade>();

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public int IndexNoumber
        {
            get { return indexNoumber; }
            set { indexNoumber = value; }
        }

        public Student() : base()
        {
            year = 0;
            group = 0;
            indexNoumber = 0;
        }

        public Student(string name_, string surname_, DateTime dateOfBirth_, int year_, int group_, int indexNoumber_ ) : base(name_, surname_, dateOfBirth_)
        {
            year = year_;
            group = group_;
            indexNoumber = indexNoumber_;
        }

        public override string ToString()
        {
            string str = base.ToString() + $" year: {year}, group: {group}, indexNoumber: {indexNoumber},";
            return str;
        }

        public override void Details()
        {
            Console.WriteLine(this);
            DisplayGrades();
        }

        public void AddGrade(string subject, DateTime data, double worth)
        {
            Grade g = new Grade(subject, data, worth);
            grade.Add(g);
        }
        
        public void DisplayGrades()//jak to działa?
        {
            string str;
            foreach (Grade gr in grade)
               Console.WriteLine(str = gr + "\r\n");//dlaczego tutaj trzeba wpisać + \r\n  ?
        }
    }
}
