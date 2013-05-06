using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Schnatterente : Ente
    {
        public override string Quack()
        {
            return ("Schnatter");
        }
        public override string ToString()
        {
            return "Schnatterente";
        }
    }
}
