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
        public static string AfleveringTjek(int A, string B)
        {
            if (A == 0)
            {
                B = "shh";
            }
            if (A == 10)
            {
                B = "High fives og jubel";
            }
            if (A > 1 && A < 10)
            {
                B = "huh!";
            }
            return $"{B}";
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
