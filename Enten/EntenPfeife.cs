using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    class EntenPfeife : IKannQuaken
    {
        public string Quak()
        {
            return "Die Entenpfeife macht Quack";
        }

        public override string ToString()
        {
            return "EntenPfeife";
        }
    }
}
