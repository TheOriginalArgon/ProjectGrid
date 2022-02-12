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
        public void Draw()
        {
            Console.Write("[]");
        }
    }
}
