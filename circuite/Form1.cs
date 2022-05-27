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

        private void Form1_Load(object sender, EventArgs e)
        {
            circuitulAND.listaIntrerupatoareIntrare.Add(this.intrerupator1);
            circuitulAND.listaIntrerupatoareIntrare.Add(this.intrerupator2);
            circuitulAND.listaIntrerupatoareIesire.Add(this.intrerupator3);

            circuitulNOT.listaIntrerupatoareIntrare.Add(this.intrerupator4);
            circuitulNOT.listaIntrerupatoareIesire.Add(this.intrerupator5);
           

            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator6);
            circuitulOR.listaIntrerupatoareIntrare.Add(this.intrerupator7);
            circuitulOR.listaIntrerupatoareIesire.Add(this.intrerupator8);

            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator10);
            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator12);
            circuitulANDM.listaIntrerupatoareIntrare.Add(this.intrerupator11);
            circuitulANDM.listaIntrerupatoareIesire.Add(this.intrerupator9);

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
    }
}
