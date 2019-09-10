using ConsoleApp2.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.interfaces
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSouce();
        Cheese CreateChesse();
        List<Veggie> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}
