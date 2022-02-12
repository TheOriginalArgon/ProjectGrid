using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    /// <summary>
    /// The engine class controls the actions of the program.
    /// </summary>
    public static class Engine
    {
        public static void Initialize()
        {
            Console.WriteLine("Please enter the grid's width: ");

            string widthString = Console.ReadLine();
            int width = Convert.ToInt32(widthString);

            Console.WriteLine("Please enter the grid's height: ");

            string heightString = Console.ReadLine();
            int height = Convert.ToInt32(heightString);

            Console.WriteLine("Please enter a name for your grid: ");
            string gridName = Console.ReadLine();

            Grid newGrid = new Grid(width, height, gridName);
            DrawGrid(newGrid, true);
        }

        /// <summary>
        /// Draws the starting grid.
        /// </summary>
        /// <param name="width">Determines the width of the grid.</param>
        /// <param name="height">Determines the height of the grid.</param>
        public static void DrawGrid(Grid grid, bool showDebugInformation = false)
        {
            grid.DrawCells(grid.GetAllCells());
            Console.WriteLine();

            if (showDebugInformation)
            {
                Console.WriteLine($"Successfully drawn grid {grid.Name} with dimensions {grid.Width} x {grid.Height} and a total cell count of {grid.Cells}.");
            }
        }
    }
}
