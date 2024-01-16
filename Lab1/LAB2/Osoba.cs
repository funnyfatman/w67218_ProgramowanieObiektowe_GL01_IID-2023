namespace LAB2
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private Samochod samochod;

        public string ImieNazwisko
        {
            get { return imie + " " + nazwisko; }
        }

        public Osoba(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public bool CzyPelnoletni()
        {
            return (DateTime.Now - dataUrodzenia).TotalDays / 365.25 >= 18;
        }

        public void ZmienNazwisko(string noweNazwisko)
        {
            nazwisko = noweNazwisko;
        }

        public void UstawSamochod(Samochod samochod)
        {
            this.samochod = samochod;
        }
    }
}