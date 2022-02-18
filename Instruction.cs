using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGrid
{
    public class Instruction
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ID { get; private set; }

        public delegate void Execute();

        public Execute Action { get; private set; }

        public Instruction(string name, string description, Execute action, string id)
        {
            Name = name;
            Description = description;

            ID = id;
            Action = action;
        }
    }
}
