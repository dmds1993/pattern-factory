using ConsoleApp2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public ChicagoPizzaStore()
        {
            pizzaIngredientFactory = new CHPizzaIngredientFactory();
        }

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
                pizza = new ChicagoStyleCheesePizza(pizzaIngredientFactory);

            if (type == "pepperoni")
                pizza = new ChicagoStylePepperoniPizza(pizzaIngredientFactory);

            if (type == "clam")
                pizza = new ChicagoStyleClamPizza(pizzaIngredientFactory);
            return pizza;
        }
    }
}
