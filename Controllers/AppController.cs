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
            view.ZeigeName(person.Name);
            view.ZeigePerson(person);
            view.ZeigeBerechnung(5, 3);
            int meineVariable = 10;
            view.ZeigeText($"Vorher: {meineVariable}");
            view.AendereUndZeigeVariable(ref meineVariable); // ref ist hier nötig
            view.ZeigeText($"Nachher: {meineVariable}");
            bool istSchueler = true; // Beispielwert
            view.ZeigeBoolean(istSchueler, person.Name);
            view.ZeigeDouble(23.5);
            const double PI = 3.14159;
            double radius = 5;
            double umfang = 2 * radius * PI; // Umfang eines Kreises
            view.ZeigeKonstante(radius,umfang);
            view.ZeigeText("Drücke Enter zum Beenden...");
        }
    }
}