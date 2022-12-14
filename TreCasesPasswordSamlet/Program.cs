﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    internal class Program
    {
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

                if (UserChoice == 3)
                {
                    break;
                }

                switch (UserChoice)
                {
                    case 1:
                        while (PasswordValid == false)
                        {
                            PasswordValid = PasswordChecks.PasswordCheck();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        while (PasswordValid == false)
                        {
                            PasswordValid = PasswordChecks.PasswordCreate();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }
            if (PasswordValid == true)
            {
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
                            string B = Fodbold.FodboldProgram();
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
                        }
                        break;
                }
            }
        }
    }
}
