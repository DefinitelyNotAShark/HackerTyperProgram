using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperThing
{
    class Text
    {
        private List<string> ListOfText = new List<string>();
        private int maxNum = 5; //maximum number of strings to include.

        private string st1;
        private string st2;
        private string st3;
        private string st4;
        private string st5;

        public string GetRandomString()
        {
            Random r = new Random();
            int i = r.Next(0, maxNum);//get a random number
                       
            return ListOfText[i];//return the string at the index of the random list
        }

        public void DefineText()//assigns value to all predeclared strings
        {
            st1 = "iint i = 0;\nint j = 1;\nint s = i + j / 2;\nwhile(i < j)\n{\nreturn NumCheck(i.Value(), j.Value(), false);\n}\nConsole.Write(\"Debug char is s\")\nbool isUsing()\n{\nif(n < maxPeople)\nreturn true;\nelse return false;\n}";
            st2 = "ffor(int i = 0; i < chars.Length; i++)\n{\nint temp = i;\nint j = i + 1;\nj = nums[i];\nif(nums[i] > j)\n{\nbreak;\n}\nconst int numOfUsers = new List<User>().Count;\nif(nums.Count > maxNums)\n{\nreturn false;\n}";
            st3 = "wwhile(isInUse == false)\n{\nif(!CheckIfInUse())\n{\nDebug.Log(Console is not in use);\n\nint tempInt = 0;\nconsoleNum = tempInt;\nconsoleNum = ints[tempInt];\ntempInt = consoleNum;\n}\n\nvar ConsoleType = GetType().GetValue();\n};";
            st4 = "pprivate enum ConsoleState = {on, off, turning on, turning off, busy, processing};\nprivate ConsoleState myComputerState = ConsoleState.off;\npublic Toggle myToggle = new Toggle();\n\nif(myState == ConsoleState.on)\n{\nDebugTryRestart();\n}";
            st5 = "##define resolution = 1920, 1080;\n#define clamp = Math.Abs(resolution);\n\nClass Process\n{\nprivate float estimatedStartTime;\nprivate float estimatedEndTime;\n\nif(processStarted)\n{\nConsole.StartTimer(estimatedStartTime, estimatedEndTime);\n}\n}";
        }

        public void AddTextToList()
        {
            ListOfText.Add(st1);
            ListOfText.Add(st2);
            ListOfText.Add(st3);
            ListOfText.Add(st4);
            ListOfText.Add(st5);
        }

        public void EraseLastChar()
        {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);//the end of the string
            Console.Write(" ");
        }

        public void PrintMessage()
        {
            Random r = new Random();
            int randomMessage = r.Next(0, 6);

            switch (randomMessage)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nERROR: Please Input Password.\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nAccess Denied\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n\nAccess Granted\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nERROR: Path Not Found\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nException 301: Path is Undefined\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\nWARNING: Attempt failed. Attempts remaining: 1\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

            }
        }
    }
}
