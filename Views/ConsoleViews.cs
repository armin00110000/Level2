using System;
using MyApp.Models;

namespace MyApp.Views
{
    public class ConsoleView
    {
        //11. Integer Variabele
        public void ZeigeAlter(int alter)
        {
            Console.WriteLine($"Alter: {alter}");
        }
        //12. String Variabele
        public void ZeigeName(string name)
            {
            Console.WriteLine($"Name: {name}");
        }
        //13. Mehrere Variabelen
        public void ZeigePerson(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Alter: {person.Alter}, Stadt: {person.Stadt}");
        }
        //14. Berechnung und Ausgabe
        public void ZeigeBerechnung(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        //15. Variable ändern und ausgeben
        public void AendereUndZeigeVariable(ref int wert)
        {

           // Console.WriteLine($"Alter Wert: {wert}");
            wert += 5; // Beispiel: Wert um 5 erhöhen
          //  Console.WriteLine($"Neuer Wert: {wert}");

        }
        //16. Boolean Variable
        public void ZeigeBoolean(bool istSchuler, string name)
        {
            Console.WriteLine($"Ist {name} Schüler? {istSchuler}");

        }
        //17. double Variable
        public void ZeigeDouble(double temperatur)
        {
            Console.WriteLine($"Temperatur ist: {temperatur} grad Celsius");
        }
        //18. Konstante
        private const double PI = 3.14159;
        public void ZeigeKonstante(double radius, double umfang)
        {
                       
            Console.WriteLine($"Umfang des Kreises mit Radius {radius} cm ist: {umfang}");
        }
        public void ZeigeText(string text)
        {
            Console.WriteLine(text);
        }

        
    }
}