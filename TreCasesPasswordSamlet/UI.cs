using System;

namespace TreCasesPasswordSamlet
{
    public class UI
    {
        public static int Number; public static string Text;
        public static int Menu1()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Tast 1 for at logge ind");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Tast 2 for at skabe en bruger");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Tast 3 for at lukke programmen");
            Console.SetCursorPosition(5, 4);
            Number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (Number);
        }
        public static string UsernamePromptText()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 1);
            Console.Write("Tast ind brugernavn: ");
            Text = Console.ReadLine();
            return (Text);
        }
        public static string PasswordPromptText()
        {
            Console.SetCursorPosition(5, 2);
            Console.Write("Indtast kodeorden: ");
            Text = Console.ReadLine();
            return (Text);
        }
        public static string PasswordCreateTextSuccess()
        {
            Console.SetCursorPosition(5, 3);
            return ("Den indtastede kodeord er gyldig, du må fortsætte.");
        }
        public static string PasswordCreateTextFail()
        {
            Console.SetCursorPosition(5, 3);
            return ("Den indtastede kodeord er ugyldig, prøv igen.");
        }
        public static string PasswordWriteToFileSuccess()
        {
            Text = ("Password Gemt");
            return (Text);
        }
        public static string PasswordSearchSuccessText()
        {
            Console.SetCursorPosition(5, 3);
            return ("Den indtastede kodeord er Korrekt, du må fortsætte.");
        }
        public static string PasswordSearchFailText()
        {
            Console.SetCursorPosition(5, 3);
            return ("Den indtastede brugernavn eller password er forkert angivet");
        }

        public static int Menu2()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Tast 1 for at køre fodbold programmen");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Tast 2 for at køre danse programmen");
            Console.SetCursorPosition(5, 3);
            Number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (Number);
        }
        public static int Menu3()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Hvor mange gange vil du gerne køre programmen?");
            Console.SetCursorPosition(5, 2);
            Number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return (Number);
        }

        public static int FodboldProgramText()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 1);
            Console.Write("Indtast antal afleveringer: ");
            Number = Convert.ToInt32(Console.ReadLine());
            return (Number);
        }

        public static string UIDanserProgramPartner1()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Første Partner");
            Console.SetCursorPosition(5, 2);
            Console.Write("Navn: ");
            Text = Case2Danser.DanserNavn();
            return (Text);
        }
        public static string UIDanserProgramPartner2()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Andet partner");
            Console.SetCursorPosition(5, 2);
            Console.Write("Navn: ");
            Text = Case2Danser.DanserNavn();
            return (Text);
        }
        public static int UIDanserProgramPoints()
        {
            Console.SetCursorPosition(5, 3);
            Console.Write("Punkt: ");
            Number = Convert.ToInt32(Console.ReadLine());
            return (Number);
        }
    }
}