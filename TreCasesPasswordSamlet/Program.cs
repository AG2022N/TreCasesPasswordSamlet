using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PasswordInput; bool PasswordValid = false;
            while (PasswordValid == false)
            {
                Console.WriteLine("Input the password");
                PasswordInput = Console.ReadLine();
                if (PasswordChecks.MinimumLength(PasswordInput) && PasswordChecks.UpperAndLower(PasswordInput) && PasswordChecks.IncludesNumbers(PasswordInput) &&
                    PasswordChecks.NoNumbersAtStartOrEnd(PasswordInput) == true && PasswordChecks.DoesNotContainSpaces(PasswordInput) == true)
                {
                    PasswordValid = true;
                    Console.WriteLine("Den indtastede koderd er gyldig, du må fortsætte.");
                }
                else
                {
                    Console.Write("Den indtasted kodeord er ugyldig, prøv igen.");
                }
                Console.ReadKey();
                Console.Clear();
            }

            int userChoice;
            Console.WriteLine("Tast 1 for at køre fodbold programmen");
            Console.WriteLine("Tast 2 for at køre Danse programmen");
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    for (int i = 0; i < 9999; i++)
                    {
                        int A; string B;
                        Console.Clear();
                        Console.SetCursorPosition(5, 1);
                        A = Convert.ToInt32(Console.ReadLine());
                        B = Fodbold.AfleveringTjek(A);
                        Console.SetCursorPosition(5, 2);
                        Console.Write(B);

                        //Console.Clear();
                        //B = Console.ReadLine();
                        //if (B == "MÅl")
                        //{
                        //    A = Logic_ClassLibrary.Mål(B);
                        //    Console.WriteLine(A);
                        //}
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    int Max;
                    Console.WriteLine("Hvor mange par vil du gerne oprette?");
                    Max = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < Max; i++)
                    {
                        Console.Clear();

                        Console.WriteLine("Første Partner");
                        string name = Console.ReadLine(); int points = Convert.ToInt32(Console.ReadLine());
                        Danser danser1 = new Danser(name, points);
                        Console.Write("{0}, {1}", danser1.name, danser1.points);

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Andet partner");
                        name = Console.ReadLine(); points = Convert.ToInt32(Console.ReadLine());
                        Danser danser2 = new Danser(name, points);
                        Console.Write("{0}, {1}", danser2.name, danser2.points);

                        Console.ReadKey();
                        Console.Clear();

                        Console.Write("{0} & {1} {2}", danser1.name, danser2.name, danser1.points + danser2.points);

                        i++;
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
