using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Stockente : Ente
    {
        public override string Quacken()
        {
            return ("Quuuack");
        }
        public override string ToString()
        {
            return "Stockente";
        }
    }
}
