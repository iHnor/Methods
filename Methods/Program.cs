using System;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point pointA = new Point();
            pointA.x = 1;
            pointA.Print();

            Point pointB = pointA.Move(3);
            pointB.Print();

            Rect rect = new Rect();
            rect.width = 2;
            rect.height = 1;

            rect.Print();
            rect.Scale(3);
            rect.Print();
            int area = rect.GetArea();
            Console.WriteLine($"Area = {area}");
            int perimeter = rect.GetPerimeter();
            Console.WriteLine($"Perimeter = {perimeter}");

            rect.Move(3);
            rect.Print();
        }

        struct Point
        {
            public int x;
            public int y;

            public void Print()
            {
                Console.WriteLine(this);
            }

            public override string ToString()
            {
                return $"(x: {x}, y: {y})";
            }

            public Point Move(int offset)
            {
                return new Point()
                {
                    x = this.x + offset,
                    y = this.y + offset,
                };
            }
        }

        class Rect
        {
            public Point topLeft;
            public int width;
            public int height;

            public void Print()
            {
                Console.WriteLine($"[{topLeft}; {width} x {height}]");
            }

            public void Scale(int factor)
            {
                width *= factor;
                height *= factor;
            }

            public int GetArea()
            {
                int area = width * height;
                return area;
            }
            public int GetPerimeter()
            {
                int perimeter = 2 * (width + height);
                return perimeter;
            }
            public void Move(int offset)
            {   
                topLeft = topLeft.Move(offset);
            }
                
        }
    }
}
