using System;
using System.Collections.Generic
using System.Text
using System.Linq
using System.Threading.Tasks

namespace lab2

    class Program
{
    private string





}

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


static void Main(string[] args)
{
    Osoba o = new Osoba("Adam", "Miś", "20.03.1980);
    Osoba o2 = new Student("Michał", "Kot", "13.04.1990);
    Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986");

    o.WtpiszInfo();
    o2.WypiszInfo();
    o3.WypiszInfo();

    Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
    Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

    s.WypiszInfo();
    p.WypiszInfo();

    ((Pilkarz)o3).StrzelGola();
    p.StrzelGola();
    p.StrzelGola();

    o3.Wypisz.Info();
    p.WypiszInfo();
    Console.ReadKey();
}
     
}