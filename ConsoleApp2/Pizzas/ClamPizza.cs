using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Clam = pizzaIngredientFactory.CreateClam();
        }
    }
}
