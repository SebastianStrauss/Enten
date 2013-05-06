using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Schnatterente : Ente
    {
        public string Schnatter()
        {
            return ("Schnatter");
        }
        public override string Quack()
        {
            return ("Quuuäck");
        }
        public override string ToString()
        {
            return "Schnatterente";
        }
    }
}
