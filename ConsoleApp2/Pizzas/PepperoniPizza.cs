using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
