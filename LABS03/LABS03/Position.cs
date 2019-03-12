using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03
{
    public class Position
    {
        protected string _title;
        protected int _id;
        protected string _publisher;
        protected int _relaseDate;

        public string Title
        {
            get { return _title;}
            set { _title = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public int RealseDate
        {
            get { return _relaseDate; }
            set { _relaseDate = value; }
        }
        public Position()
        {
            Title = "VOID";
            ++ID;
            Publisher = "VOID";
            _relaseDate = 0;
        }
        public Position(string Title, int ID, string Publisher, int RelaseDate)
        {
            Title = _title;
            ++ID;
            Publisher = _publisher;
            RelaseDate = _relaseDate;
        }

    }
}
