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
                            Console.Write(B);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Max; i++)
                        {
                            Console.Clear();
                            string danserPar = Case2Danser.DanserProgram();
                            Console.SetCursorPosition(5, 1);
                            Console.Write(danserPar);
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        //  Metoder
        //    ||
        //   _||_
        //   \  /
        //    \/

        //Som det er lige nu, dette vil søge om brugernavn findes i password.txt.
        //Lige nu er der ingen sammenhæng mellem brugernavn og kodeord, man kan bruge alle "ord" der findes i filen som både brugernavn og kodeord.
        //For eksempel, Admin og Admin.
        //Den tjekker blot om den indtastede streng findes i tekst filem.
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
                    Console.Write(UI.PasswordSearchSuccessText());
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
