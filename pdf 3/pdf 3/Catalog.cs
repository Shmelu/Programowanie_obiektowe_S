using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf_3
{
    class Catalog
    {
        private string thematicDep;
        public List<Position> posList { get; set; }
        public Catalog()
        {

        }
        public Catalog(string thematicDep_)
        {

        }
        public void AddPosition(Position position_)
        {
            if(posList!=null)
            posList.Add(position_);
        }
    }
}
