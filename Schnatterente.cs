using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Schnatterente : Ente
    {
        public string Schnattern()
        {
            return ("Schnatter");
        }
        public override string Quacken()
        {
            return ("Quuuäck");
        }
        public override string ToString()
        {
            return "Schnatterente";
        }
    }
}
