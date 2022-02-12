using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Initialize(6, 3);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// The engine class controls the actions of the program.
    /// </summary>
    public static class Engine
    {
        /// <summary>
        /// Initializes the engine setting the dinmensions of the starting grid.
        /// </summary>
        /// <param name="width">Determines the width of the grid.</param>
        /// <param name="height">Determines the height of the grid.</param>
        public static void Initialize(int width, int height)
        {
            Cell baseCell = new Cell(2, '0');

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    baseCell.Draw();
                }
                Console.WriteLine();
            }
        }

    }

    public class Cell
    {
        private int chars;

        private char digit;

        public Cell(int c, char d)
        {
            chars = c;
            digit = d;
        }

        public void Draw()
        {
            for (int i = 0; i < chars; i++)
            {
                Console.Write(digit);
            }
            Console.Write(" ");
        }
    }

}
