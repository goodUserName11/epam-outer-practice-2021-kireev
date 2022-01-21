using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    /// <summary>
    /// *Круг
    /// </summary>
    public sealed class Circle : GeometricShape, ISquarable
    {
        /// <summary>
        /// *Описанная окружность
        /// </summary>
        Round _circumcircle;

        public Round Circumcircle 
        { 
            get => 
                new Round(_circumcircle.Center, 
                    _circumcircle.Radius); 
            set => 
                _circumcircle = 
                new Round(value.Center, value.Radius); 
        }

        public Point Center
        {
            get =>
                _circumcircle.Center;
            set =>
                _circumcircle.Center = value;
        }

        public float Radius
        {
            get =>
                _circumcircle.Radius;
            set =>
                _circumcircle.Radius = value;
        }

        /// <summary>
        /// Circumference of circumcircle
        /// </summary>
        public override float Perimetr 
        {
            get =>
                _circumcircle.Perimetr;
        }

        public float Area =>
            (float)(Math.PI *
                Math.Pow(_circumcircle.Radius, 2)
            );

        public Circle()
        {
            _circumcircle = new Round();
        }

        public Circle(Round circumcircle)
        {
            Circumcircle = circumcircle;
        }

        public Circle(Point center, float radius)
        {
            _circumcircle = new Round(center, radius);
        }



        public override void Print()
        {
            Console.WriteLine( 
                $"Circle with Center at {_circumcircle.Center} " +
                $"and radius = {_circumcircle.Radius}");
        }
    }
    
}
