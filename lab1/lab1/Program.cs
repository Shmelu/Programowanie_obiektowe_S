using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        private string brand;
        private string model;
        private int numberOfDoors;      
        private int engineValue;
        private double averageComb;
        private int numberOfCars;

        public string Brand
        {
            get{ return brand; }
            set{ brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }

        

        public int EngineValuerOfDoors
        {
            get { return engineValue; }
            set { engineValue = value; }
        }

        public double AverageComb
        {
            get { return averageComb; }
            set { averageComb = value; } 
        }

        public int NumberOfCars
        {
            get { return numberOfCars; }
            set { numberOfCars = value; }
        }


        private double getComb()
        {
            return 0;
        }



        static void Main(string[] args)
        {
            Console.Write("");
        }
    }
}
