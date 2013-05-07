using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    sealed class EntenManager
    {
        internal enum DuckType
        {
            quacking = 1,
            flying = 2,
            swimming = 3
        }
        private static readonly EntenManager INSTANCE = new EntenManager();
        public static EntenManager GetInstance()
        {
            return INSTANCE;
        }

        private List<object> oListFLiegen = new List<object>();
        private List<object> oListSchwimmen = new List<object>();
        private List<object> oListQuacken = new List<object>();
        private List<object> oListAll = new List<object>();
       
        /* Instanziierung von außen verhindern */
        private EntenManager() { }


        public void Registriere(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            // Prüfen was die übergebene Instanz alles kann.
            if (obj is IKannFliegen)
                oListFLiegen.Add(obj);
            if (obj is IKannQuaken)
                oListQuacken.Add(obj);
            if (obj is IKannSchwimmen)
                oListSchwimmen.Add(obj);
            oListAll.Add(obj);
            
        }

        internal List<object> GetEntenListen(DuckType Type)
        {
            switch (Type)
            {
                case DuckType.quacking:
                    return oListQuacken;
                case DuckType.flying:
                    return oListFLiegen;
                case DuckType.swimming:
                    return oListSchwimmen;
                default:
                    return null;
            }
        }

        internal List<object> GetRegistrierteObjekte()
        {
            return oListAll;
        }
    }
}
