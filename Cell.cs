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
        public int X { get; set; }
        public int Y { get; set; }

        public Grid Grid { get; }

        public Cell(Grid myGrid)
        {
            Grid = myGrid;
        }

        public void Initialize(int positionIndex)
        {
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

        public void Draw()
        {
            if (X == 0 && Y != 0)
            {
                Console.WriteLine();
            }
            Console.Write("[]");
        }
    }
}
