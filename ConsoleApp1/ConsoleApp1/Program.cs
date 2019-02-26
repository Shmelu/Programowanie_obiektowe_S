using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string mark { set; get; }
        public string model { set; get; }
        public int doorsAmount { set; get; }
        public double engCap { set; get; }
        public double avgConsum { set; get; }
        public static int itemAmount  { set; get; }
        public Car()
        {
            itemAmount++;
            mark = "brak";
            model = "brak";
            doorsAmount = 0;
            engCap = 0;
            avgConsum = 0;
        }
        public Car(string mark_, string model_,
            int doorsAmount_, float engCap_, double avgConsum_)
        {
            itemAmount++;
            mark = mark_;
            model = model_;
            doorsAmount = doorsAmount_;
            engCap = engCap_;
            avgConsum = avgConsum_;
        }
        public double CountConsump(double distance)
        {
            return (distance * avgConsum) / 100;
        }
        public double CoTrPrice(double distance, double price)
        {
            return CountConsump(distance) * price;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Mark: " + mark);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Doors amount: " + doorsAmount);
            Console.WriteLine("Engine capacity: " + engCap);
            Console.WriteLine("Avarage consumption: " + avgConsum);
        }
        public static void ShowCarAmount()
        {
            Console.WriteLine("Amount of cars: "+itemAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car s1 = new Car();

            s1.ShowInfo();

            s1.mark = "Fiat";
            s1.model = "126p";
            s1.doorsAmount = 2;
            s1.engCap= 650;
            s1.avgConsum = 6.0;

            s1.ShowInfo();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            double trPrice = s2.CoTrPrice(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: {0:#.##}zł", trPrice);
            Car.ShowCarAmount();
            Console.ReadKey();

        }
    }
}
