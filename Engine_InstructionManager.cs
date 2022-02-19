using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    public static partial class Engine
    {
        /// <summary>
        /// A class responsible of managing the instructions.
        /// </summary>
        private static class InstructionManager
        {
            /// <summary>
            /// A list containing all the available intructions.
            /// </summary>
            public static List<Instruction> instructions = new List<Instruction>();

            /// <summary>
            /// The static constructor defines the instructions before program starts.
            /// </summary>
            static InstructionManager()
            {
                instructions.Add(new Instruction(
                    "Help",
                    "Shows a list of all instructions and their definitions",
                    false,
                    delegate
                    {
                        SendMessage($"Showing all {instructions.Count} available instructions.\n\n");
                        foreach (Instruction inst in instructions)
                        {
                            Console.WriteLine(separator_single_short);
                            Console.Write($"/{inst.ID}");
                            if (inst.HasArgs)
                            {
                                for (int i = 0; i < inst.ArgCount; i++)
                                {
                                    Console.Write($" [{inst.ArgDefinitions[i]}]");
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                            Console.WriteLine($"\t{inst.Name}");
                            Console.WriteLine($"\tDescription: {inst.Description}");
                            Console.WriteLine();
                        }
                    },
                    "help"));

                // Updates the value of a cell and redraws the grid.
                instructions.Add(new Instruction(
                    "Update Cell",
                    "Updates a given cell of the loaded grid with a new value. Redraws the grid after executing.",
                    true,
                    delegate (object[] args)
                    {
                        if (Program.loadedGrid != null)
                        {
                            Cell cellToUpdate = Program.loadedGrid.GetCell(Convert.ToInt32(args[0]));

                            try
                            {
                                cellToUpdate.SetValue(Convert.ToChar(args[1]));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Cannot execute instruction: \"{args[1]}\" is not a valid value, it must be a single character.");
                                return;
                            }
                            Console.Clear();

                            Program.loadedGrid.Draw();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Cannot execute instruction: No grid is currently loaded.");
                        }
                    },
                    "updatecell",
                    2,
                    new string[] { "cell index", "new value" }));

                instructions.Add(new Instruction(
                    "Create Grid",
                    "Creates a new grid.",
                    true,
                    delegate (object[] args)
                    {
                        Grid newGrid = new Grid(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), args[2].ToString());

                        Program.loadedGrid = newGrid;

                        Console.Clear();
                        Program.loadedGrid.Draw();
                        Console.WriteLine();
                    },
                    "creategrid",
                    3,
                    new string[] { "width", "height", "name" }));
            }
        }
    }
}
