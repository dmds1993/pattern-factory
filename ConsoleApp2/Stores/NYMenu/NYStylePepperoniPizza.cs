using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class NYStylePepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public NYStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Pepperoni = pizzaIngredientFactory.CreatePepperoni();
        }
    }
}
