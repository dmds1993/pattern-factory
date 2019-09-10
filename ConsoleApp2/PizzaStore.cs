using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class PizzaStore
    {
        public string StoreName { get; set; }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
