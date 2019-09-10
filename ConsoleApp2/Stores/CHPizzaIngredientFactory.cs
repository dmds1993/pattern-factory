using ConsoleApp2.Ingredients;
using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class CHPizzaIngredientFactory : IPizzaIngredientFactory    {
        public Cheese CreateChesse()
        {
            return new ReggianoCheese();
        }

        public Clam CreateClam()
        {
            Console.WriteLine("Molusco Fresco");
            return new FreshClam();
        }

        public Dough CreateDough()
        {
            Console.WriteLine("Massa grossa");
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            Console.WriteLine("Pepperoni");
            return new SlicedPepperoni();
        }

        public Sauce CreateSouce()
        {
            Console.WriteLine("Souce");
            return new MarinaraSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            Console.WriteLine("Veggies");
            return new List<Veggie>();
        }
    }
}
