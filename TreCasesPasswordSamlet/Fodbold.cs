using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    public class Fodbold
    {
        // To inputs, en int og string
        // hvis holdet scorer et mål "Olé olé olé"                                          - Skal det ske når "mål" tastes ind?
        // Hvis holdet formår at lave mere end 1 men mindre end 10 afleveringer "huh!"
        // Hvis holdet formår at lave mindst 10 afleveringer, gives der high fives og jubles
        // Hvis der er 0 afleveringer "shh"
        // Stringen skal tage imod teksten "mål", det skal være muligt med store og små bogstaver
        public static string FodboldProgram()
        {
            int A; string B;
            Console.Clear();
            Console.SetCursorPosition(5, 1);
            Console.Write("Indtast antal afleveringer: ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Fodbold.AfleveringTjek(A);
            Console.SetCursorPosition(5, 2);
            return (B);

            //Console.Clear();
            //B = Console.ReadLine();
            //B.ToUpper();
            //if (B == "MÅl")
            //{
            //    A = Logic_ClassLibrary.Mål(B);
            //    Console.WriteLine(A);
            //}
        }
        public static string AfleveringTjek(int A)
        {
            string C = "";
            if (A == 0)
            {
                C = "shh";
            }
            if (A == 10)
            {
                C = "High fives og jubel";
            }
            if (A > 1 && A < 10)
            {
                C = "huh!";
            }
            return $"{C}";
        }
        public static int Mål(string B)
        {
            int A = 0;
            switch (B)
            {
                case "A":
                    A++;
                    Console.WriteLine("Scorede 1 mål");
                    Console.WriteLine("Olé olé olé");
                    Console.ReadKey();
                    break;
                case "B":
                    A = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            return (A);
        }
    }
}
