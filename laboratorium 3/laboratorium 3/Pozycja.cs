using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium_3
{
    class Pozycja
    {

        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {

            tytul = "Brak";
            id = 0;
            wydawnictwo = "Brak";
            rokWydania = 0;

        }

        public Pozycja(string tytul_, int id_, string wydawnictwo_, int rokWydania_)
        {

            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;

        }

        public void wypiszInfo()
        {

            Console.WriteLine("Tytuł: "+tytul);
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Wydawnictwo: "+wydawnictwo);
            Console.WriteLine("Rok Wydania: "+rokWydania);

        }

    }



}
