namespace lab4_1
{
    public class Uczen : Osoba
    {
        public string Szkoła { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public void SetSchool(string szkola)
        {
            Szkoła = szkola;
        }

        public void ChangeSchool(string nowaSzkola)
        {
            Szkoła = nowaSzkola;
        }

        public void SetCanGoHomeAlone(bool moze)
        {
            MozeSamWracacDoDomu = moze;
        }

        public override string GetEducationInfo()
        {
            return $"Szkoła: {Szkoła}";
        }

        public override string GetFullName()
        {
            return $"{Imie} {Nazwisko}";
        }

        public override bool CanGoAloneToHome()
        {
            if (MozeSamWracacDoDomu || GetAge() >= 12)
            {
                return true;
            }
            return false;
        }

        public string Info()
        {
            return CanGoAloneToHome() ? "" : "Nie może sam wracać do domu.";
        }
    }

}