using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    internal class Program
    {
        public static string PasswordOutput = @"C:\Users\allgaw\Documents\C#\TreCases\TreCasesPasswordSamlet\TreCasesPasswordSamlet\Passwords.txt";
        public static string[] PasswordPath = File.ReadAllLines(@"C:\Users\allgaw\Documents\C#\TreCases\TreCasesPasswordSamlet\TreCasesPasswordSamlet\Passwords.txt");
        static void Main()
        {
            bool PasswordValid = false;
            int UserChoice;
            while (PasswordValid == false)
            {
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Tast 1 for at logge ind");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Tast 2 for at skabe en password");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("Tast 3 for at lukke programmen");
                Console.SetCursorPosition(5, 4);
                UserChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (UserChoice)
                {
                    case 1:
                        while (PasswordValid == false)
                        {
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
            }
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Tast 1 for at køre fodbold programmen");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Tast 2 for at køre danse programmen");
                Console.SetCursorPosition(5, 3);
                UserChoice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Hvor mange gange vil du gerne køre programmen?");
                Console.SetCursorPosition(5, 2);
                int Max = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

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
                            string danserPar = Danser.DanserProgram();
                            Console.SetCursorPosition(5, 2);
                            Console.Write(danserPar);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }

            bool PasswordCreate()
            {
                string PasswordInput;
                Console.SetCursorPosition(5, 1);
                Console.Write("Indtast kodeorden: ");
                PasswordInput = Console.ReadLine();
                if (PasswordChecks.MinimumLength(PasswordInput) && PasswordChecks.UpperAndLower(PasswordInput) && PasswordChecks.IncludesNumbers(PasswordInput) &&
                    PasswordChecks.NoNumbersAtStartOrEnd(PasswordInput) == true && PasswordChecks.DoesNotContainSpaces(PasswordInput) == true)
                {
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("Den indtastede kodeord er gyldig, du må fortsætte.");
                    StreamWriter sw = new StreamWriter(PasswordOutput, true, Encoding.ASCII);
                    sw.WriteLine(PasswordInput);
                    sw.Close();
                    return (true);
                }
                else
                {
                    Console.SetCursorPosition(5, 2);
                    Console.Write("Den indtastede kodeord er ugyldig fordi den opfylder ikke alle kravene, prøv igen.");
                    return (false);
                }
            }

            bool PasswordCheck()
            {
                string PasswordInput;
                Console.SetCursorPosition(5, 1);
                Console.Write("Indtast kodeorden: ");
                PasswordInput = Console.ReadLine();
                foreach (string line in PasswordPath)
                {
                    if (line.Contains(PasswordInput.ToString()))
                    {
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine("Den indtastede kodeord er gyldig, du må fortsætte.");
                        return (true);
                    }
                }
                Console.SetCursorPosition(5, 2);
                Console.Write("Den indtastede kodeord er ugyldig, prøv igen.");
                return (false);
            }

            string FodboldProgram()
            {
                Console.Clear();
                int A; string B ="";
                Console.SetCursorPosition(5, 1);
                Console.Write("Indtast antal afleveringer: ");
                A = Convert.ToInt32(Console.ReadLine());
                B = Fodbold.AfleveringTjek(A, B);
                return (B);
            }
        }
    }
}
