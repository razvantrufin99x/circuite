using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuite
{

    public class ce
    {

        public List<int> i = new List<int>();
        public List<int> o = new List<int>();

        public int AND(int a, int b, ref int c)
        {
            if (a == 1 && b == 1) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int OR(int a, int b, ref int c)
        {
            if (a == 1 || b == 1) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int NOT(int a, ref int c)
        {
            if (a == 1 ) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int BUFFER(int a, ref int c)
        {
            if (a == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int NOR(int a, int b, ref int c)
        {
            if (a == 1 || b == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int XOR(int a, int b, ref int c)
        {
            if (a!=b && (a == 1 || b == 1)) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int XNOR(int a, int b, ref int c)
        {
            if (a != b && (a == 1 || b == 1)) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int NAND(int a, int b, ref int c)
        {
            if  (a == 1 && b == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int ANDmx(ref List<int> im, ref int c)
        {
            if (im[0] == 1 && im[1] == 1 && im[2] == 1) { c = 1; return 1; }
            else { c = 1; return 0; }
        }

        public int MUX(int a, int b, int s, ref int z)
        {
            int sb = 0;
            int asn = 0;
            int sn = 0;
            this.AND(a, b, ref sb);
            this.NOT(s, ref sn);
            this.AND(a, sn, ref asn);
            this.OR(asn, sb, ref z);
            return 1;
        }

    }
}
