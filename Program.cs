using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assemble();

            Console.WriteLine($"{sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Condiments} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies}");
            Console.ReadKey();
        }
    }
}
