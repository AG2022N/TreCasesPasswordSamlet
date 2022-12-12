using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreCasesPasswordSamlet
{
    internal class Program
    {
        static void Main()
        {
            bool PasswordValid = false;
            while (PasswordValid == false)
            {
                PasswordValid = PasswordChecks.PasswordCreate();
                Console.ReadKey();
                Console.Clear();
            }
            // temp
            //while (PasswordValid == false)
            //{
            //    PasswordValid = PasswordChecks.PasswordCheck();
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            int userChoice;
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Tast 1 for at køre fodbold programmen");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Tast 2 for at køre danse programmen");
            Console.SetCursorPosition(5, 3);
            userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    for (int i = 0; i < 99; i++)
                    {
                        string B = Fodbold.FodboldProgram();
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine(B);
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    int Max;
                    Console.SetCursorPosition(5, 1);
                    Console.WriteLine("Hvor mange par vil du gerne oprette?");
                    Max = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < Max; i++)
                    {
                        Console.Clear();
                        string danserPar = Danser.DanserProgram();
                        Console.SetCursorPosition(5, 2);
                        Console.Write(danserPar);
                        i++;
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
