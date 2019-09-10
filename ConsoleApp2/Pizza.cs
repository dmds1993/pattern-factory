using ConsoleApp2.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }

        public Sauce Sauce { get; set; }

        public List<Veggie> veggies { get; set; }

        public Cheese Cheese { get; set; }

        public Pepperoni Pepperoni { get; set; }

        public Clam Clam { get; set; }

        public Spinach Spinach { get; set; }

        public List<string> Toppings = new List<string>();

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Assando a pizza;");
        }

        public void Cut()
        {
            Console.WriteLine("Cortando pizza em 8");
        }

        public void Box()
        {
            Console.WriteLine("Guardando a pizza em uma caixa da PIZZA STORE");
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
