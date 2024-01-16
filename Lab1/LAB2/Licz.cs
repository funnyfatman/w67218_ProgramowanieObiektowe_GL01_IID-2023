using System;
public class Licz
{
    private int wartosc;

    public Licz(int wartosc)
    {
        this.wartosc = wartosc;
    }

    public void Dodaj(int liczba)
    {
        this.wartosc += liczba;
    }

    public void Odejmij(int liczba)
    {
        this.wartosc -= liczba;
    }

   
}