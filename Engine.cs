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
    public static partial class Engine
    {
        static readonly string separator_single = "-----------------------------------------------------------------";
        static readonly string separator_single_short = "------------------------";
        /// <summary>
        /// Initializes the engine.
        /// </summary>
        public static void Initialize()
        {

        }

        /// <summary>
        /// Sends a message through the console, adding format to make it look cleaner.
        /// </summary>
        /// <param name="message">The message to be displayed.</param>
        /// <param name="debug">Determines if the message has debugging purposes or not. This will only hide/show the "DEBUG" word at the beginning of the string.</param>
        public static void SendMessage(string message, bool debug = false)
        {
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
        /// <summary>
        /// Executes an isnstruction based on user input.
        /// </summary>
        /// <param name="prompt">The user input represented as a string.</param>
        public static void ExecuteInstruction(string prompt)
        {
            // If the input starts with a slash take it as an instruction.
            if (prompt.StartsWith("/"))
            {
                string instruction = prompt.Substring(1);

                foreach (Instruction inst in InstructionManager.instructions)
                {
                    if (instruction == inst.ID)
                    {
                        if (inst.ArgCount > 0)
                        {
                            for (int i = 0; i < inst.ArgCount; i++)
                            {
                                Console.WriteLine($"Define argument {inst.ArgDefinitions[i]}: ");
                                inst.Args[i] = Console.ReadLine();
                            }
                        }
                        inst.Action.Invoke(inst.Args);
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
    }
}
