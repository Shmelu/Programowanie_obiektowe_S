using System;

namespace Lab1
{
    /// <summary>
    /// Proszę zauważyć ze w tym przypadku zastosowano auto-properties.
    /// </summary>
    public class Garage
    {
        public Car[] Cars { get; set; }
        public string Address { get; set; }
        public int CarsCount { get; set; }
        private int _capacity;
        public int Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;
                Cars = new Car[value];
            }
        }

        public Garage()
        {
            Capacity = 0;
            Address = "none";
            CarsCount = 0;
        }

        public Garage(string address, int capacity)
        {
            Capacity = capacity;
            Address = address;
            CarsCount = 0;
        }

        public void CarEnter(Car car)
        {
            if (CarsCount >= Capacity)
                Console.WriteLine($"The garage at {Address} is full.");
            else
            {
                Cars[CarsCount] = car;
                CarsCount++;
            }
        }

        public Car CarLeave()
        {
            if (CarsCount == 0)
            {
                Console.WriteLine("There is no cars to leave.");
                return null;
            }
            else
            {
                Car car = Cars[CarsCount - 1];
                Cars[CarsCount - 1] = null;
                CarsCount--;
                return car;
            }
        }

        public override string ToString()
        {
            string str = $"Garage | Address: {Address}, Capacity: {Capacity}, Cars count: {CarsCount} \r\n CARS: \r\n";
            foreach (var car in Cars)
                str += car + "\r\n";
            str += "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++";
            return str;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
};