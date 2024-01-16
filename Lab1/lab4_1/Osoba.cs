using System;
using System.Collections.Generic;
namespace lab4_1
{
    using System;

    public abstract class Osoba
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Pesel { get; private set; }

        public void SetFirstName(string imie)
        {
            Imie = imie;
        }

        public void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public int GetAge()
        {
            
            int rok = Convert.ToInt32(Pesel.Substring(0, 2));
            int miesiac = Convert.ToInt32(Pesel.Substring(2, 2));
            int dzien = Convert.ToInt32(Pesel.Substring(4, 2));
            DateTime dataUrodzenia = new DateTime(rok, miesiac, dzien); /
            int wiek = DateTime.Now.Year - dataUrodzenia.Year;
            return wiek;
        }

        public string GetGender()
        {
            return (Convert.ToInt32(Pesel[9]) % 2 == 0) ? "Kobieta" : "Mężczyzna";
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();
    }

}