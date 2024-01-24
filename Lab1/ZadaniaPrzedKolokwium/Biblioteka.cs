namespace ZadaniaPrzedKolokwium;

public string Tytul { get; set; }
public string Autor { get; set; }
public int RokWydania { get; set; }

public Ksiazka(string tytul, string autor, int rokWydania)
{
    Tytul = tytul;
    Autor = autor;
    RokWydania = rokWydania;
}

public void WyswietlInformacje()
{
    Console.WriteLine($"Tytuł: {Tytul}, Autor: {Autor}, Rok wydania: {RokWydania}");
}
}

public class Biblioteka
{
    private List<Ksiazka> ksiazki = new List<Ksiazka>();

    public void DodajKsiazke(Ksiazka ksiazka)
    {
        ksiazki.Add(ksiazka);
    }

    public void WyswietlWszystkieKsiazki()
    {
        foreach (var ksiazka in ksiazki)
        {
            ksiazka.WyswietlInformacje();
        }
    }

    public void EdytujKsiazke(int index, Ksiazka nowaKsiazka)
    {
        if (index >= 0 && index < ksiazki.Count)
        {
            ksiazki[index] = nowaKsiazka;
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym indeksie.");
        }
    }

    public void UsunKsiazke(int index)
    {
        if (index >= 0 && index < ksiazki.Count)
        {
            ksiazki.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym indeksie.");
        }
    }

    public void WypiszKsiazkiAutora(string autor)
    {
        foreach (var ksiazka in ksiazki.Where(k => k.Autor == autor))
        {
            ksiazka.WyswietlInformacje();
        }
    }

    public void WypiszKsiazkiRoku(int rok)
    {
        foreach (var ksiazka in ksiazki.Where(k => k.RokWydania == rok))
        {
            ksiazka.WyswietlInformacje();
        }
    }