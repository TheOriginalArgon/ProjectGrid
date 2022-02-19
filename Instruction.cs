using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    public class Instruction
    {
        /// <summary>
        /// The name of the instruction.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The description of what this instruction does when executed.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// The internal unique ID. Generally the name of the instruction without spaces and all lowercase.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// A bool that determines if an instruction takes arguments or nor.
        /// </summary>
        public bool HasArgs { get; private set; }

        /// <summary>
        /// An int that returns the amount of arguments an instruction takes.
        /// </summary>
        public int ArgCount { get; private set; }

        /// <summary>
        /// An array containing the values for each argument. Assigned by the user when executing an instruction.
        /// </summary>
        public object[] Args { get; private set; }

        /// <summary>
        /// An array containing the names of this instruction's arguments.
        /// </summary>
        public string[] ArgDefinitions { get; private set; }

        /// <summary>
        /// A delegate void which holds the method to be executed by the instruction. Defined by instantiating an instruction.
        /// </summary>
        /// <param name="args">An array of <see cref="object"/> holding this instruction's arguments.</param>
        public delegate void Execute(params object[] args);

        /// <summary>
        /// The instance of the delegate void <see cref="Execute"/> that this instruction has. Each instruction should have just one.
        /// </summary>
        public Execute Action { get; private set; }

        /// <summary>
        /// Creates a new instruction.
        /// </summary>
        /// <param name="name">The name of the instruction.</param>
        /// <param name="description">The description of what this instruction does.</param>
        /// <param name="hasArgs">Defines whether this instruction takes arguments or not.</param>
        /// <param name="action">a delegate method which will be run when this instruction is executed. Can be defined as a lambda expression.</param>
        /// <param name="id">The unique ID of this instruction. Generally the name without spaces and all lowercase.</param>
        /// <param name="argAmount">The amount of arguments this instruction takes. This number is fixed.</param>
        /// <param name="argDefs">An array holding the names of each argument.</param>
        public Instruction(string name, string description, bool hasArgs, Execute action, string id, int argAmount = 0, string[]argDefs = null)
        {
            Name = name;
            Description = description;
            HasArgs = hasArgs;

            ID = id;
            Action = action;

            ArgCount = argAmount;
            if (HasArgs)
            {
                Args = new object[ArgCount];
            }
            else
            {
                Args = null;
            }
            ArgDefinitions = argDefs;
        }
    }
}
