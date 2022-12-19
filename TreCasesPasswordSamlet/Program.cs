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
                        //string Username = AccountCreate();
                        PasswordValid = PasswordCheck();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;

                case 2:
                    while (PasswordValid == false)
                    {
                        PasswordValid = PasswordCreate();
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

        public static string AccountCreate()
        {
            Console.Write("Tast ind brugernavn: ");
            string Text = Console.ReadLine();
            return (Text);
        }

        public static bool PasswordCreate()
        {
            string PasswordInput = UI.PasswordCheckTextPrompt();
            if (Case3Password.MinimumLength(PasswordInput) && Case3Password.UpperAndLower(PasswordInput) && Case3Password.IncludesNumbers(PasswordInput) &&
                Case3Password.NoNumbersAtStartOrEnd(PasswordInput) && Case3Password.DoesNotContainSpaces(PasswordInput))
            {
                Console.WriteLine(UI.PasswordCreateTextSuccess());
                StreamWriter sw = new StreamWriter(PasswordOutput, true, Encoding.ASCII);
                sw.WriteLine(PasswordInput);
                sw.Close();
                return (true);
            }
            else
            {
                Console.WriteLine(UI.PasswordCreateTextFail());
                return (false);
            }
        }
        public static bool PasswordCheck()
        {
            string PasswordInput = UI.PasswordCheckTextPrompt();
            foreach (string line in PasswordPath)
            {
                if (line.Contains(PasswordInput.ToString()))
                {
                    Console.WriteLine(UI.PasswordCheckTextSuccess());
                    return (true);
                }
            }
            Console.WriteLine(UI.PasswordCheckTextFail());
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
