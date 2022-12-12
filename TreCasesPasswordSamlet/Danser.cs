using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{

    public class Danser
    {
        public static string DanserProgram()
        {
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

            int danserParPoints = danser1.points + danser2.points;
            string DanserOut = (danser1.name + " & " + danser2.name + danserParPoints);
            return (DanserOut);
        }

        public string name;
        public int points;
        public Danser(string aName, int aPoints)
        {
            name = aName;
            points = aPoints;
        }
    }
}