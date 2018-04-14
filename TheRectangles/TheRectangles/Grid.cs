using System.Collections.Generic;

namespace TheRectangles
{
    public class Grid
    {
        private int gridSize;

        private List<Figure> figures;

        //TODO implement the grid with the size passed by the constructor's parameter
        //TODO implement a hashmap structure to store the color and de area to be painted
        //TODO implement a way to verify which the rectangles being overlapped after each rectangle being add to the grid 
        //TODO 

        public Grid()
        {
            figures = new List<Figure>();
        }

        // Calculates the total area of the figures
        public double TotalArea()
        {
            double totalArea = 0;
            figures.ForEach(f => totalArea += f.Area());
            return totalArea;
        }

        // figures to String
        public string FiguresToString()
        {
            string response = "";
            figures.ForEach(f => response += f.name + f.ToString() + "\n");
            return response;
        }

        // Adds a new figure to the figure list
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

    }
}
