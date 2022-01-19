using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public sealed class Line : GeometricShape
    {
        private Point _startPoint;
        private Point _endPoint;

        public Point StartPoint 
        { 
            get => 
                new Point(_startPoint.X, _startPoint.Y); 
            set => 
                _startPoint = new Point(value.X, value.Y); 
        }
        
        public Point EndPoint
        {
            get =>
                new Point(_endPoint.X, _endPoint.Y);
            set =>
                _endPoint = new Point(value.X, value.Y);
        }

        /// <summary>
        /// Length of the line
        /// </summary>
        public override float Perimetr
        {
            get
            {
                return
                    LineLength(this);
            }
        }

        public Line()
        {

        }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"Line with Start at {_startPoint}, " +
                $"End at {_endPoint} and with Length = {Perimetr}");
        }
    }
}
