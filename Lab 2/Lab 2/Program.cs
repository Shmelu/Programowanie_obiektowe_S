using System;
using System.Collections.Generic
using System.Text
using System.Linq
using System.Threading.Tasks



public override string ToString()
{

    return $"Person data | First name: {FirsName}, Last name: {LastName}, Date of birth {DataTime} "

}

public virtual void Details()
{

    Console.WriteLine(this);

}




static void Main(string[] args)
{

    Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
    Osoba o2 = new Student("Michał", "Kot", "13.04.1998");
    Osoba o3 = new Piłkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Częstochowa");

    o.WypiszInfo();
    o2.WypiszInfo();
    o3.WypiszInfo();

    Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
    Piłkarz p = new Piłkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

    s.WypiszInfo();
    p.WypiszInfo();

    ((Piłkarz)o3).StrzelGola();
    p.StrzelGola();
    p.StrzelGola();

    o3.WypiszInfo();
    p.WypiszInfo();

    Console.ReadKey();
    

}