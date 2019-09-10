using ConsoleApp2.Stores;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYStylePizzaStore();
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("pepperoni");
            pizzaStore.OrderPizza("clam");

            PizzaStore pizzaStoreChicago = new ChicagoPizzaStore();
            pizzaStoreChicago.OrderPizza("cheese");
            pizzaStoreChicago.OrderPizza("pepperoni");
            pizzaStoreChicago.OrderPizza("clam");

            PizzaStore pizzaStoreCalifornia = new CaliforniaPizzaStore();
            pizzaStoreCalifornia.OrderPizza("cheese");
            pizzaStoreCalifornia.OrderPizza("clam");

            Console.ReadLine();
        }
    }
}
