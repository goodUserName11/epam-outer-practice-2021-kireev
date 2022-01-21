using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public sealed class Square : GeometricShape, ISquarable
    {
        private Point _startPoint;
        private float _sideLength;

        public Point StartPoint
        {
            get =>
                new Point
                (_startPoint.X, 
                    _startPoint.Y);

            set =>
                _startPoint = 
                new Point(value.X, value.Y);
        }

        public float SideLength
        {
            get => _sideLength;

            set
            {
                if (value > 0)
                {
                    _sideLength = value;
                }
                else throw new
                    ArgumentOutOfRangeException(
                    "value", "Cannot be negative");
            }
        }

        public Square()
        {

        }

        public Square(Point point, float lineLength)
        {
            StartPoint = point;
            SideLength = lineLength;
        }

        public float Area => 
            SideLength * SideLength;

        public override float Perimetr => 
            SideLength * 4;

        public override void Print()
        {
            Console.WriteLine(
                $"Square with Start at {_startPoint}," +
                $"Side length = {_sideLength}," +
                $"Area = {Area} and with Perimetr = {Perimetr}");
        }
    }
}
