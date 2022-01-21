using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1.MyGame.GameObjects
{
    public abstract class GameObject
    {
        private Point _position;
        private Size _size;
        private ConsoleColor _color;

        public Point Position
        {
            get =>
                _position;

            set =>
                _position = value;
        }

        public Size Size
        {
            get => 
                new Size(_size.Width,
                _size.Height);

            set => 
                _size = 
                new Size(value.Width, 
                    value.Height);
        }

        public ConsoleColor Color
        {
            get => _color;

            set => _color = value;
        }
    }
}
