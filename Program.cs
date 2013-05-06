using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ente> oEntenschwarm = new List<Ente>();
            Random oRND = new Random();
            oEntenschwarm.Add(new Krickente());
            oEntenschwarm.Add(new Stockente());
            oEntenschwarm.Add(new Schnatterente());

            Console.WriteLine("Es wurden Folgende Enten geladen:");
            foreach (Ente oEnte in oEntenschwarm)
               Console.WriteLine(oEnte.GetType());        

            do
            {
                int iEntennummer = oRND.Next(0, oEntenschwarm.Count());
                string Entenname = oEntenschwarm[iEntennummer].GetType().ToString();
                Entenname = Entenname.Substring(Entenname.IndexOf('.') + 1);
                Console.Write(Entenname);
                Console.Write(": ");
                if(oRND.Next(0,2) == 0)
                    Console.WriteLine(oEntenschwarm[iEntennummer].Quacken());
                else
                    Console.WriteLine(oEntenschwarm[iEntennummer].Schwimmen());
                System.Threading.Thread.Sleep(1000);   
            } while (true);
        }
    }
}
