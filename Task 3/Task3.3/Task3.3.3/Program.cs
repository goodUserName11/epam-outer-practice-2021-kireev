using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.PizzaTime;

namespace Task3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria p1 = new Pizzeria("MyPizza");

            HumanClient h1 = new HumanClient("Vitaliy");
            HumanClient h2 = new HumanClient("Vasiliy");

            Console.WriteLine("Creating orders");

            h1.PlaceOrder(p1, "My First Pizza");
            h2.PlaceOrder(p1, "My First Pizza too");

            Console.WriteLine("Making Pizzas");

            p1.MakeFirstPizza();

            Console.WriteLine(
                $"{h1.Name} is eating pizza: " +
                $"{h1.MyDeliciousPizza.Name}. " +
                $"It's delicious? " +
                $"{(h1.MyDeliciousPizza.IsDelicious ? "Yes": "Steel delicious")}");

            p1.MakeFirstPizza();

            Console.WriteLine(
                $"{h2.Name} is eating pizza: " +
                $"{h2.MyDeliciousPizza.Name}. " +
                $"It's delicious? " +
                $"{(h2.MyDeliciousPizza.IsDelicious ? "Yes" : "Steel delicious")}");

            Console.ReadKey();
        }
    }
}
