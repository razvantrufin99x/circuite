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

        circuitelectriccuintrerupatoare circuitulNAND = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulOR = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulXOR = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulXNOR = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulNOR = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulNOT = new circuitelectriccuintrerupatoare();

        circuitelectriccuintrerupatoare circuitulBUFFER = new circuitelectriccuintrerupatoare();

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

            //NAND GATE
            circuitulNAND.listaIntrerupatoareIntrare.Add(this.intrerupator25);
            circuitulNAND.listaIntrerupatoareIntrare.Add(this.intrerupator26);
            circuitulNAND.listaIntrerupatoareIesire.Add(this.intrerupator27);

            //NOT GATE
            circuitulNOT.listaIntrerupatoareIntrare.Add(this.intrerupator4);
            circuitulNOT.listaIntrerupatoareIesire.Add(this.intrerupator5);

            //BUFFER
            circuitulBUFFER.listaIntrerupatoareIesire.Add(intrerupator21);
            circuitulBUFFER.listaIntrerupatoareIntrare.Add(intrerupator20);

            //OR GATE
            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator6);
            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator7);
            circuitulOR.listaIntrerupatoareIesire.Add(this.intrerupator8);

            //XOR GATE
            circuitulXOR.listaIntrerupatoareIntrare.Add(this.intrerupator28);
            circuitulXOR.listaIntrerupatoareIntrare.Add(this.intrerupator29);
            circuitulXOR.listaIntrerupatoareIesire.Add(this.intrerupator30);

            //XNOR GATE
            circuitulXNOR.listaIntrerupatoareIntrare.Add(this.intrerupator31);
            circuitulXNOR.listaIntrerupatoareIntrare.Add(this.intrerupator32);
            circuitulXNOR.listaIntrerupatoareIesire.Add(this.intrerupator33);


            //NOR GATE
            circuitulNOR.listaIntrerupatoareIntrare.Add(this.intrerupator23);
            circuitulNOR.listaIntrerupatoareIntrare.Add(this.intrerupator22);
            circuitulNOR.listaIntrerupatoareIesire.Add(this.intrerupator24);


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
            //AND I1,I2 AND O3
            circuitulAND.ANDLogic( circuitulAND.listaIntrerupatoareIntrare[0],  circuitulAND.listaIntrerupatoareIntrare[1],  circuitulAND.listaIntrerupatoareIesire[0]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NOT I4 NOT O5
            circuitulNOT.NOTLogic(circuitulNOT.listaIntrerupatoareIntrare[0], circuitulNOT.listaIntrerupatoareIesire[0]);

        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            //OR I6,I7 OR O8
            circuitulOR.ORLogic(circuitulOR.listaIntrerupatoareIntrare[0], circuitulOR.listaIntrerupatoareIntrare[1], circuitulOR.listaIntrerupatoareIesire[0]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3XAND I10,I11,I12 3XAND O9
            circuitulAND.ANDMultipleLogic( ref circuitulANDM.listaIntrerupatoareIntrare, circuitulANDM.listaIntrerupatoareIesire[0]);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NOT SN I14 ~ O16 
            
            circuitNOTSNmx.NOTLogic(circuitNOTSNmx.listaIntrerupatoareIntrare[0], circuitNOTSNmx.listaIntrerupatoareIesire[0]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //AND SB I14 && I15  == O17
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

        private void button9_Click(object sender, EventArgs e)
        {
            //BUFFER I20 B O21
            circuitulBUFFER.DigitalBuffer(circuitulBUFFER.listaIntrerupatoareIntrare[0], circuitulBUFFER.listaIntrerupatoareIesire[0]);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //NOR I22,I23 NOR O24
            circuitulNOR.NORLogic(circuitulNOR.listaIntrerupatoareIntrare[0], circuitulNOR.listaIntrerupatoareIntrare[1], circuitulNOR.listaIntrerupatoareIesire[0]);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //NAND I25,I26 NAND O27
            circuitulNAND.NANDLogic(circuitulNAND.listaIntrerupatoareIntrare[0], circuitulNAND.listaIntrerupatoareIntrare[1], circuitulNAND.listaIntrerupatoareIesire[0]);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //XOR I28,I29 XOR I30
            circuitulXOR.XORLogic(circuitulXOR.listaIntrerupatoareIntrare[0], circuitulXOR.listaIntrerupatoareIntrare[1], circuitulXOR.listaIntrerupatoareIesire[0]);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //XNOR I31,I32 XNOR O33
            circuitulXNOR.XNORLogic(circuitulXNOR.listaIntrerupatoareIntrare[0], circuitulXNOR.listaIntrerupatoareIntrare[1], circuitulXNOR.listaIntrerupatoareIesire[0]);

        }
    }
}
