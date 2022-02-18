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
        static readonly string separator_single = "-----------------------------------------------------------------";
        /// <summary>
        /// Initializes the engine.
        /// </summary>
        public static void Initialize()
        {
            // CREATING A NEW GRID
            // Grid size.
            Console.WriteLine("Please enter the grid's width: ");

            string widthString = Console.ReadLine();
            int width = Convert.ToInt32(widthString);

            Console.WriteLine("Please enter the grid's height: ");

            string heightString = Console.ReadLine();
            int height = Convert.ToInt32(heightString);

            // Grid name.
            Console.WriteLine("Please enter a name for your grid: ");
            string gridName = Console.ReadLine();

            // Here we create the grid itself as an object and load it.
            Grid newGrid = new Grid(width, height, gridName);
            Program.loadedGrid = newGrid;

            // Draw the grid.
            Console.Clear();
            Program.loadedGrid.Draw(true);
        }

        /// <summary>
        /// Sends a message through the console, adding format to make it look cleaner.
        /// </summary>
        /// <param name="message">The message to be displayed.</param>
        /// <param name="debug">Determines if the message has debugging purposes or not. This will only hide/show the "DEBUG" word at the beginning of the string.</param>
        public static void SendMessage(string message, bool debug = false)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(separator_single);
            if (debug)
            {
                Console.WriteLine("DEBUG: " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        public static void ExecuteInstruction(string prompt)
        {
            if (prompt.StartsWith("/"))
            {
                string instruction = prompt.Substring(1);

                foreach (Instruction inst in InstructionManager.instructions)
                {
                    if (instruction == inst.ID)
                    {
                        inst.Action.Invoke();
                        return;
                    }
                }
                SendMessage($"\"{instruction}\" is not a valid instruction, type \"/help\" for a list of instructions.");
            }
            else
            {
                Program.terminate = true;
            }
        }

        private static class InstructionManager
        {
            public static List<Instruction> instructions = new List<Instruction>();

            static InstructionManager()
            {
                instructions.Add(new Instruction(
                    "Test Instruction",
                    "This is the description of this instruction",
                    delegate
                    {
                        SendMessage($"This is the output of this instruction");
                    },
                    "testinstruction"));
            }
        }

    }
}
