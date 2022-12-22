using System;
using System.IO;
using System.Runtime.CompilerServices;
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
                        if (UsernameSearch() == true)
                        {
                            PasswordValid = PasswordSearch();
                            Console.ReadKey();
                            Console.Clear();
                        }
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
            
            if (PasswordValid == true)
            {
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
                            Console.Clear();
                        }
                        break;
                }
            }
        }

        //It will look for the username to see whether it exists there or not, but it does not look for a correlation with a password, say we John who
        //has his password set to Test1 and we have James who has his set to Test2 - if the user trying to log-in types in one of their names and one of these
        //passwords, the user will be able to log-in to both users. For example he might type in John and then Test2, or James and Test1,
        //currently this will let him through.
        public static bool UsernameSearch()
        {
            foreach (string line in PasswordPath)
            {
                string UsernameInput = UI.UsernamePromptText();
                if (line.Contains(UsernameInput.ToString()))
                {
                    return (true);
                }
            }
            Console.WriteLine(UI.PasswordSearchFailText());
            return (false);
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
        public static string UsernameCreate()
        {
            string Text = UI.UsernamePromptText();
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
        public static string FodboldProgram()
        {
            int A = UI.FodboldProgramText();
            string B = Case1Fodbold.AfleveringTjek(A);
            return (B);
        }
    }
}
