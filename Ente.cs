using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Ente
    {
        public virtual string Quack()
        {
            return ("Quack!");
        }
        public string Schwimm()
        {
            Random rnd = new Random();
            return (String.Format("Die Ente Schwimmt {0} Meter", rnd.Next(1, 10)));
        }
    }
}
