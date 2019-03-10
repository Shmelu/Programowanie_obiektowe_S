using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1._0
{
    class Car
    {
        private string brand;
        private string model;
        private int doorCount;
        private int carcapacity;
        private double avgcomb;
        private static int carcount = 0;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int DoorCount
        {
            get { return doorCount; }
            set { doorCount = value; }
        }

        public int Carcapacity
        {
            get { return carcapacity; }
            set { carcapacity = value; }
        }

        public double Avgcomb
        {
            get { return avgcomb; }
            set { avgcomb = value; }
        }

        public Car()
        {
            brand = "nieznana";
            model = "nieznany";
            doorCount = 0;
            carcapacity = 0;
            avgcomb = 0.0;
        }

        public Car(string brand_, string model_, int doorCount_, int carcapacity_, double avgcomb_)
        {
            brand = brand_;
            model = model_;
            doorCount = doorCount_;
            carcapacity = carcapacity_;
            avgcomb = avgcomb_;
            carcount++;
        }
        
        public double ObliczSpalanie (double dlugoscTrasy)
        {
            
           double spalanie = (avgcomb * dlugoscTrasy) / 100.0;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa) 
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public static void WypiszIloscAut()
        {
            Console.WriteLine("ilosc aut: {0}",carcount);
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Liczba_drzwi: " + doorCount);
            Console.WriteLine("Poj_auta: " + carcapacity);
            Console.WriteLine("Srednie_spalanie: " + avgcomb);
        }

    }
    class Garage
    {
        private string adress;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Car[] samochody ;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Car[pojemnosc]; //skąd ta linijka ?
            }
        }

       public Garage()
        {
            adress = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garage(string _adress, int _pojemnosc)
        {
            adress = _adress;
            pojemnosc = _pojemnosc;
            samochody = new Car[pojemnosc]; // Czy to jest dobrze ? (chyba to wynika z tresci zadania)
        }

        public void WprowadzSamochod (Car car)
        {
            if (liczbaSamochodow >= pojemnosc)
                Console.WriteLine("Garaz jest pelny");
            else
            {
                samochody[liczbaSamochodow] = car;
                liczbaSamochodow++;
            }
        }

        public Car WyprowadzSamochod()
        {
            if (pojemnosc == 0)
            {
                Console.WriteLine("Garaz jest pusty");
                return null;
            }
            else
            {
                Car car = samochody[liczbaSamochodow - 1];
                car = null;
                liczbaSamochodow--;
                return car;
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.Model);// Dlaczego trzeba model wywołać z dużej liter?(właściwości mam z dużej litery)
            Console.WriteLine(c.Brand);
            Console.WriteLine(c.DoorCount);
            Console.WriteLine(c.Carcapacity);
            Console.WriteLine(c.Avgcomb);
            var d = new Car("BMW","E46",4,2,10.12);//konstruktor parametryczny wywołanie
            Console.WriteLine(d.Model);
            Console.WriteLine(d.Brand);
            Console.WriteLine(d.DoorCount);
            Console.WriteLine(d.Carcapacity);
            Console.WriteLine(d.Avgcomb);
            Console.WriteLine("Spalanie: {0}",d.ObliczSpalanie(1000));// Dlaczego piszemy {0}
            Console.WriteLine("Info: ");
            d.WypiszInfo();
            Car.WypiszIloscAut();
            Console.WriteLine("Koszt przejazdu: {0}", d.ObliczKosztPrzejazdu(1000, 5));
            var e = new Garage("Zarki-Letnisko",2);
            Console.WriteLine("Pojemnosc: {0}",e.Pojemnosc);
            Console.WriteLine("Adres: {0}", e.Adress);
            e.WprowadzSamochod(c);
            e.WprowadzSamochod(d);
            e.WyprowadzSamochod();
            e.WyprowadzSamochod();
            Console.ReadKey();
        }
    }
}
