using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Area(5));

            //Console.WriteLine(Area(5, 6));

            //Console.WriteLine(Area(1, 2, 3));
        }

        //Area is Circle
        static int Area(int radius)
        {
            int p = 3;
            int area = p * (radius * radius);
            return area;
        }

        //Area is Square
        static int Area(int a, int b)
        {
            int area = a * b;
            return area;
        }

        //Area is Square Paralelepiped
        static int Area(int a, int b, int c)
        {
            int area = a * b + a * c + b * c;
            return area;
        }

    }
}
