using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich("Pan frica", "", "Carne", "Mayonesa", "Queso cheddar");

            Console.WriteLine($"{sandwich.Bread} {sandwich.Condiments} {sandwich.Protein} {sandwich.Veggies}");
            Console.ReadKey();
        }
    }
}
