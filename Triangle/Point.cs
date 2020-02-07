using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
            this.X = this.Y = 0;
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public void View()
        {
            Console.WriteLine("({0} , {1})", X, Y);
        }
    }
}
