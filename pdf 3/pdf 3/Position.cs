using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf_3
{
    abstract class Position
    {
        protected string title;
        protected int id;
        protected string publisher;
        protected int publishedIn;

        public Position()
        {
            title = "brak";
            id = 0;
            publisher = "brak";
            publishedIn = 0;
        }
        public Position(string title_, int id_,
            string publisher_, int publishedIn_)
        {
            title = title_;
            id = id_;
            publisher = publisher_;
            publishedIn = publishedIn_;
        }
        public void showInfo()
        {
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Publisher: "+publisher);
            Console.WriteLine("Year of publishment: "+publishedIn);
        }
    }
}
