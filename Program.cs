using MyApp.Controllers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new MainController();
            controller.Start();
            Console.ReadLine();
        }
    }
}