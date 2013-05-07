using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Stockente : IKannFliegen, IKannQuaken, IKannSchwimmen
    {
        public string Flieg()
        {
            return "Die Stockente fliegt durch die Gegend";
        }

        public string Quak()
        {
            return "Die Stockente macht Quaaak";
        }

        public string Schwimm()
        {
            return "Die Stockente schwimt im See";
        }

        public override string ToString()
        {
            return "Stockente";
        }
    }
}
