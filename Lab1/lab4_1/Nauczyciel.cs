using System;
using System.Collections.Generic;
namespace lab4_1
{
    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; private set; }
        public List<Uczen> PodwladniUczniowie { get; private set; }

        public Nauczyciel()
        {
            PodwladniUczniowie = new List<Uczen>();
        }

        public void WhichStudentCanGoHomeAlone()
        {
            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine($"{uczen.GetFullName()} może iść sam do domu.");
                }
            }
        }

        public void PrintSchedule(DateTime date)
        {
            Console.WriteLine($"{Szkoła} Dnia: {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel: {TytulNaukowy} {Imie} {Nazwisko}");
            Console.WriteLine("Lista studentów:");
            for (int i = 0; i < PodwladniUczniowie.Count; i++)
            {
                var student = PodwladniUczniowie[i];
                string plec = student.GetGender();
                string verdict = student.CanGoAloneToHome() ? "Może iść sam do domu" : "Nie może iść sam do domu";
                Console.WriteLine($"{i + 1}. {student.Imie} {student.Nazwisko} - {plec} – {verdict}");
            }
        }
    }

}