using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Stores.CAMenu
{
    public class CaliforniaStylePepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CaliforniaStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Pepperoni = pizzaIngredientFactory.CreatePepperoni();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
