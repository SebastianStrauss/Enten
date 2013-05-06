using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Program
    {
        private static List<Ente> oEntenschwarm = new List<Ente>();
        private static Random oRND = new Random();

        static void Main(string[] args)
        {
            oEntenschwarm.Add(new Krickente());
            oEntenschwarm.Add(new Stockente());
            oEntenschwarm.Add(new Schnatterente());

            Console.WriteLine("Es wurden Folgende Enten geladen:");
            foreach (Ente oEnte in oEntenschwarm)
                Console.WriteLine(oEnte);        

            do
            {
                int iEntennummer = oRND.Next(0, oEntenschwarm.Count());
                PrintMessage(oEntenschwarm[iEntennummer]);
                System.Threading.Thread.Sleep(1000);   
            } while (true);
        }

        private static void PrintMessage(Ente oEnte)
        {
            int iEntenaktivität = oRND.Next(0, 3);
            if (iEntenaktivität == 0)
                Console.WriteLine(oEnte.Quack());
            else if (iEntenaktivität == 1)
                Console.WriteLine(oEnte.Schwimm());
            else
                Console.WriteLine(oEnte.Flieg());
        }
    }
}
