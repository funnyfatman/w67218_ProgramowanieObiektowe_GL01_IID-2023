using System;

namespace LAB2
{
    public class Samochod
    {
        public string Marka;
        public string Model;
        public int RokProdukcji;

        private int predkosc;
        private int przebieg;
        private StanSilnika stanSilnika;

        public enum StanSilnika
        {
            Wylaczony,
            Wlaczony,
            CheckEngine
        }

        public Samochod(string marka, string model, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
            this.przebieg = przebieg;
            stanSilnika = StanSilnika.Wylaczony;
        }

        public void UstawTempomat(int zadanaPredkosc)
        {
            if (stanSilnika == StanSilnika.Wlaczony)
            {
                predkosc = zadanaPredkosc;
            }
        }

        public void ZwiekaszPredkosc()
        {
            if (stanSilnika == StanSilnika.Wlaczony)
            {
                predkosc += 5;
            }
        }

        public void ZmniejszPredkosc()
        {
            if (stanSilnika == StanSilnika.Wlaczony)
            {
                predkosc -= 5;
            }
        }

        public void UruchomSilnik()
        {
            if (stanSilnika != StanSilnika.CheckEngine)
            {
                stanSilnika = StanSilnika.Wlaczony;
            }
            else
            {
                throw new InvalidOperationException("Silnik wymaga sprawdzenia (Check Engine).");
            }
        }

        public void ZatrzymajSilnik()
        {
            stanSilnika = StanSilnika.Wylaczony;
        }
    }
}