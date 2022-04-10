using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.PizzaTime
{
    public class Pizza
    {
        int _id;
        string _name;

        public readonly bool IsDelicious = true;

        public event EventHandler OnReady;

        public Pizza()
        {
            Random rand = new Random();

            Id =
                rand.Next(
                    100000,
                    999999);
        }

        public Pizza(string name) : this()
        {
            _name = name;
        }

        public int Id 
        { 
            get => _id;

            private set
            {
                if (value > 0) 
                    _id = value;
            }
        }

        public string Name 
        { 
            get => _name;
            
            private set => 
                _name = value; 
        }

        public void Ready()
        {
            OnReady?.Invoke(this, new EventArgs());
        }
    }
}
