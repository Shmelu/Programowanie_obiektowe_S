using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Osoba
    {
         protected string imie;
         protected string nazwisko;
         protected string dataUrodzenia;

        public virtual void wypiszInfo()
        {
            Console.WriteLine(Imie+", "+Nazwisko+", "+DataUrodzenia);

        }

        public Osoba()
        {
            imie = "Brak";
            nazwisko = "Brak";
            dataUrodzenia = "Brak";
        }

        public Osoba(string imie_,string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }
        static void Main(string[] args)
        {
            // Osoba o1 = new Osoba();
            // o1.wypiszInfo();

            Pilkarz p1 = new Pilkarz("Jakub", "Gieron", "1998", "Napastnik", "FC Kielce", 4);
            p1.wypiszInfo();
            p1.strzelGola();
            p1.wypiszInfo();

            Console.WriteLine("TEST");

            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Częstochowa",10);

            o.wypiszInfo();
            o2.wypiszInfo();
            o3.wypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "20.12.1999", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "12.10.1998", "pomocnik", "FC Barcelona", 5);

            s.wypiszInfo();
            p.wypiszInfo();

            ((Pilkarz)o3).strzelGola();
            p.strzelGola();
            p.strzelGola();

            o3.wypiszInfo();
            p.wypiszInfo();


            
            Console.ReadKey();
        }

    }

    class Student : Osoba
    {
        protected int rok;
        protected int grupa;
        protected int nrIndeksu;

        public Student (string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_):base(imie_,nazwisko_,dataUrodzenia_)
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }

        public override void wypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia + ", " + rok + "," + grupa + "," + nrIndeksu);
        }
    }

    class Ocena: Student
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_, string nazwaPrzedmiotu_,string data_, double wartosc_) : base(imie_, nazwisko_, dataUrodzenia_,rok_,grupa_,nrIndeksu_)
        {
            nazwaPrzedmiotu = nazwaPrzedmiotu_;
            data = data_;
            wartosc = wartosc_;
        }

        public override void wypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia + ", " + rok + "," + grupa + "," + nrIndeksu+", "+nazwaPrzedmiotu+", "+ data + ", " +wartosc);
        }
    }

    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_, int liczbaGoli_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;
            liczbaGoli = liczbaGoli_;
        }

        public override void wypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia + ", " + pozycja + ", " + klub + ", " + liczbaGoli);
        }

        public void strzelGola()
        {
            Console.WriteLine("Strzelam gola!");
            liczbaGoli++;
        }

    }
}
