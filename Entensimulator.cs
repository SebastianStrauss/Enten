using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enten
{
    sealed class EntenSimulator
    {
        private static EntenSimulator INSTANCE;
        public static EntenSimulator GetInstance(EntenManager manager)
        {
            // TODO: Geht das so?
            INSTANCE = new EntenSimulator(manager);
            return INSTANCE;
        }

        private EntenManager _manager;
       
        /* Instanziierung von außen verhindern */
        private EntenSimulator(EntenManager manager)
        { 
            if (manager == null)
                throw new ArgumentNullException("manager");
            _manager = manager;
        }

        public void Start()
        {
            Console.WriteLine("Es wurden Folgende Enten geladen:");
            foreach (object obj in _manager.GetRegistrierteObjekte())
                Console.WriteLine(obj);

            do
            {
                Random oRND = new Random();
                int iEntentyp = oRND.Next(1, 4);
                List<object> oEntenschwarm  = _manager.GetEntenListen((EntenManager.DuckType)iEntentyp);
                PrintMessage(oEntenschwarm[oRND.Next(0, oEntenschwarm.Count)], iEntentyp);
                System.Threading.Thread.Sleep(500);
            } while (true);
        }

        private void PrintMessage(object oEnte, int iEntentyp)
        {

            switch (iEntentyp)
            {
                case 1:
                    IKannQuaken oIQuaken = oEnte as IKannQuaken;
                     Console.WriteLine(oIQuaken.Quak());
                    break;
                case 2:
                    IKannFliegen oIFliegen = oEnte as IKannFliegen;
                     Console.WriteLine(oIFliegen.Flieg());
                    break;
                case 3:
                    IKannSchwimmen oISchwimmen = oEnte as IKannSchwimmen;
                     Console.WriteLine(oISchwimmen.Schwimm());
                    break;
                default:
                    break;
            }
        
        }
    }
}
