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
        private int index = 1;//this is so we can fake number our code
        private Text myText = new Text();
        private string thisString;

        public void GetInput()
        {
            if(index == 1)
            {
                WriteOutANumber();//this'll start us off with a number
            }

            myText.DefineText();
            myText.AddTextToList();
            int i = 0;
            thisString = TextToUse();

            for (; ; )//writes out input until you type in something to make it close
            {
                input = Console.ReadKey(true).KeyChar;//the true in here prevents the key from showing on the console.

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
                    WriteOutANumber();//give us a number in front of our code. Make it look more dev-y
                    GetInput();
                }
                Console.Write(thisString[i]);

                if (Console.CursorTop > prevTop)//delete the user input at end of line
                {
                    WriteOutANumber();
                }
            }
        }

        private string TextToUse()
        {
            return myText.GetRandomString();
        }

        private void WriteOutANumber()//make it so our numbers are a different color
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write(" \n");//after we print, we keep numbering?
            Console.Write(index + "  ");//number our code
            index++;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
