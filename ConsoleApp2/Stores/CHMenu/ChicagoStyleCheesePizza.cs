using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public ChicagoStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Cheese = pizzaIngredientFactory.CreateChesse();
        }
    }
}
