using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperThing
{
    class Typer : Text
    {
        private ConsoleKey inputKey;

        private int index = 1;//this is so we can fake number our code
        private Text myText = new Text();
        private string thisString;
        private int speed = 1;//increases each time you press the speed button decreases everytime you press the slow button. Can't be less than 1. Starts out as 1

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
                inputKey = Console.ReadKey(true).Key;//the true in here prevents the key from showing on the console.
           
                if(inputKey == ConsoleKey.Enter && speed < 10)//speed can't be more than 10
                {
                    speed++;
                }
                else if(inputKey == ConsoleKey.Backspace && speed > 1)//speed can't be less than 1
                {
                    speed--;
                }


                for (int a = 0; a < speed; a++)//prints out as much of our message as speed allows us to do
                {
                    int prevTop = Console.CursorTop;
                    int prevLeft = Console.CursorLeft;

                    if (i < thisString.Length)
                    {
                        Console.Write(thisString[i]);
                        i++;
                    }

                    else
                    {
                        PrintMessage();
                        WriteOutANumber();//give us a number in front of our code. Make it look more dev-y
                        GetInput();
                        break;
                    }

                    if (Console.CursorTop > prevTop)//delete the user input at end of line
                    {
                        WriteOutANumber();
                    }
                }
            }
        }

        private string TextToUse()
        {
            return myText.GetRandomString();
        }

        private void WriteOutANumber()//make it so our numbers are a different color
        {
            if(index > 1000)//reset index if too big
            {
                index = 0;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write(" \n");//after we print, we keep numbering?
            Console.Write(index + "  ");//number our code
            index++;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
