using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Position
    {
        public string Title { get; protected set; }
        public int Id { get; protected set; }
        public string PubHouse { get; protected set; }
        public int YearOfPublish { get; protected set; }

        public Position()
        {
            Title = null;
            Id = 0;
            PubHouse = null;
            YearOfPublish = 0;
        }

        public Position(string _title,int _id, string _pubHouse, int _yearOfPublish)
        {
            Title = _title;
            Id = _id;
            PubHouse = _pubHouse;
            YearOfPublish = _yearOfPublish;
        }

        public string toString()
        {
            return "title: " + title + ", id: " + Id + ", Publish House: " + PubHouse + ", Year of House: " + YearOfPublish;  
        }
    }
}
