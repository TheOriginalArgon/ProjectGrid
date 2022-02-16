using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    /// <summary>
    /// A cell is a single fragment of the grid. The grid is made by an amount of cells arranged in a rectangular or square shape.
    /// Each cell is made by a fixed amount of characters.
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// The char calue shown by the cell.
        /// </summary>
        public char Value { get; private set; } = ' ';

        /// <summary>
        /// An integer value representing the x-axis position of this cell within the grid.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// An integer value representing the y-axis position of this cell within the grid.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// An integer value holding this cell's unique position index within the grid.
        /// </summary>
        public int PositionIndex { get; private set; }

        /// <summary>
        /// The grid this cell belongs to.
        /// </summary>
        public Grid Grid { get; }

        /// <summary>
        /// Creates a new empty cell.
        /// </summary>
        /// <param name="myGrid">Assigns this cell to a given grid.</param>
        /// <param name="positionIndex">The unique position idex value. This value is used to determine the <see cref="X"/> and <see cref="Y"/> position of this cell upon creation and assignation to a grid.</param>
        public Cell(Grid myGrid, int positionIndex)
        {
            // Assign this cell to a grid.
            Grid = myGrid;

            // Assign the position index and the default char value.
            PositionIndex = positionIndex;
            Value = '0';

            // Assign X and Y position based on the position idex.
            if (positionIndex < Grid.Width)
            {
                Y = 0;
                X = positionIndex;
            }
            if (positionIndex >= Grid.Width)
            {
                Y = Convert.ToInt32(Math.Floor(positionIndex / (decimal)Grid.Width));
                X = positionIndex - (Grid.Width * Y);
            }
        }

        /// <summary>
        /// Draws this cell as part of a <see cref="ProjectGrid.Grid"/>.
        /// </summary>
        public void Draw()
        {
            if (X == 0 && Y != 0)
            {
                Console.WriteLine();
            }
            Console.Write($"[{Value}]");
        }
    }
}
