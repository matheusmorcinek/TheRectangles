﻿using System;
using System.Collections.Generic;

namespace TheRectangles
{
    public class Point
    {
        public int x { get; }
        public int y { get; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return ("(X" + x + " - Y" + y + ")");
        }

        public double Distance(Point anotherPoint)
        {
            return Math.Sqrt(Math.Pow(x - anotherPoint.x, 2) +
                             Math.Pow(y - anotherPoint.y, 2));
        }

        /**
         * Returns the nearest point of the array in the parameter or null if array is empty.
         */
        public Point Nearest(List<Point> otherPoints)
        {
            Point nearestPoint = null;
            double minDistance = int.MaxValue;
            double currentDistance;

            for (int i = 0; i < otherPoints.Count; i++)
            {
                currentDistance = this.Distance(otherPoints[i]);
                if (currentDistance <= minDistance)
                {
                    minDistance = currentDistance;
                    nearestPoint = otherPoints[i];
                }
            }
            return nearestPoint;
        }

    }
}
