using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Stockente : Ente
    {
        public override string Quack()
        {
            return ("Quuuack");
        }
        public override string ToString()
        {
            return "Stockente";
        }
    }
}
