using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ChicagoStyleClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public ChicagoStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Cheese = pizzaIngredientFactory.CreateChesse();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
