using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuite
{
    /*
     * https://www.electronics-tutorials.ws/logic/logic_10.html
     * 
     */
    public class circuitelectriccuintrerupatoare
    {
        public List<intrerupator> listaIntrerupatoareIntrare = new List<intrerupator>();
        public List<intrerupator> listaIntrerupatoareIesire = new List<intrerupator>();
        
            public bool ANDMultipleLogic(ref List <intrerupator> im, intrerupator C)
        {
            if (im[0].value == "ON" && im[1].value == "ON" && im[2].value=="ON") { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }
        public bool ANDLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" && B.value == "ON") { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool NANDLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" && B.value == "ON") { C.value = "OFF"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "ON"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool ORLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" || B.value == "ON") { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool NORLogic(intrerupator A, intrerupator B, intrerupator C)
        {
            if (A.value == "ON" || B.value == "ON") { C.value = "OFF"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "ON"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool XORLogic(intrerupator A, intrerupator B, intrerupator C)
        {

            if (A.value != B.value && (A.value == "ON" || B.value == "ON")) { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool XNORLogic(intrerupator A, intrerupator B, intrerupator C)
        {

            if (A.value != B.value && (A.value == "ON" || B.value == "ON")) { C.value = "OFF"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "ON"; C.startUp(); C.debugOnly(); return false; }
        }

        public bool NOTLogic(intrerupator A,  intrerupator C)
        {
            if (A.value == "OFF" ) { C.value = "ON"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "OFF"; C.startUp(); C.debugOnly(); return false; }
        }
        public bool DigitalBuffer(intrerupator A, intrerupator C)
        {
            if (A.value == "OFF") { C.value = "OFF"; C.startUp(); C.debugOnly(); return true; }
            else { C.value = "ON"; C.startUp(); C.debugOnly(); return false; }
        }


        public void checkState() { 
            
        }
    }
}
