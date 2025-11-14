using MyApp.Models;
using MyApp.Views;

namespace MyApp.Controllers
{
    public class MainController
    {
        private readonly ConsoleView view = new ConsoleView();

        public void Start()
        {
            var person = new Person { Name = "armin", Alter = 55, Stadt = "Berlin" };
            view.ZeigeAlter(person.Alter);
            Console.WriteLine();
            view.ZeigeName(person.Name);
            Console.WriteLine();
            view.ZeigePerson(person);
            Console.WriteLine();
            view.ZeigeBerechnung(5, 3);
            Console.WriteLine();
            int meineVariable = 10;
            view.ZeigeText($"Vorher: {meineVariable}");
            view.AendereUndZeigeVariable(ref meineVariable); // ref ist hier nötig
            view.ZeigeText($"Nachher: {meineVariable}");
            Console.WriteLine();
            bool istSchueler = true; // Beispielwert
            view.ZeigeBoolean(istSchueler, person.Name);
            Console.WriteLine();
            view.ZeigeDouble(23.5);
            Console.WriteLine();
            const double PI = 3.14159;
            double radius = 5;
            double umfang = 2 * radius * PI; // Umfang eines Kreises
            view.ZeigeKonstante(radius,umfang);
            Console.WriteLine();
            var person19 = new Person19
            {
                Vorname = "Armand",
                Nachname = "Monette",
                Stadt = "Berlin",
                Geburtsort = "Paris"
            };

            view.ZeigeSatz(person19.Vorname, person19.Nachname, person19.Stadt, person19.Geburtsort);
            Console.WriteLine();

            var zahlen = new Zahlen
            {
                Zahl1 = 10,
                Zahl2 = 5.5,
                Zahl3 = 4.0,
                Zahl4 = 9.0
            };

            view.FuehreGrundrechenarten(zahlen.Zahl1, zahlen.Zahl2, zahlen.Zahl3, zahlen.Zahl4);

            Console.WriteLine();
            view.ZeigeText("Drücke Enter zum Beenden...");
        }
    }
}