using System;

namespace Triangle
{
    class Program
    {
        static void EnterPoint(ref Point p)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter x = ");
                    p.X = Double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Format error. Please enter again!");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter y = ");
                    p.Y= Double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Format error. Please enter again!");
                }
            }
        }
        static Triangle CreateTriangle()
        {
            Point a = new Point();
            Point b = new Point();
            Point c = new Point();
            Console.WriteLine("Enter a triangle: ");
            while (true)
            { 
                Console.WriteLine("Enter point A: ");
                EnterPoint(ref a);
                Console.Write("Point A");
                a.View();
                Console.WriteLine("Enter point B: ");
                EnterPoint(ref b);
                Console.Write("Point B");
                b.View();
                Console.WriteLine("Enter point C: ");
                EnterPoint(ref c);
                Console.Write("Point C");
                c.View();
                if (CheckTriangle(a, b, c))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ABC is not a triangle. Please re-enter the triangle!");
                }
            }
            return new Triangle(a, b, c);
        }
        static bool CheckTriangle(Point a, Point b, Point c)
        {
            Triangle t = new Triangle(a, b, c);
            double ab = t.EdgeAB();
            double bc = t.EdgeBC();
            double ac = t.EdgeAC();
            if (ab + bc <= ac || ab + ac <= bc || bc + ac <= ab)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Triangle triamgle = CreateTriangle();
            triamgle.View();
            Console.WriteLine("Perimeter of the triangle: {0}", triamgle.Perimeter());
            Console.WriteLine("Area of the triangle: {0}", triamgle.Area());
            Console.ReadKey();
        }
    }
}
