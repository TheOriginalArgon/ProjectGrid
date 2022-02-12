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
        public readonly string Name;
        public readonly int Cells;

        public int Width;
        public int Height;

        Cell[] cells;

        public Grid(int width, int height, string name)
        {
            Width = width;
            Height = height;
            Name = name;

            cells = new Cell[width * height];
        }

        public void Draw()
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    cells[w] = new Cell();
                    cells[w].Draw();
                }
                Console.WriteLine();
            }
        }
    }
}
