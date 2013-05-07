using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Pfeifente: IKannFliegen, IKannQuaken, IKannSchwimmen
    {
        public string Flieg()
        {
            return "Die Pfeifente fliegt durch die Gegend";
        }

        public string Quak()
        {
            return "Die Pfeifente macht Pfeifidi Pfeif";
        }

        public string Schwimm()
        {
            return "Die Pfeifente schwimt im See";
        }

        public override string ToString()
        {
            return "Pfeifente";
        }
    }
}
