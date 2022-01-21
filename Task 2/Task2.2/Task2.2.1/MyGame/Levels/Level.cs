using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2._2._1.MyGame.GameObjects;

namespace Task2._2._1.MyGame.Levels
{
    public class Level
    {
        private GameObject[] _gameObjects;
        private string _name;

        public GameObject[] GameObjects 
        { 
            get => _gameObjects; 
            set => _gameObjects = value; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
    }
}
