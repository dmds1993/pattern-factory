using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Stores.CAMenu
{
    public class CaliforniaStyleCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CaliforniaStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
