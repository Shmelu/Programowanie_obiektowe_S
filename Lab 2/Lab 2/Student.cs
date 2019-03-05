using System;
using System.Collections.Generic
using System.Text
using System.Linq
using System.Threading.Tasks

namespace Lab2
{
    class Student
    {

        private int _rok;
        private int _grupa;
        private int _nrIndeksu;

    }



    public class Student(string imie, string nazwisko, DateTime dataurodzenia, int rok, int grupa, int nrIndeksu)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataurodzenia = _dataurodzenia;
            rok = _rok;
            grupa = _grupa;
            nrIndeksu = _nrIndeksu;

        }
}
 