using System;

namespace TreCasesPasswordSamlet
{
    public class Case2Danser
    {
        public string name;
        public int points;
        public static string DanserProgram()
        {
            string name = UI.UIDanserProgramPartner1();
            int points = UI.UIDanserProgramPoints();

            Case2Danser danser1 = new Case2Danser(name, points);
            Console.SetCursorPosition(5, 4);
            Console.Write("{0}, {1}", danser1.name, danser1.points);
            Console.ReadKey();
            Console.Clear();

            name = UI.UIDanserProgramPartner2();
            points = UI.UIDanserProgramPoints();

            Case2Danser danser2 = new Case2Danser(name, points);
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
            string name = Console.ReadLine();
            return (name);
        }
        public Case2Danser(string aName, int aPoints)
        {
            name = aName;
            points = aPoints;
        }
    }
}