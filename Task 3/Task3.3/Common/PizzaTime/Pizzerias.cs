using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.PizzaTime
{
    public static class Pizzerias
    {
        //static List<Pizzeria> _pizzeriasList = new List<Pizzeria>();

        //public static List<Pizzeria> PizzeriasList 
        //{ 
        //    get => new List<Pizzeria>(_pizzeriasList);
            
        //    private set => _pizzeriasList = value; 
        //}

        ///// <summary>
        ///// Add new pizzeria
        ///// </summary>
        ///// <param name="pizzeriaName"></param>
        //public static void AddNewPizzeria(
        //    string pizzeriaName)
        //{
        //    _pizzeriasList.Add(
        //        new Pizzeria(pizzeriaName));
        //}
        
        ///// <summary>
        ///// Place order by name of the pizzeria
        ///// </summary>
        //public static int PlaceOrderByName(
        //    string pizzeriaName, string pizzaName, 
        //    HumanClient client)
        //{
        //    int id = -1;
        //    foreach (var pizzeria in _pizzeriasList)
        //    {
        //        if (pizzeria.Name == pizzeriaName)
        //        {
        //            id = pizzeria.CreateOrder(pizzaName);

        //            pizzeria.OnPizzaReady += client.;
        //        }
        //    }

        //    if(id == -1)
        //        throw new
        //            InvalidOperationException(
        //            "There is no such pizzeria!");

        //    return id;
        //}

        ///// <summary>
        ///// Get pizza by name of the pizzeria
        ///// </summary>
        //public static Pizza 
        //    GetReadyPizzaByPizzeriaName(
        //    string pizzeriaName, int id)
        //{
        //    Pizza clientPizza = null;

        //    foreach (var pizzeria in _pizzeriasList)
        //    {
        //        if(pizzeria.Name == pizzeriaName) 
        //        {
        //            clientPizza = pizzeria.GetPizza(id);
        //        }

        //    }

        //    return clientPizza;
        //}
    }
}
