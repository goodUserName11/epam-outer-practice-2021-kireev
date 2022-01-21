using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    abstract public class GeometricShape
    {
        /// <summary>
        /// Perimetr of shape
        /// </summary>
        public abstract float Perimetr
        {
            get;
        }

        protected static float LineLength(Line line)
        {
            Point startPoint = line.StartPoint;
            Point endpoint = line.EndPoint;

            return 
                LineLength(startPoint, endpoint);
        }

        protected static float LineLength(
            Point startPoint, Point endpoint)
        {
            return
                Math.Abs(
                    (float)Math.Sqrt(
                        Math.Pow(startPoint.Y - startPoint.Y, 2) -
                        Math.Pow(endpoint.X - endpoint.X, 2)
                ));
        }

        /// <summary>
        /// Prints characteristics of shape
        /// </summary>
        /// <returns></returns>
        public abstract void Print();
    }
}
