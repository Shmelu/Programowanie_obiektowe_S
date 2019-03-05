using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Student: Person
    {
        private int _year;
        private int _group;
        private int _indNumber;

        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indNumber = 0;
        }
        public Student(string fn, string ln, int d, int m,
            int y, int sy, int g, int iNum):base(fn,ln,d,m,y)
        {
            _year = sy;
            _group = g;
            _indNumber = iNum;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Year of studying: {_year}");
            Console.WriteLine($"Group: {_group}");
            Console.WriteLine($"Index number: {_indNumber}");
        }
    }
}
