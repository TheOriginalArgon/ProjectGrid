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

        public static List<Cell> cells = new List<Cell>();

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
            DrawGrid(newGrid);
        }

        /// <summary>
        /// Draws the starting grid.
        /// </summary>
        /// <param name="width">Determines the width of the grid.</param>
        /// <param name="height">Determines the height of the grid.</param>
        public static void DrawGrid(Grid grid)
        {
            //Cell baseCell = new Cell(2, '0');

            //for (int j = 0; j < height; j++)
            //{
            //    for (int i = 0; i < width; i++)
            //    {
            //        baseCell.Draw();
            //    }
            //    Console.WriteLine();
            //}

            grid.Draw();

        }
    }
}
