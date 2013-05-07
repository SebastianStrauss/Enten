using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Schnatterente : IKannFliegen, IKannQuaken, IKannSchwimmen
    {
        public string Flieg()
        {
            return "Die Schnatterente fliegt durch die Gegend";
        }

        public string Quak()
        {
            return "Die Schnatterente macht Schnatter";
        }

        public string Schwimm()
        {
            return "Die Schnatterente schwimt im See";
        }

        public override string ToString()
        {
            return "Schnatterente";
        }
    }
}
