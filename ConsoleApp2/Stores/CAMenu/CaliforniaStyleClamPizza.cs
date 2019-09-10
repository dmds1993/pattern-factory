using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Stores.CAMenu
{
    public class CaliforniaStyleClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CaliforniaStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSouce();
            Clam = pizzaIngredientFactory.CreateClam();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
