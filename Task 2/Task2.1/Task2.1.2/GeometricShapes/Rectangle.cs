using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public sealed class Rectangle : GeometricShape, ISquarable
    {
        private Point _startPoint;
        private Point _endPoint;

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

        public Point EndPoint
        {
            get =>
                new Point
                (_endPoint.X,
                    _endPoint.Y);
            set =>
                _endPoint =
                new Point(value.X, value.Y);
        }

        public float Length
        {
            get => 
                Math.Abs(
                    _endPoint.X - _startPoint.X);
        }

        public float Width
        {
            get => 
                Math.Abs(
                    _endPoint.Y - _startPoint.Y);
        }

        public Rectangle()
        {
        }

        public Rectangle(
            Point startPoint, Point endPoint)
        {
            if (endPoint.X > startPoint.X &&
                endPoint.Y > startPoint.Y)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }
            else
            { 
                StartPoint = endPoint;
                EndPoint = startPoint;
            }
        }

        public Rectangle(
            Point startPoint
            ,float length, float width)
        {
            StartPoint = startPoint;

            EndPoint = new Point(
                startPoint.X + length,
                startPoint.Y + width);
        }

        public float Area => 
            Length * Width;

        public override float Perimetr => 
            (Length * 2) + (Width * 2);

        public override void Print()
        {
            Console.WriteLine(
                $"Rectangle with Start at {_startPoint}, " +
                $"End at {_endPoint}, " +
                $"with Width = {Width}, Length = {Length}," +
                $"Area = {Area} and with Perimetr = {Perimetr}");
        }
    }
}
