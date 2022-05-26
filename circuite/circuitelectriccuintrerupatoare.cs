using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuite
{
    public class circuitelectriccuintrerupatoare
    {
        public List<intrerupator> listaIntrerupatoareIntrare = new List<intrerupator>();
        public List<intrerupator> listaIntrerupatoareIesire = new List<intrerupator>();

        public bool ANDLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" && B.value == "ON") { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool ORLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" || B.value == "ON") { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool NOTLogic(intrerupator A,  intrerupator C)
        {
            if (A.value == "OFF" ) { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }


        public void checkState() { 
            
        }
    }
}
