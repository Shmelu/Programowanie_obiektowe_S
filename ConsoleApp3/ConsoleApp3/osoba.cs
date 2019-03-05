using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Osoba
    {
        private string _imie;
        private string _nazwisko;
        private DateTime _dataurodzenia;

    }

    public class Osoba(string imie, string nazwisko, DateTime dataurodzenia)
    {

        _imie = imie;
        _nazwisko = nazwisko;
        _dataurodzenia = dataurodzenia;
     }  
  }

public override string ToString()
{
    return $"Person data | First name: {imie}, Last name: {nazwisko}, Date of birth {dataurodzenia}"

}

