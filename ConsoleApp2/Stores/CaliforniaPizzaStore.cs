using ConsoleApp2.interfaces;
using ConsoleApp2.Stores.CAMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Stores
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CaliforniaPizzaStore()
        {
            pizzaIngredientFactory = new CAPizzaIngredientFactory();
        }

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
                pizza = new CaliforniaStyleCheesePizza(pizzaIngredientFactory);

            if (type == "pepperoni")
                pizza = new CaliforniaStylePepperoniPizza(pizzaIngredientFactory);

            if (type == "clam")
                pizza = new CaliforniaStyleClamPizza(pizzaIngredientFactory);
            return pizza;
        }
    }
}
