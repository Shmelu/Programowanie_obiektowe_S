using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 WEJŚCIOWKA
 Dziedziczenie,polimorfizm,Properties,agregacja,kompozycja,asocjacja,typy wartościowe, typy referencyjne,
 metody wirtualne,głębokie kopiowanie, płytkie kopiowanie, kopiowanie obiektów
 */

namespace LABS02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pearson P1 = new Pearson("Thomas", "Hithook", new DateTime(1998,04,01));
            P1.DisplayData();
            Console.ReadKey();
        }
    }
}
