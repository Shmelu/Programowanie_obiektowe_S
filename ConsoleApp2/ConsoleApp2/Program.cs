using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Samochod
    {
        private static int iloscSamochodow = 0;
        private string marka;
        private string model;
        private int ilosc_dzwi;
        private double pojemnosc_silnika;
        private double sredniespalanie;


        public Samochod(string marka_ = "brak",string model_="brak",int ilosc_=0,double pojemnosc_=0,double srednie_=0) {
            marka = marka_;
            model = model_;
            ilosc_dzwi = ilosc_;
            pojemnosc_silnika = pojemnosc_;
            sredniespalanie = srednie_;
            iloscSamochodow++;
        }
        public void WypiszInfo() { Console.WriteLine("Marka: " + marka+"\n"+"Model:"+model + "\n" + 
            "Ilosc drzwi: "+ilosc_dzwi + "\n" + "Pojemnosc_silnika: "+pojemnosc_silnika + "\n"+"Srednie spalanie: "+sredniespalanie+"\n"); }
       
                public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }        public string Model
        {
            get { return model; }
            set { model = value; }
        }       public int IloscDrzwi
        {
            get { return ilosc_dzwi; }
            set { ilosc_dzwi = value; }
        }        public double PojemnoscSilnika
        {
            get { return pojemnosc_silnika; }
            set { pojemnosc_silnika = value; }
        }
      
      public double SrednieSpalanie
        {
            get { return sredniespalanie; }
            set { sredniespalanie = value; }

        }

        private double ObliczSpalanie (double dlugoscTrasy)
        {
            return (sredniespalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy,double cenaPaliwa)
        {
            return SrednieSpalanie * cenaPaliwa;
        }
        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(iloscSamochodow);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();
            s1.Marka = "Fiat";
            s1.Model = "126p";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 650;
            s1.SrednieSpalanie = 6.0;            s1.WypiszInfo();            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);            Samochod.WypiszIloscSamochodow();            Console.ReadLine();
        }
    }
}
