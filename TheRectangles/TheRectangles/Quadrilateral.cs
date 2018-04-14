using System.Collections.Generic;

namespace TheRectangles
{
    public abstract class Quadrilateral : Figure
    {
        public Point vertexOne { get; set; }
        public Point vertexTwo { get; set; }
        protected Point vertexThree { get; set; }
        protected Point vertexFour { get; set; }

        public Quadrilateral(string name, string color, Point vertexOne, Point vertexTwo) : base(name, color)
        {
            this.vertexOne = vertexOne;
            this.vertexTwo = vertexTwo;
            SetRemainingVertexes(vertexOne, vertexTwo);
        }

        private void SetRemainingVertexes(Point vertOne, Point vertTwo)
        {
            vertexThree = new Point(vertexOne.x, vertexTwo.y);
            vertexFour = new Point(vertexTwo.x, vertexOne.y);
        }

        public bool IsRegular()
        {
            return CheckRectangle(vertexOne, vertexTwo, vertexThree, vertexFour);
        }

        //TODO finish the validation below
        /**
         * Indicates if the quadrilateral is a rectangle or square by
         * comparing sizes and diagonals.
         *
         */
        private bool CheckRectangle(Point vertexOne, Point vertexTwo, Point vertexThree, Point vertexFour)
        {
            Point auxVertex = vertexOne.Nearest(new List<Point>() { vertexTwo, vertexThree, vertexFour });
            if (auxVertex.Equals(vertexTwo))
            {
                return vertexOne.Distance(vertexThree) == vertexTwo.Distance(vertexFour)
                    && vertexOne.Distance(vertexFour) == vertexTwo.Distance(vertexThree);
            }
            else if (auxVertex.Equals(vertexThree))
            {
                return vertexOne.Distance(vertexTwo) == vertexThree.Distance(vertexFour)
                    && vertexOne.Distance(vertexFour) == vertexThree.Distance(vertexTwo);
            }
            else if (auxVertex.Equals(vertexFour))
            {
                return vertexOne.Distance(vertexTwo) == vertexFour.Distance(vertexThree)
                    && vertexOne.Distance(vertexThree) == vertexFour.Distance(vertexTwo);
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "\n[ (" + vertexThree.x + "," + vertexThree.y + "),(" + vertexTwo.x + "," + vertexTwo.y + "),\n" +
                     "  (" + vertexOne.x + "," + vertexOne.y + "),(" + vertexFour.x + "," + vertexFour.y + ") ]";
        }
    }
}
