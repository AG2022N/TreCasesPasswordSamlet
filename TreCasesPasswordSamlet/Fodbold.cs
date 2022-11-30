using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    public class Fodbold
    {
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
