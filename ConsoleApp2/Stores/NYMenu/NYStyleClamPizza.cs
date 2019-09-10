using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class NYStyleClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public NYStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
