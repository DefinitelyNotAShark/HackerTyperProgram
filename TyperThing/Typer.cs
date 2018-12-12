using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperThing
{
    class Typer : Text
    {
        private int input;
        private Text myText = new Text();
        private string thisString;
        public void GetInput()
        {
            myText.DefineText();
            myText.AddTextToList();
            int i = 0;
            thisString = TextToUse();

            for (; ; )//writes out input until you type in e
            {
                input = Console.ReadKey().KeyChar;
                int prevTop = Console.CursorTop;
                int prevLeft = Console.CursorLeft;

                if (i < thisString.Length - 1)
                {
                    i++;
                }

                else
                {
                    EraseLastChar();
                    PrintMessage();
                    GetInput();
                } 
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(thisString[i]);

                if (Console.CursorTop > prevTop)//delete the user input at end of line
                {
                    Console.SetCursorPosition(prevLeft - 1, Console.CursorTop - 1);
                    Console.Write(" \n");
                }
            }
        }

        private string TextToUse()
        {
            return myText.GetRandomString();
        }
    }
}
