using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class Ente
    {
        public virtual string Quacken()
        {
            return ("Quack!");
        }
        public string Schwimmen()
        {
            Random rnd = new Random();
            return (String.Format("Die Ente Schwimmt {0} Meter", rnd.Next(1, 10)));
        }
        
    }
}
