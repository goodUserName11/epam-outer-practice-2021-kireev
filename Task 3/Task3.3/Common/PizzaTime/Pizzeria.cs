using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.PizzaTime
{
    public class Pizzeria
    {
        string _name;
        List<Pizza> _orders;

        public Pizzeria(string name)
        {
            Name = name;

            Orders = new List<Pizza>();
        }

        public string Name 
        { 
            get => _name;
            
            private set => 
                _name = value; 
        }
        public List<Pizza> Orders 
        {
            get =>
                new List<Pizza>(_orders); 

            private set => 
                _orders = value;
        }

        public int PlaceOrder(
            string pizzaName)
        {
            Pizza newOrder = new Pizza(pizzaName);

            _orders.Add(newOrder);

            return newOrder.Id;
        }

        public void MakeFirstPizza()
        {
            if (_orders.Count > 0)
            {
                Thread.Sleep(1000);

                _orders[0].Ready();

                _orders.RemoveAt(0);
            }
            else throw new
                    InvalidOperationException(
                        "There are no orders");
        }
    }
}
