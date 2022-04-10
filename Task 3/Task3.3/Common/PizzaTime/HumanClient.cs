using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.PizzaTime
{
    public class HumanClient
    {
        public event EventHandler OnPizzaTaken;

        public HumanClient(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int MyPizzaId { get; private set; }

        public Pizza MyDeliciousPizza 
        { get; private set; }

        public void PlaceOrder(
            Pizzeria pizzeria, 
            string pizzaName)
        {
            MyPizzaId = 
                pizzeria.PlaceOrder(
                pizzaName);

            foreach (var order in pizzeria.Orders)
            {
                if (order.Id == MyPizzaId)
                    order.OnReady += TakeMyDeliciousPizza;
            }
        }

        public void TakeMyDeliciousPizza(object pizza , EventArgs e)
        {
            MyDeliciousPizza = (Pizza)pizza;
        }
    }
}
