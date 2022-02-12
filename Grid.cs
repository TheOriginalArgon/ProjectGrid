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
        public string Name { get; }
        public int Cells { get; }

        public int Width { get; }
        public int Height { get; }

        private Cell[] cells;

        public Cell[] GetAllCells()
        {
            return cells;
        }

        public Grid(int width, int height, string name)
        {
            Width = width;
            Height = height;
            Name = name;

            cells = new Cell[width * height];
            Cells = height * width;

            for (int i = 0; i < Cells; i++)
            {
                cells[i] = new Cell(this);
            }
        }

        public void DrawCells(Cell[] cellsToDraw)
        {
            for (int i = 0; i < cellsToDraw.Length; i++)
            {
                cellsToDraw[i].Initialize(i);
                cellsToDraw[i].Draw();
            }
        }
    }
}
