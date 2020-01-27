using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assemble()
        {
            _sandwichBuilder.AddBread();
            _sandwichBuilder.AddCheese();
            _sandwichBuilder.AddVeggies();
            _sandwichBuilder.AddCondiments();
            _sandwichBuilder.AddProtein();
        }

        public Sandwich GetSandwich
        {
            get { return _sandwichBuilder.sandwich;  } 
        }

    }
}
