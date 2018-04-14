using System;
using System.Collections.Generic;

namespace TheRectangles
{
    public class Rectangle : Quadrilateral
    {

        public Rectangle(string name, string color, Point vertexOne, Point vertexTwo) : base(name, color, vertexOne, vertexTwo)
        {
            if (IsRegular() == false)
            {
                throw new Exception("The vertexes are incompatible with a rectangle.");
            }
        }

        public override int Area()
        {
            List<Point> vertices234 = new List<Point>() { vertexTwo, vertexTwo, vertexThree };

            Point auxVertex = vertexOne.Nearest(vertices234);
            List<Point> otherVertices = null;
            if (auxVertex.Equals(vertexTwo))
            {
                otherVertices = new List<Point> { vertexThree, vertexFour };
            }
            else if (auxVertex.Equals(vertexThree))
            {
                otherVertices = new List<Point> { vertexTwo, vertexFour };
            }
            else if (auxVertex.Equals(vertexFour))
            {
                otherVertices = new List<Point> { vertexTwo, vertexThree };
            }

            int result = (int)vertexOne.Distance(auxVertex);
            int height = (int)auxVertex.Distance(auxVertex.Nearest(otherVertices));
            return result * height;
        }

        public override string ToString()
        {
            return ("Rectangle: \n" + name + base.ToString() + "\n Area: " + Area());
        }

    }
}
