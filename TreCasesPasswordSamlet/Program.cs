using System;
using System.IO;
using System.Text;

namespace TreCasesPasswordSamlet
{
    internal class Program
    {
        public static string PasswordOutput = @"C:\Users\allgaw\Documents\C#\TreCases\TreCasesPasswordSamlet\TreCasesPasswordSamlet\Passwords.txt";
        public static string[] PasswordPath = File.ReadAllLines(@"C:\Users\allgaw\Documents\C#\TreCases\TreCasesPasswordSamlet\TreCasesPasswordSamlet\Passwords.txt");
        static void Main()
        {
            bool PasswordValid = false;
            int UserChoice = UI.Menu1();
            switch (UserChoice)
            {
                case 1:
                    while (PasswordValid == false)
                    {
                        PasswordValid = PasswordSearch();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 2:
                    while (PasswordValid == false)
                    {
                        string UsernameInput = UsernameCreate();
                        PasswordValid = PasswordCreate(UsernameInput);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }

            UserChoice = UI.Menu2();
            int Max = UI.Menu3();
            switch (UserChoice)
            {
                case 1:
                    for (int i = 0; i < Max; i++)
                    {
                        string B = FodboldProgram();
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine(B);
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    for (int i = 0; i < Max; i++)
                    {
                        string danserPar = Case2Danser.DanserProgram();
                        Console.SetCursorPosition(5, 2);
                        Console.Write(danserPar);
                        Console.ReadKey();
                    }
                    break;
            }
        }

        public static string UsernameCreate()
        {
            string Text = UI.UsernameCreatePromptText();
            return (Text);
        }
        public static bool PasswordCreate(string Text)
        {
            string PasswordInput = UI.PasswordPromptText();
            if (Case3Password.MinimumLength(PasswordInput) && Case3Password.UpperAndLower(PasswordInput) && Case3Password.IncludesNumbers(PasswordInput) &&
                Case3Password.NoNumbersAtStartOrEnd(PasswordInput) && Case3Password.DoesNotContainSpaces(PasswordInput))
            {
                PasswordWriteToFile(Text + ", " + PasswordInput);
                Console.WriteLine(UI.PasswordCreateTextSuccess());
                return (true);
            }
            else
            {
                Console.WriteLine(UI.PasswordCreateTextFail());
                return (false);
            }
        }
        public static string PasswordWriteToFile(string Text)
        {
            StreamWriter sw = new StreamWriter(PasswordOutput, true, Encoding.ASCII);
            sw.WriteLine(Text);
            sw.Close();
            return (UI.PasswordWriteToFileSuccess());
        }
        public static bool PasswordSearch()
        {
            string PasswordInput = UI.PasswordPromptText();
            foreach (string line in PasswordPath)
            {
                if (line.Contains(PasswordInput.ToString()))
                {
                    Console.WriteLine(UI.PasswordSearchSuccessText());
                    return (true);
                }
            }
            Console.WriteLine(UI.PasswordSearchFailText());
            return (false);
        }
        public static string FodboldProgram()
        {
            int A = UI.FodboldProgramText();
            string B = Case1Fodbold.AfleveringTjek(A);
            return (B);
        }
    }
}
