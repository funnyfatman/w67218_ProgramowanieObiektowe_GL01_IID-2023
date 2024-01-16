using System;
namespace LAB2
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }

            return suma;
        }

        public int SumaPodziel3()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                if (liczba % 3 == 0)
                {
                    suma += liczba;
                }
            }

            return suma;
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

    }
}