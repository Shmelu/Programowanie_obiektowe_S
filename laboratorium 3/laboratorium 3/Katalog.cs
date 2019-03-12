using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium_3
{
    class Katalog
    {
        private string dzialTematyczny;

        public List<Pozycja> posList { get; private set; }
        public Katalog()
        {



        }

        public Katalog(string dzialTematyczny_)
        {


        }


        public Pozycja AddPozycja (Pozycja pozycja_)
        {

            List<Pozycja> posList;
            
            return pozycja_;

        }

        
     }


}
