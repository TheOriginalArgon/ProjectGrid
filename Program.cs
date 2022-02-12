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
            Console.WriteLine("Welcome to the grid project.");
            Console.WriteLine("Created by Argón as a way to play around with C#");
            Console.WriteLine("===============================================");
            Console.WriteLine("Let's create our grid!");
            Engine.Initialize();

            Console.ReadLine();
        }
    }
}
