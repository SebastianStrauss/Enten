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
            Ente[] oEnten = new Ente[3];
            Random oRND = new Random();
            oEnten[0] = new Krickente();
            oEnten[1] = new Stockente();
            oEnten[2] = new Schnatterente();

            Console.WriteLine(String.Format("Es wurden Folgende Enten geladen:" +
                "\n {0} \n {1} \n {2}"
                , oEnten[0].GetType().ToString()
                , oEnten[1].GetType().ToString()
                , oEnten[2].GetType().ToString()));

            do
            {
                int iEntennummer = oRND.Next(0, 3);
                string Entenname = oEnten[iEntennummer].GetType().ToString();
                Entenname = Entenname.Substring(Entenname.IndexOf('.')+ 1);
                Console.Write(Entenname);
                Console.Write(": ");
                if(oRND.Next(0,2) == 0)
                    Console.WriteLine(oEnten[iEntennummer].Quacken());
                else
                    Console.WriteLine(oEnten[iEntennummer].Schwimmen());
                System.Threading.Thread.Sleep(1000);   
            } while (true);
        }
    }
}
