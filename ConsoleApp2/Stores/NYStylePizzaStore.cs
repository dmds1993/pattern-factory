using ConsoleApp2.Ingredients;
using ConsoleApp2.interfaces;
using ConsoleApp2.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class NYStylePizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public NYStylePizzaStore()
        {
            pizzaIngredientFactory = new NYPizzaIngredientFactory();
        }

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
                pizza =  new NYStyleCheesePizza(pizzaIngredientFactory);

            if (type == "pepperoni")
                pizza = new NYStylePepperoniPizza(pizzaIngredientFactory);

            if (type == "clam")
                pizza = new NYStyleClamPizza(pizzaIngredientFactory);

            return pizza;
        }
    }
}
