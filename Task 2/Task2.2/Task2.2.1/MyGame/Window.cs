using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1.MyGame
{
    internal class Window
    {
        private int _width;
        private int _height;

        public int Width
        {
            get => _width;

            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new
                        ArgumentOutOfRangeException(
                        "value", "Cannot be negatives");
            }
        }

        public int Height
        {
            get => _height;

            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new
                        ArgumentOutOfRangeException(
                        "value", "Cannot be negatives");
            }
        }

        public Window()
        {

        }

        public Window(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
