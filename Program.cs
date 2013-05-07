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
            EntenManager manager = EntenManager.GetInstance();
            manager.Registriere(new Krickente());
            manager.Registriere(new Stockente());
            manager.Registriere(new Schnatterente());
            manager.Registriere(new Flugente());
            manager.Registriere(new Pfeifente());

            EntenSimulator sim = EntenSimulator.GetInstance(manager);
            sim.Start();
        }
    }
}
