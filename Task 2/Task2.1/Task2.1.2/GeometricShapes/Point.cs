using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1._2.GeometricShapes
{
    public struct Point
    {
        public float X;
        public float Y;

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Point Parse(string str)
        {
            string[] floats = str.Split(';');

            return new Point(
                float.Parse(floats[0]), 
                float.Parse(floats[1]));
        }

        public override string ToString()
        {
            return
                $"({X};{Y})";
        }
    }
}
