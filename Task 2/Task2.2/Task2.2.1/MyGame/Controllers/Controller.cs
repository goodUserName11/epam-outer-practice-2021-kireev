using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2._2._1.MyGame.GameObjects;

namespace Task2._2._1.MyGame.Controllers
{
    public abstract class Controller
    {
        private GameObject _gameObject;

        public GameObject GameObject 
        { 
            get => _gameObject; 
            set => _gameObject = value; 
        }
    }
}
