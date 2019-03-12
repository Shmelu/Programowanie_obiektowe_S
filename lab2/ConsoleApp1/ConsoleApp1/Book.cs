using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book: Position
    {
        public int NumberOfPages { get; private set; }

        public Book()
        {
            NumberOfPages = 0;
        }

        
    }
}
