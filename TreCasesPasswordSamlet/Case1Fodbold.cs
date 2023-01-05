using System;

namespace TreCasesPasswordSamlet
{
    public class Case1Fodbold
    {
        public static string AfleveringTjek(int Number)
        {
            string Text = "";
            switch (Number)
            {
                case 0:
                    Text = "Shh";
                    break;
                case 10:
                    Text = "High fives og jubel";
                    break;
            }
            if (Number > 1 && Number < 10)
            {
                Text = "Huh!";
            }
            return $"{Text}";
        }
        public static int Mål(string Text)
        {
            int A = 0;
            switch (Text)
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
