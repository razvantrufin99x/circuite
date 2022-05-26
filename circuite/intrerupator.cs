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
    public partial class intrerupator : UserControl
    {
        public intrerupator()
        {
            InitializeComponent();
        }
        public string value = "OFF";

        public bool debugOnly()
        {
            this.label1.Text = this.value;
            return true;
        }
        public bool setValue() {
            if (this.value == "OFF") { this.value = "ON"; debugOnly();  return true; }
            else { this.value = "OFF"; debugOnly(); return false; }
            
        }
        public bool setColor() {
            if (this.value == "OFF") { this.button1.BackColor = Color.Red; return true; }
            else { this.button1.BackColor = Color.Green; return false; }
        }
        public bool setText()
        {
            if (this.value == "OFF") { this.button1.Text = "OFF"; return true; }
            else { this.button1.Text = "ON"; return false; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setUp();
        }
        public void setUp()
        {
            setValue();
            setColor();
            setText();
        }
        public void startUp() {
            setColor();
            setText();
        }
        private void intrerupator_Load(object sender, EventArgs e)
        {
           startUp();
            debugOnly();
        }
    }
}
