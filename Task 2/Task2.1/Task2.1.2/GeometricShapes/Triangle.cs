using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public sealed class Triangle : GeometricShape, ISquarable
    {
        private Point _point1;
        private Point _point2;
        private Point _point3;

        public Point Point1
        {
            get =>
                new Point(
                    _point1.X, _point1.Y);

            set =>
                _point1 =
                new Point(value.X, value.Y);
        }

        public Point Point2
        {
            get =>
                new Point(
                    _point2.X, _point2.Y);

            set =>
                _point2 =
                new Point(value.X, value.Y);
        }

        public Point Point3
        {
            get =>
                new Point(
                    _point3.X, _point3.Y);

            set =>
                _point3 =
                new Point(value.X, value.Y);
        }

        public Triangle()
        {

        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public float Area
        {
            get 
            {
                float halfPerimetr = Perimetr;

                return (float)Math.Sqrt(
                    halfPerimetr *
                    (halfPerimetr - LineLength(_point2, _point1)) *
                    (halfPerimetr - LineLength(_point3, _point1)) *
                    (halfPerimetr - LineLength(_point3, _point2)));
            }
        }

        public override float Perimetr => 
            LineLength(_point2, _point1) + 
            LineLength(_point3, _point1) + 
            LineLength(_point3, _point2);

        public override void Print()
        {
            Console.WriteLine(
                $"Triangle with Point 1 at {_point1}, " +
                $"Point 2 at {_point2}, Point 3 at {_point3}," +
                $"Area = {Area} and Perimetr = {Perimetr}");
        }
    }
}
