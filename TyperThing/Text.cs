using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TyperThing
{
    class Text
    {
        private List<string> ListOfText = new List<string>();

        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();        

        private string st1;
        private string st2;
        private string st3;
        private string st4;
        private string st5;
        private string st6;
        private string st7;
        private string st8;
        private string st9;
        private string st10;

        public string GetRandomString()
        {
            Random r = new Random();
            int i = r.Next(0, ListOfText.Count);//get a random number
            return ListOfText[i];
        }

        public void DefineText()//assigns value to all predeclared strings
        {
            st1 = "int i = 0;\nint j = 1;\nint s = i + j / 2;\n\nwhile(i < j)\n{\n\treturn NumCheck(i.Value(), j.Value(), false);\n}\n\nConsole.Write(\"Debug char is s\")\n\nbool isUsing()\n{\n\tif(n < maxPeople)\n\t\treturn true;\n\telse return false;\n}";
            st2 = "for(int i = 0; i < chars.Length; i++)\n{\n\tint temp = i;\n\tint j = i + 1;\n\tj = nums[i];\n\n\tif(nums[i] > j)\n\t\tbreak;\n}\n\nconst int numOfUsers = new List<User>().Count;\n\nif(nums.Count > maxNums)\n{\n\treturn false;\n}";
            st3 = "while(isInUse == false)\n{\n\tif(!CheckIfInUse())\n\t{\n\t\tDebug.Log(Console is not in use);\n\n\t\tint tempInt = 0;\n\t\tconsoleNum = tempInt;\n\t\tconsoleNum = ints[tempInt];\n\t\ttempInt = consoleNum;\n\t}\n\n\tvar ConsoleType = GetType().GetValue();\n}";
            st4 = "private enum ConsoleState = {on, off, turning on, turning off, busy, processing};\nprivate ConsoleState myComputerState = ConsoleState.off;\npublic Toggle myToggle = new Toggle();\n\nif(myState == ConsoleState.on)\n{\n\tDebugTryRestart();\n}";
            st5 = "#define resolution = 1920, 1080;\n#define clamp = Math.Abs(resolution);\n\nClass Process\n{\n\tprivate float estimatedStartTime;\n\tprivate float estimatedEndTime;\n\n\tif(processStarted)\n\t{\n\t\tConsole.StartTimer(estimatedStartTime, estimatedEndTime);\n\t}\n}";
            st6 = "public Window w = new Window();\nw.Run(TEXT(\"Console Started\" + w.timeElapsed().toString());\n\ntry\n{\n\tstringFile = w.GetStringFile(filePath);\n\tstringFile.PrintString(stringFile.toCharArray()[index]);\n}\ncatch(NullReferenceException e)\n{\n\tDebug.Log(e.Details.ToString());\n}";
            st7 = "if(Client.pass.Count() < maxChars && Client.pass.CheckChars())\n{\n\tpassPanel.Hide(true);\n\tclientPanel.Show(true);\n\tClient.AskIfSavePass();\n\n\tClient.Window.ConfigureDatabase(clientPanel, false);\n\tclientPanel.AddClientInformation(Client);\n}";
            st8 = "void InputHandler(clientState)\n{\n\tvar input = GetInput(clientState.client);\n\tint maxInput = inputState.numOfInputsAllowed;\n\n\tswitch(clientState)\n\t{\n\t\tcase clientState.default:\n\t\t\tclientState.client.SetInputChange(AllowInput());\n\t\t\tbreak;\n\t\tcase clientState.disabled:\n\t\t\tinput.DisableInput();\n\t\t\tinput.disabled = true;\n\t\t\tbreak;\n\t}\n}";
            st9 = "abstract class Console : Input\n{\n\tprivate List<Console> consoles = new List<Console>();\n\n\tpublic bool isOn;\n\tpublic bool successfulConnection;\n\n\tprivate void Write(string message)\n\t{\n\t\tif(isOn)\n\t\t\tconsoles[index].Printf(messsage).toString());\n\t\telse\n\t\t\tPrintf(failed connection);\n\t}\n}";
            st10 = "int main(void)\n{\n\tprivate Rectangle rect;\n\tprivate Window w = new Window();\n\n\trect.SetWidth(w.Width, w.Height);\n\n\tDebug.Log(\"Window size is: \" +  w.GetSize());\n\n\tif(!rect.CompareTo(w.GetSize.ToRect())\n\t{\n\t\trect.SetSizeToWindow(w, rect));\n\t}\n}";
        }

        public void AddTextToList()
        {
            ListOfText.Add(st1);
            ListOfText.Add(st2);
            ListOfText.Add(st3);
            ListOfText.Add(st4);
            ListOfText.Add(st5);
            ListOfText.Add(st6);
            ListOfText.Add(st7);
            ListOfText.Add(st8);
            ListOfText.Add(st9);
            ListOfText.Add(st10);
        }

        public void PrintMessage()
        {
            Random r = new Random();
            int randomMessage = r.Next(0, 10);

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
                case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\nTask has timed out.\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\nPassword is incorrect. Please enter your 4-digit pin.\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\nInput not recognized.\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\nSelf destruct has been activated. Memory wipe occuring in ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("10");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" minutes. To cancel, enter pin.\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }
    }
}
