using System;

namespace TheRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();

            Rectangle rectangle01 = new Rectangle("Rectangle 01",
                                                  "Red",
                                                   new Point(2, 1),
                                                   new Point(4, 6));

            Console.WriteLine(rectangle01.ToString());

            Rectangle rectangle02 = new Rectangle("Rectangle 02",
                                                  "Black",
                                                   new Point(3, 3),
                                                   new Point(7, 8));

            Console.WriteLine(rectangle02.ToString());

            Console.WriteLine("Overlapped area: " + OverlappedArea(rectangle01, rectangle02));
        }

        public static int OverlappedArea(Rectangle rectangleOne, Rectangle rectangleTwo)
        {
            //var rectangleOneArea = rectangleOne.Area();
            //var rectangleTwoArea = rectangleTwo.Area();

            int areaOverlapped = (Math.Min(rectangleOne.vertexTwo.x, rectangleTwo.vertexTwo.x) -
                                 Math.Max(rectangleOne.vertexOne.x, rectangleTwo.vertexOne.x)) *
                                 (Math.Min(rectangleOne.vertexTwo.y, rectangleTwo.vertexTwo.y) -
                                 Math.Max(rectangleOne.vertexOne.y, rectangleTwo.vertexOne.y));

            //return (rectangleOneArea + rectangleTwoArea - areaOverlapped);
            return areaOverlapped;
        }


    }
}
