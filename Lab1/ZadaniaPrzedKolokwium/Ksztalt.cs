namespace ZadaniaPrzedKolokwium;

public abstract class Ksztalt
{
    public double X { get; set; }
    public double Y { get; set; }

    public Ksztalt(double x, double y)
    {
        X = x;
        Y = y;
    }

    public abstract double ObliczPole();
    public abstract double ObliczObwod();
}

public class Prostokat : Ksztalt
{
    public double Szerokosc { get; set; }
    public double Wysokosc { get; set; }

    public Prostokat(double x, double y, double szerokosc, double wysokosc) : base(x, y)
    {
        Szerokosc = szerokosc;
        Wysokosc = wysokosc;
    }

    public override double ObliczPole() => Szerokosc * Wysokosc;
    public override double ObliczObwod() => 2 * (Szerokosc + Wysokosc);
}

public class Trojkat : Ksztalt
{
    public double Podstawa { get; set; }
    public double Wysokosc { get; set; }

    public Trojkat(double x, double y, double podstawa, double wysokosc) : base(x, y)
    {
        Podstawa = podstawa;
        Wysokosc = wysokosc;
    }

    public override double ObliczPole() => Podstawa * Wysokosc / 2;
    public override double ObliczObwod() => Podstawa + 2 * Math.Sqrt(Math.Pow(Podstawa / 2, 2) + Math.Pow(Wysokosc, 2));
}

public class Kolo : Ksztalt
{
    public double Promien { get; set; }

    public Kolo(double x, double y, double promien) : base(x, y)
    {
        Promien = promien;
    }

    public override double ObliczPole() => Math.PI * Math.Pow(Promien, 2);
    public override double ObliczObwod() => 2 * Math.PI * Promien;
}