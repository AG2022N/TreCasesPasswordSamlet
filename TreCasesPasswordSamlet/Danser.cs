using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{

    public class Danser
    {
        public string name;
        public int points;
        public static string DanserProgram()
        {
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Første Partner");
            string name = DanserNavn();

            Console.SetCursorPosition(5, 3);
            Console.Write("Punkt: ");
            int points = Convert.ToInt32(Console.ReadLine());

            Danser danser1 = new Danser(name, points);
            Console.SetCursorPosition(5, 4);
            Console.Write("{0}, {1}", danser1.name, danser1.points);
            Console.ReadKey();
            Console.Clear();


            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Andet partner");
            name = DanserNavn();

            Console.SetCursorPosition(5, 3);
            Console.Write("Punkt: ");
            points = Convert.ToInt32(Console.ReadLine());

            Danser danser2 = new Danser(name, points);
            Console.SetCursorPosition(5, 4);
            Console.Write("{0}, {1}", danser2.name, danser2.points);
            Console.ReadKey();
            Console.Clear();

            int danserParPoints = danser1.points + danser2.points;
            string DanserOut = (danser1.name + " & " + danser2.name + " " + danserParPoints);
            return (DanserOut);
        }
        public static string DanserNavn()
        {
            Console.SetCursorPosition(5, 2);
            Console.Write("Navn: ");
            string name = Console.ReadLine();
            return (name);
        }
        public Danser(string aName, int aPoints)
        {
            name = aName;
            points = aPoints;
        }
    }
}