using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Flugente : IKannFliegen, IKannQuaken, IKannSchwimmen
    {

        public string Flieg()
        {
            return "Die Flugente fliegt durch die Gegend";
        }

        public string Quak()
        {
            return "Die Flugente macht Quaaak";
        }

        public string Schwimm()
        {
            return "Die Flugente schwimt im See";
        }

        public override string ToString()
        {
            return "Flugente";
        }
    }
}
