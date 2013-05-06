using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Enten
{
    abstract class Ente
    {
        private readonly string _name;
        private readonly string _laut;

        protected Ente(string name, string laut)
        {
            Debug.Assert(!String.IsNullOrWhiteSpace(name));
            Debug.Assert(!String.IsNullOrWhiteSpace(laut));
            _name = name;
            _laut = laut;
        }

        public virtual string Quack()
        {
            return (String.Format("Die {0} macht {1}" , _name, _laut));
        }
        public string Schwimm()
        {
            return String.Format("Die {0} schwimmt hin und her.", _name);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
