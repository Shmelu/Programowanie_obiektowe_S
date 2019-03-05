using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Adam", "Miś", 20, 03, 1980);
            Person p2 = new Student("Michał", "Kot", 13, 04, 1990, 2, 1, 12345);
            Person p3 = new Player("Mateusz", "Żbik", 10, 08, 1086, "obrońca", "FC Częstochowa");
            p1.ShowInfo();
            p2.ShowInfo();
            p3.ShowInfo();
        }
    }
}
