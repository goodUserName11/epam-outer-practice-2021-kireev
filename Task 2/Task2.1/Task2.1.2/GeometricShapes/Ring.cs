using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public sealed class Ring : GeometricShape, ISquarable
    {
        private Circle _innerRound;
        private Circle _outerRound;

        public Point Center
        {
            get =>
                _innerRound.Center;
            set 
            {
                _innerRound.Center = value;
                _outerRound.Center = value;
            }
        }

        public float InnerRadius
        {
            get => _innerRound.Radius;

            set =>
                _innerRound.Radius = value;
        }

        public float OuterRadius
        {
            get => _outerRound.Radius;

            set =>
                _outerRound.Radius = value;
        }

        /// <summary>
        /// Sum of circumferences of inner and outer circles
        /// </summary>
        public override float Perimetr =>
            _innerRound.Perimetr + 
            _outerRound.Perimetr;

        /// <summary>
        /// Area between two circles
        /// </summary>
        public float Area =>
            _outerRound.Area - _innerRound.Area;

        public Ring()
        {
            _innerRound = new Circle();
            _outerRound = new Circle();
        }

        public Ring(Point center, 
            float innerRadius, float outerRadius)
        {
            _innerRound = new Circle(center, innerRadius);
            _outerRound = new Circle(center, outerRadius);
        }

        public override void Print()
        {
            Console.WriteLine(
                $"Ring Center at {Center}, Inner radius = {InnerRadius}," +
                $" Outer radius = {OuterRadius}");
        }
    }
}
