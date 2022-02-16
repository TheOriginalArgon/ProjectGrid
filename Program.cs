using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    public class Program
    {
        public static bool terminate = false;
        public static Grid loadedGrid;
        static void Main(string[] args)
        {
            // Starting texts to let the user know what they will be doing.
            Console.WriteLine("Welcome to the grid project.");
            Console.WriteLine("Created by Argón as a way to play around with C#");
            Console.WriteLine("===============================================");
            Console.WriteLine("Let's create our grid!");
            Engine.Initialize();

            // Take any following input as an instruction.
            while (!terminate)
            {
                Engine.ExecuteInstruction(Console.ReadLine());
            }
        }
    }
}
