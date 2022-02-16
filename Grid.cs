using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    /// <summary>
    /// A grid is a collection of cells that is meant to be drawn in a square or rectangular array.
    /// A grid is made of many instances of <see cref="Cell"/>
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// A string representing the name of the grid.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// An integer value that stores the total amount of cells that a grid has.
        /// </summary>
        public int CellCount { get; }

        /// <summary>
        /// An integer value that represents the grid's width, measured in Cells.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// An integer value that represents the grid's height, measured in Cells.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// An array of cells holding each instance of <see cref="Cell"/> that the grid contains.
        /// </summary>
        private Cell[] cells;

        /// <summary>
        /// Returns the <see cref="Cell"/> indexed with the given <paramref name="index"/> value.
        /// </summary>
        /// <param name="index">The integer value of the cell index to get.</param>
        /// <returns>The <see cref="Cell"/> indexed with the value of <paramref name="index"/></returns>
        public Cell GetCell(int index)
        {
            return cells[index];
        }

        /// <summary>
        /// Creates a new grid.
        /// </summary>
        /// <param name="width">The width of the grid measured in cells.</param>
        /// <param name="height">The height of the grid measured in cells.</param>
        /// <param name="name">The name of the grid.</param>
        public Grid(int width, int height, string name)
        {
            // Assign the corresponding starting values to the grid.
            Width = width;
            Height = height;
            Name = name;

            // Assign the corresponding size to the cell array holding all the cells.
            cells = new Cell[width * height];
            CellCount = height * width;

            // Create all the cells that will form this grid.
            for (int i = 0; i < CellCount; i++)
            {
                cells[i] = new Cell(this, i);
            }
        }

        /// <summary>
        /// Draws this grid.
        /// </summary>
        public void Draw(bool showDebugMessages = false)
        {
            for (int i = 0; i < cells.Count(); i++)
            {
                cells[i].Draw();
            }
            if (showDebugMessages)
            {
                Engine.SendMessage($"Successfully drawn grid {Name} with dimensions {Width} x {Height} and a total cell count of {CellCount}", true);
            }
        }
    }
}
