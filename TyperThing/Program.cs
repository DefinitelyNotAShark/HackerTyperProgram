using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Type_Like_A_Hacker";
            Console.ForegroundColor = ConsoleColor.Green;
            Typer typer = new Typer();
            typer.GetInput();
        }
    }
}
