using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    /// <summary>
    /// *Окружность
    /// </summary>
    public sealed class Round : GeometricShape
    {
        private Point _center;
        private float _radius;

        public Point Center 
        { 
            get => 
                new Point(_center.X, _center.Y);

            set => 
                _center = new Point(value.X, value.Y);
        }

        public float Radius 
        { 
            get => _radius;
            set 
            {
                if (value > 0)
                    _radius = value;
                else throw new ArgumentOutOfRangeException(
                        "value", "Cannot be negative");
            }
        }

        /// <summary>
        /// Circumference
        /// </summary>
        public override float Perimetr =>
            2 * (float)Math.PI * Radius;

        public Round()
        {

        }

        public Round(Point center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Print() 
        {
            Console.WriteLine(
                $"Circle with Center at {_center} and wtih Radius = {_radius}");
        }
    }
}
