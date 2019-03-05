using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Pilkarz
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;
    }
}

public class Pilkarz(string imie, string nazwisko, DateTime dataurodzenia,
    string pozycja, string klub, string liczbaGoli)

        imie = _imie;
        nazwisko = _nazwisko;
        dataurodzenia = _dataurodzenia;
        pozycja = _pozycja;
        klub = _klub;