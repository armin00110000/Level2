namespace MyApp.Models
{
   //11. bis 13. & 16.
    public class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Stadt { get; set; }
    }
    //15. Aufgabe
    public class VariableWert
    {
        public int Wert { get; set; } = 10;
    }

    //18. Konstante
    public class Kreis
    {
        private const double PI = 3.14159;
        public double Radius { get; set; }

        public double Umfang => 2 * Radius * PI;

    }
    }