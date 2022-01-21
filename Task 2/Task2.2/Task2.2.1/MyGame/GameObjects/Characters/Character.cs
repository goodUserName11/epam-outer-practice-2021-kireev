using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2._2._1.MyGame.Interfaces;

namespace Task2._2._1.MyGame.GameObjects.Characters
{
    public abstract class Character : GameObject, IMoveable, IDestructable
    {
        private int _hp;
        private int _maxhp;
        private float _speed;

        public int HP
        {
            get => _hp;

            set
            {
                if (value >= 0)
                    _hp = value;
                else throw new 
                        ArgumentOutOfRangeException(
                    "value", "Cannot be negative");
            }   
        }

        public int MaxHP
        {
            get => _maxhp;

            set
            {
                if (value >= 0)
                    _maxhp = value;
                else throw new
                        ArgumentOutOfRangeException(
                    "value", "Cannot be negative");
            }
        }

        public float Speed 
        {
            get => _speed;

            set
            {
                if (value >= 0)
                    _speed = value;
                else throw new
                        ArgumentOutOfRangeException(
                    "value", "Cannot be negative");
            }
        }

        public abstract void Death();
        public abstract void Move();


    }
}
