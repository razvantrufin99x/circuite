using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circuitelectriccuintrerupatoare circuitulAND = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitulOR = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitulNOT = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitulANDM = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitNOTSNmx = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitANDSBmx = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitANDASNmx = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitORZmx = new circuitelectriccuintrerupatoare();

        private void Form1_Load(object sender, EventArgs e)
        {

            //AND GATE
            circuitulAND.listaIntrerupatoareIntrare.Add(this.intrerupator1);
            circuitulAND.listaIntrerupatoareIntrare.Add(this.intrerupator2);
            circuitulAND.listaIntrerupatoareIesire.Add(this.intrerupator3);

            //NOT GATE
            circuitulNOT.listaIntrerupatoareIntrare.Add(this.intrerupator4);
            circuitulNOT.listaIntrerupatoareIesire.Add(this.intrerupator5);
           
            //OR GATE
            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator6);
            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator7);
            circuitulOR.listaIntrerupatoareIesire.Add(this.intrerupator8);



            //MULTPLE AND 3X AND
            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator10);
            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator12);
            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator11);
            circuitulANDM.listaIntrerupatoareIesire.Add(this.intrerupator9);



            //MULTIPLEXORUL MX I A B S , O Z 

            circuitNOTSNmx.listaIntrerupatoareIntrare.Add(this.intrerupator14);
            circuitNOTSNmx.listaIntrerupatoareIesire.Add(this.intrerupator16);

            circuitANDSBmx.listaIntrerupatoareIntrare.Add(this.intrerupator14);
            circuitANDSBmx.listaIntrerupatoareIntrare.Add(this.intrerupator15);
            circuitANDSBmx.listaIntrerupatoareIesire.Add(this.intrerupator17);

            circuitANDASNmx.listaIntrerupatoareIntrare.Add(this.intrerupator16);
            circuitANDASNmx.listaIntrerupatoareIntrare.Add(this.intrerupator13);
            circuitANDASNmx.listaIntrerupatoareIesire.Add(this.intrerupator18);

            circuitORZmx.listaIntrerupatoareIntrare.Add(this.intrerupator18);
            circuitORZmx.listaIntrerupatoareIntrare.Add(this.intrerupator17);
            circuitORZmx.listaIntrerupatoareIesire.Add(this.intrerupator19);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            circuitulAND.ANDLogic( circuitulAND.listaIntrerupatoareIntrare[0],  circuitulAND.listaIntrerupatoareIntrare[1],  circuitulAND.listaIntrerupatoareIesire[0]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            circuitulNOT.NOTLogic(circuitulNOT.listaIntrerupatoareIntrare[0], circuitulNOT.listaIntrerupatoareIesire[0]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            circuitulOR.ORLogic(circuitulOR.listaIntrerupatoareIntrare[0], circuitulOR.listaIntrerupatoareIntrare[1], circuitulOR.listaIntrerupatoareIesire[0]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            circuitulAND.ANDMultipleLogic( ref circuitulANDM.listaIntrerupatoareIntrare, circuitulANDM.listaIntrerupatoareIesire[0]);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NOT SN i 14 ~ o 16 
            
            circuitNOTSNmx.NOTLogic(circuitNOTSNmx.listaIntrerupatoareIntrare[0], circuitNOTSNmx.listaIntrerupatoareIesire[0]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //AND SB i 14 && i 15  == o 17
            circuitANDSBmx.ANDLogic(circuitANDSBmx.listaIntrerupatoareIntrare[0], circuitANDSBmx.listaIntrerupatoareIntrare[1], circuitANDSBmx.listaIntrerupatoareIesire[0]);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            // circuitANDASNmx I13 AND I16 = O18
            circuitANDASNmx.ANDLogic(circuitANDASNmx.listaIntrerupatoareIntrare[0], circuitANDASNmx.listaIntrerupatoareIntrare[1], circuitANDASNmx.listaIntrerupatoareIesire[0]);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //circuitORZmx I18 OR I17 =O19
            circuitORZmx.ORLogic(circuitORZmx.listaIntrerupatoareIntrare[0], circuitORZmx.listaIntrerupatoareIntrare[1], circuitORZmx.listaIntrerupatoareIesire[0]);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
