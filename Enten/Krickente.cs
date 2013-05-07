using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Krickente : IKannFliegen,IKannQuaken, IKannSchwimmen
    {
        public string Flieg()
        {
            return "Die Krickente fliegt durch die Gegend";
        }

        public string Quak()
        {
            return "Die Krickente macht Quaaak";
        }

        public string Schwimm()
        {
            return "Die Krickente schwimt im See";
        }

        public override string ToString()
        {
            return "Krickente";
        }
    }
}
