using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Vector
    {
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double EndX { get; set; }
        public double EndY { get; set; }

        public Vector(double startX, double startY, double endX, double endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

        public static Vector operator *(double scalar, Vector vector)
        {
            double newX = scalar * (vector.EndX - vector.StartX);
            double newY = scalar * (vector.EndY - vector.StartY);

            return new Vector(vector.StartX, vector.StartY, vector.StartX + newX, vector.StartY + newY);
        }

        public override string ToString()
        {
            return $"({StartX}, {StartY}) -> ({EndX}, {EndY})";
        }
    }
}
