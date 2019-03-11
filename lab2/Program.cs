using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var p = new Person("Piotrek", "Swierdza", new DateTime(1998, 10, 5, 12, 50, 00));
            p.Details();
            Console.ReadKey();
            var d = new Person();
            Console.WriteLine(d);
            d.Details();
            Console.ReadKey();*/
            var s = new Student();
           // s.Details();
            s.AddGrade("none",new DateTime(2019, 10, 5, 12, 50, 00), 3.0);
            s.AddGrade("asfsdf", new DateTime(2019, 10, 5, 12, 50, 00), 3.0);
            s.AddGrade("asfsdf", new DateTime(2019, 10, 5, 12, 50, 00), 3.0);
            s.Details();
            //s.DisplayGrades();
            //s.DisplayGrades();
            Console.ReadKey();
           /* Console.WriteLine(s);
            Console.ReadKey();
            var f = new FootballPlayer();
            f.Gooal();
            f.Details();
            Console.ReadKey();
            var m = new Grade();
            m.Details();
            Console.ReadKey();*/
        }
    }
}
