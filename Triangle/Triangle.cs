using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        Point a;
        Point b;
        Point c;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Point A { get => a; set => a = value; }
        public Point B { get => b; set => b = value; }
        public Point C { get => c; set => c = value; }

        public void View()
        {
            Console.WriteLine("The{0} triangle: ", TypeOfTriangle());
            Console.WriteLine("A = ({0} , {1})", A.X, A.Y);
            Console.WriteLine("B = ({0} , {1})", B.X, B.Y);
            Console.WriteLine("C = ({0} , {1})", C.X, C.Y);
        }

        public double EdgeAB()
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public double EdgeAC()
        {
            return Math.Sqrt(Math.Pow((A.X - C.X), 2) + Math.Pow((A.Y - C.Y), 2));
        }

        public double EdgeBC()
        {
            return Math.Sqrt(Math.Pow((C.X - B.X), 2) + Math.Pow((C.Y - B.Y), 2));
        }

        public String TypeOfTriangle()
        {
            String type = "";
            double ab = EdgeAB();
            double bc = EdgeBC();
            double ac = EdgeAC();
            if (ab == ac && ac == bc)
                type += " equilateral";
            else if (ab == ac || ac == bc || ab == bc)
                type += " isosceles";
            if (Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2)) == bc
                || Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)) == ac
                || Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2)) == ab)
                type += " right";
            return type;
        }

        public double Perimeter()
        {
            return EdgeAB() + EdgeAC() + EdgeBC();
        }

        public double Area()
        {
            double ab = EdgeAB();
            double bc = EdgeBC();
            double ac = EdgeAC();
            double p = (ab + ac + bc) / 2;
            return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
        }
    }
}
