using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten 
{
    class Quietscheente : IKannQuaken, IKannSchwimmen
    {
        public string Quak()
        {
            return "Die Quietscheente macht Quietsch";
        }

        public string Schwimm()
        {
            return "Die Quietscheente schwimt in der Badewanne";
        }

        public override string ToString()
        {
            return "Quietscheente";
        }
    }
}
