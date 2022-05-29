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
            if (a == 1) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int BUFFER(int a, ref int c)
        {
            if (a == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        //unused input is on GND via 1kohm R alwais is 0 logic
        public int NOR(int a, int b, ref int c)
        {
            if (a == 1 || b == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int XOR(int a, int b, ref int c)
        {
            if (a != b && (a == 1 || b == 1)) { c = 1; return 1; }
            else { c = 0; return 0; }
        }

        public int XNOR(int a, int b, ref int c)
        {
            if (a != b && (a == 1 || b == 1)) { c = 0; return 0; }
            else { c = 1; return 1; }
        }
        //unused input is tied to other input or ON all the time
        public int NAND(int a, int b, ref int c)
        {
            if (a == 1 && b == 1) { c = 0; return 0; }
            else { c = 1; return 1; }
        }

        public int TripleNAND(int a, int b, int c, ref int r)
        {
            if (a == 1 && b == 1 && c == 1) { r = 0; return 0; }
            else { r = 1; return 1; }
        }

        public int QuadNAND(int a, int b, int c, int d, ref int r)
        {
            if (a == 1 && b == 1 && c == 1 && d == 1) { r = 0; return 0; }
            else { r = 1; return 1; }
        }

        public int QuadNANDLists(ref List<int> l, ref int r)
        {
            if (l[0] == 1 && l[1] == 1 && l[2] == 1 && l[3] == 1) { r = 0; return 0; }
            else { r = 1; return 1; }
        }

        public int OctNAND(int a, int b, int c, int d, int e, int f, int g, int h, ref int r)
        {
            if (a == 1 && b == 1 && c == 1 && d == 1 && e == 1 && f == 1 && g == 1 && h == 1) { r = 0; return 0; }
            else { r = 1; return 1; }
        }

        public int OctNAND2QuadNAND(ref List<int> q1, ref List<int> q2, ref int r)
        {
            int rq1 = 0;
            this.QuadNANDLists(ref q1, ref rq1);
            int rq2 = 0;
            this.QuadNANDLists(ref q2, ref rq2);
            this.NOR(rq1, rq2, ref r);
            this.NOT(r, ref r);
            return r;
        }

        //and or inverted gate
        public int AOI(ref List<int> ab, ref List<int> cd, ref int z)
        {
            int rq1 = 0;
            int rq2 = 0;
            this.AND(ab[0], ab[1], ref rq1);
            this.AND(cd[0], cd[1], ref rq2);
            this.NOR(rq1, rq2, ref z);
            return z;
        }

        //pr and inverted gate
        public int OAI(ref List<int> ab, ref List<int> cd, ref int z)
        {
            int rq1 = 0;
            int rq2 = 0;
            this.OR(ab[0], ab[1], ref rq1);
            this.OR(cd[0], cd[1], ref rq2);
            this.NAND(rq1, rq2, ref z);
            return z;
        }


        public int ANDmx(ref List<int> im, ref int c)
        {
            if (im[0] == 1 && im[1] == 1 && im[2] == 1) { c = 1; return 1; }
            else { c = 0; return 0; }
        }
        public int TransmissionGate(int NOTEN, int A, int B, int EN, ref int r)
        {


            return r;
        }

        //multiplexor with transmission gates
        public int MUXT(ref int z)
        {


            return z;
        }

        //schmitt trigger inputs
        // return = 2 HI_Z high impedance or floating state
        public int NOTTS(int A, int EN, ref int z)
        {
            if (EN == 1 && A == 1) { z = 1; return 1; }
            else if (EN == 1 && A == 0) { z = 0; return 0; }
            else if (EN == 0 && A == 1) { z = 2; return 2; }
            else if (EN == 0 && A == 0) { z = 2; return 2; }
            return z;
        }
        //open drain ouput CMOS NAND gate
        //drive a LED device with ODONAND or ordinary CMOS gate 
        public int ODONAND(int a, int b, ref int z)
        {
            if (a == 1 && b == 1) { z = 0; return 0; }
            else { z = 1; return 1; }
        }

        public int ODONAND3xAND(int a, int b, int c, int d, int e, int f, ref int z)
        {
            //unknown
            return 0;
        }


        public class CMOS
        {
            public int A;
            public int B;
            public int Z;
            public float VCCmax;
            public float GND;
            public float VCCmin;


        }

        public class range
        {
            public float min = 0.0f;
            public float max = 1.0f;
            public range() { }
            public range(float pmin, float pmax) {
                min = pmin;
                max = pmax;
            }
        }
        //hight speed CMOS
        public class HC : CMOS
        {
            public HC() { this.VCCmax = 5.0f; this.VCCmin = 0.0f; }
            public float VOLmaxT = 0.33f;
            public float VILmax = 1.5f;
            public float VHmin = 3.5f;
            public float VOHminT = 3.84f;
            public range ABNORMAL = new range(1.5f, 3.5f);
        }
        //high speed CMOS,TTL
        public class HCT : CMOS
        {
            public HCT() { this.VCCmax = 5.0f; this.VCCmin = 0.0f; }
            public float VOLmaxT = 0.33f;
            public float VILmax = 0.8f;
            public float VHmin = 2.0f;
            public float VOHminT = 3.84f;
            public range ABNORMAL = new range(0.8f, 2.0f);
        }

        //very V
        public class VHC : CMOS { }
        public class VHCT : CMOS { }

        //fast F
        public class FCT : CMOS { }
        public class FCTT : CMOS { }

        //diode
        public class region {
            public char name;
        }
        public class jonction {
            public region p;
            public region n;
        }
        public class device
        {

        }
        public class pndevice {
            public jonction jpn;
        }
        public class diode : pndevice {

        }
        public class circuitelectric
        {

        }

        public class diodeintrerupator { }
        //reverse bias of diode
        //forward bias of diode
        //diode logic
        //diodeANDgate
        //diode
        //diode2ANDgates
        public int diode2ANDgates(ref List<int> xy, int B, ref int c)
        {
            int z = 0;

            this.AND(xy[0], xy[1], ref z);
            this.AND(z, B, ref c);

            return c;
        }

        public class terminal
        {
            public string name;
            public terminal() { }
            public terminal(string name) { this.name = name; }  

        }
        public class wire
        {
            public string name;
            public object a;
            public object b;
            public wire() { }
            public wire(string name) { this.name = name; }
        }
        //bipolar junction transistors
        public class TB
        {
            public terminal Emitor;
            public terminal Colector;
            public terminal Baza;
        }
        public class TBnpn : TB {
            public jonction CBnp;
            public jonction BEpn;

            public void simulate(float vcc, float vin, float r1, float r2)
            {
                float diodedrop = 0.6f;
                float beta = 10.0f;
                float vcesat = 0.2f;
                float rcesat = 50.0f;
                //float vcc=0, vin=0, r1=0, r2=0;
                float ib = 0, ic = 0, vce = 0;
                if (vin < diodedrop)
                {
                    ib = 0.0f;
                    ic = 0.0f;
                    vce = vcc;
                }
                else
                {
                    ib = (vin - diodedrop) / r1;
                    if ((vcc - ((beta * ib) * r2)) >= vcesat)
                    {
                        ic = beta * ib;
                        vce = vcc - (ic * r2);
                    }
                    else
                    {
                        vce = vcesat;
                        ic = (vcc - vce) / (r2 * rcesat);
                    }
                }
            }

        }
        public class TBpnp : TB
        {
            public jonction CBpn;
            public jonction BEnp;
        }

        //transitor inverter    
        //echivalent NOT gate
        public void TransistorInverter()
        {
            //NOTgate
        }

        public class SchottkyDiode { }

        public class SchottkyTranzistor : TB
        {
            public SchottkyDiode SkD;
        }

        //v. NOT gate
        public void InverterSchottkyTransistor() { }

        //transistor transistor logic
        //tll nand gate
        //dioade and gate and input protection
        //phase splitter
        //output stage

        public class gate {
            public float VCC;
            public float VOHmin;
            public float IHmin;
            public float VILmax;
            public float VOLmax;
            public float VCC0;
            public float VCCn;
            public gate() { }
            public gate(float PVCC, float PVOHmin, float PIHmin, float PVILmax, float PVOLmax, float PVCC0, float PVCCn)
            {
                VCC = PVCC;
                VOHmin = PVOHmin;
                IHmin = PIHmin;
                VILmax = PVILmax;
                VOLmax = PVOLmax;
                VCC0 = PVCC0;
                VCCn = PVCCn;
            }
        }

        public class LSTTLgate
        {
            public float VCC=5;
            public float VOHmin=2.7f;
            public float IHmin=2.0f;
            public float VILmax=0.8f;
            public float VOLmax=0.5f;
            public float VCC0=0.0f;
            public float VCCn=0.0f;
            public float maximpropagdelay;
            public float powercomsumpergate;
            public float speedpowerproduct;
            public float Ii;
            public float IOS;
            public float ICCH;
            public float ICCL;
            public float VIK;
            public float VOH;
            public float VOL;
            public float IIH;
            public float IIL;
            public float IIOS;
            public float IPLH;
            public float IPHL;


            public LSTTLgate() { }
            public LSTTLgate(float PVCC, float PVOHmin, float PIHmin, float PVILmax, float PVOLmax, float PVCC0, float PVCCn)
            {
                VCC = PVCC;
                VOHmin = PVOHmin;
                IHmin = PIHmin;
                VILmax = PVILmax;
                VOLmax = PVOLmax;
                VCC0 = PVCC0;
                VCCn = PVCCn;
            }
        }

        //2in LS TTL gate NAND
        public int twoinputsLSTTLNANDgate(int X, int Y, ref int Z) 
        {
            if (X == 1 && Y == 1) { Z = 0;  return 0; }
            else { Z = 1; return 1; }
        }

        //logic levels and noise margins 
        //ttl output driving a ttl output to ON or OFF
        //fanout LSTTL
        //unused inputs LSTTL
        //pull up and down Rs

        //2in LS TTL gate NOR
        public void twoimputsLSTTLNORgate() { }

        //TTL families
        //early 7400
        //schottky TTL 74S
        //74 family S, LS, AS, ALS, F
        //TTL characteristics
        //TTL data sheet

        //CMOS/TTL Interfacing
        //low voltage CMOS logic and interfacing
        //V LVTTL and LVCMOS logic
        //5V Tolerant Inputs Device CMOS
        //5V non Tolerant Inputs Device CMOS
        //TLL/LVTTL Interfacing
        //2.5V and 1.8V Logic
        //Emiter Coupled Logic ECL
        //CML Circuit
        //CML inverted buffer H in
        //CML inverted buffer L in
        public class pair
        {
            public int a;
            public int b;
            public pair() { }
            public pair(int pa, int pb) { a = pa; b= pb; }
        }

        //OUT1 is NOR
        //OUT2 is OR
        public pair CML2inputsORNORgate(int x, int y, ref int Out1, ref int Out2)
        { 
                if(x == 0 && y == 0) { Out1 = 1; Out2 = 0; return new pair(1,0);
                }
                else { Out1 = 0; Out2 = 1; return new pair(0,1); }

        }


        //ECL 10K/10H fam.
        //OUT1 is NOR
        //OUT2 is OR
        public pair ECL10k2inputsORNORgate(int x, int y, ref int Out1, ref int Out2)
        {
            if (x == 0 && y == 0)
            {
                Out1 = 1; Out2 = 0; return new pair(1, 0);
            }
            else { Out1 = 0; Out2 = 1; return new pair(0, 1); }

        }

        //ECL 100k fam.
        //PECL


        //combinational logic design principles
        //algebra switching
        //boolean algebra
        //axiome
        //~ not or complement
        public int BooleanNOT(int a)
        {
            if (a == 1) { return 0; }
            else { return 1; }
        }
        //* multiplication
        public int BooleanMULT(int a, int b)
        {
            if (a == 0 && b == 0) { return 0; }
            else if(a == 1 && b == 1) { return 1; }
            else if(a == 0 && b == 1) { return 0; }
            else if (a == 1 && b == 0) { return 0; }
            return 0;
        }
        //+ adding
        public int BooleanADD(int a, int b)
        {
            if (a == 0 && b == 0) { return 0; }
            else if (a == 1 && b == 1) { return 1; }
            else if (a == 0 && b == 1) { return 1; }
            else if (a == 1 && b == 0) { return 1; }
            return 0;
        }
        //identity + x+0=x
        public int BooleanIdentityADD(int X, int a)
        {
            if (a == 0) { return X; }
            return 1;
        }
        //identity * x*1=x
        public int BooleanIdentityMULT(int X, int a)
        {
            if (a == 1) { return X; }
            return 0;
        }
        //null element + x+1=1
        public int BooleanNUllElementADD(int X, int a)
        {
            if (a == 1) { return 1; }
            return X;
        }
        //null element * x*0=0
        public int BooleanNullElementMULT(int X, int a)
        {
            if (a == 0) { return 0; }
            return X;
        }
        //idempotency + x+x=x
        public int BooleanIdempotencyADD(int X, int a)
        {
            if (X == a) { return X; }
            else { return 1; }
        }
        //idempotency * x*x=x
        public int BooleanIdempotencyMULT(int X, int a)
        {
            if (X == a) { return X; }
            else { return 1; }
        }
        //involution + (x')' = x
        public int BooleanInvolutionADD(int X)
        {
            return X;
        }
        //complement + x+x'=1
        public int BooleanComplementADD(int X)
        {
           
            return 1; 
        }
        //complement + x*x'=0
        public int BooleanComplementMULT(int X)
        {
            return 0;
        }


        //single-variable theorems
        //x = 0 for 0+0=0
        //x = 1 for 1+0=1

        //2 or 3 variables theorems
        //commutativity
        //x+y = y +x
        //xy=yx

        //associativity
        //(x+y)+x = x+(y+z)
        //(xy)x = x(yz)

        //distributivity
        //(xy+xz) = x(y+z)
        //(x+y)(x+z) = x+y*z

        //coverting
        //x+x*y=x
        //x*(x+y)=x

        //combining
        //xy + xy' = x
        //(x+y)*(x+y')=x

        //consensus
        //x*y+x'*z+y*z = x*y+x'*z

        //t11'
        //(x+y)*(x'+z)*(y+z)= (x+y)*(x'+z)

        //n-variabile variable theorems
        //demorgan teorems
        //generalized idempotency
        //demorgan T
        //generalized demorgan T
        //shannon expansion T
        //pag204

        //equivalent gates according to demorgan T
        //AND NOT
        //(X*Y)'=Z
        //NOT OR
        //(X'+Y')=Z
        //NAND
        //(XY)' = Z
        //NAND
        //X'+Y'=Z

        //OR NOT
        //(X+Y)' = Z
        //NOT AND
        //X'Y' = Z
        //NOR 
        //(X+Y)'=Z
        //NOR
        //X'*Y'=Z

        //DEMORGAN EQUIV. TO T13

        //duality
        //swap(0,1)==true
        //swal('*','+')==true

        //boolean functions
        //function with gates
        //logic function
        //representations
        //true table ganeral
        // true table
        //minterm
        //maxterm
        //canonical sum
        //canonical product

        //Combinational circuit analysis
        //3 in to 1 out
        //circuite pentru analiza algebrica multi level
        //sinteza CC


        //canonical sum design for 4 bit prime number detector
        //alarm circuit deriver from logic expression
        //sum of products version of alarm circuit
        //alternatives sum of products realizations

        //circuit manipulation
        //sum of producst 2 levels alternative
        //products of sum expressions alt.

        //CB minimization
        //sum of products realiz for 4 bit prime nr det simplified

        //karnaugh maps
        //min suma of products
        //simp products of sums
        //dont care input combinations
        //multiple putput min
        //programmed min methods
        //repr of products terms
        //find prime implicants by combin products termns
        //find a min over using a prime implicant table
        //other min meth

        //timins hazards
        //static hazard
        //find st hazards using maps
        //dinamic hazards
        //designing hazard free circuit

        //abel hardware design language
        //abel program struct
        //abel compiler op
        //when state and equ blocks
        //truth tables
        //ranges, sets, relations
        //dont care inputs
        //test vectors


        //vdhl
        //ref

        //CL design practices
        //docu std
        //block diagram

        public class bus
        {
            public pair pereche = new pair();
        }
        public class block {
            public string name = "";
            public block() {}
            public block(string pname) { name = pname; }
            public List<terminal> tin = new List<terminal> ();
            public List<terminal> tout = new List<terminal>();
            
        }
        public class diagram { }
        public class blockdiagram : diagram {
             public List<block> blocksList = new List<block> ();
             public List<bus> busList = new List<bus> ();

        }

        public blockdiagram SHIFTANDADDMULTIPLIER = new blockdiagram();

        public void addBlocks()
        {
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("CONTROL"));
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("AREGISTER"));
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("BREGISTER"));
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("CARRYLOOKAHEADADDER"));
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("A16WORDX32BITRAM"));
            SHIFTANDADDMULTIPLIER.blocksList.Add(new block("MULTIPLEXER4TO1"));
        }
        public void addTerminals2Blocks()
        {


            SHIFTANDADDMULTIPLIER.blocksList[0].tin.Add(new terminal("RESET"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tin.Add(new terminal("LOAD"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tin.Add(new terminal("RUN"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tin.Add(new terminal("DISPLAY"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("LDA"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("LDB"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("BUS SEL"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("RW"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("BUS ADDR"));
            SHIFTANDADDMULTIPLIER.blocksList[0].tout.Add(new terminal("BYTE EN"));

            SHIFTANDADDMULTIPLIER.blocksList[1].tout.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[1].tin.Add(new terminal("LDA"));
            SHIFTANDADDMULTIPLIER.blocksList[1].tin.Add(new terminal("BUS 32"));

            SHIFTANDADDMULTIPLIER.blocksList[2].tout.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[2].tin.Add(new terminal("LDB"));
            SHIFTANDADDMULTIPLIER.blocksList[2].tin.Add(new terminal("BUS 32"));

            SHIFTANDADDMULTIPLIER.blocksList[4].tout.Add(new terminal("BUS OUT 32"));
            SHIFTANDADDMULTIPLIER.blocksList[4].tin.Add(new terminal("RW"));
            SHIFTANDADDMULTIPLIER.blocksList[4].tin.Add(new terminal("BYTE EN"));
            SHIFTANDADDMULTIPLIER.blocksList[4].tin.Add(new terminal("ADDR"));
            SHIFTANDADDMULTIPLIER.blocksList[4].tin.Add(new terminal("IN"));
            SHIFTANDADDMULTIPLIER.blocksList[4].tin.Add(new terminal("OUTBUS"));


            SHIFTANDADDMULTIPLIER.blocksList[3].tout.Add(new terminal("OUTBUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[3].tin.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[3].tin.Add(new terminal("BUS 32"));

            SHIFTANDADDMULTIPLIER.blocksList[5].tout.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[5].tin.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[5].tin.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[5].tin.Add(new terminal("BUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[5].tin.Add(new terminal("INBUS 32"));
            SHIFTANDADDMULTIPLIER.blocksList[5].tin.Add(new terminal("BUS SEL 2"));







        }
        public void addBuses()
        {
            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 1);
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 2);
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 4);
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 4);
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 4);
            SHIFTANDADDMULTIPLIER.busList[0].pereche = new pair(0, 5);

            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[1].pereche = new pair(1, 3);


            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[2].pereche = new pair(2, 3);


            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[3].pereche = new pair(3, 4);

            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[4].pereche = new pair(4, 5);
            SHIFTANDADDMULTIPLIER.busList[4].pereche = new pair(4, 5);
            SHIFTANDADDMULTIPLIER.busList[4].pereche = new pair(4, 5);

            SHIFTANDADDMULTIPLIER.busList.Add(new bus());
            SHIFTANDADDMULTIPLIER.busList[5].pereche = new pair(4, 1);
            SHIFTANDADDMULTIPLIER.busList[5].pereche = new pair(4, 2);

        }

        public void drawBlock() { }
        public void drawBUS() { }
        public void drawTerminal() { }
        public void drawDiagram() { }
        public void drawBlockDiagram() { }

        //gate symbols
        //equiv symbols for gates conform demorgan
        //signal names and active levels
        //active levels for pins
        //bubble to bubble logic design
        //drawing layout
        //flat schematics structure
        //hierarchical schematics structure

        //buses

        //74hct00

        //additional schematic information
        //circuit timing
        //timing diagrams
        //data signals
        //propagation delay
        //timing specifications
        //timing analysis tools


        //combnationals PLDs
        //pla
        //a 4x3 pla with 6 product terms
        //compact repr of pla
        //pla programmed witha set of 3logic equ
        //pla devices
        //pal16l8
        //simbol for ...

        //generic array logic devices
        //pla with ttl open colector gates and diode logic

        //bipolar pld circuits
        //pla with cmos logic    
        //cmos pld circuits
        //epld with floating gate mos t. AND plane
        //device programming and testing


        //decoders
        //binary decoders
        //a2to4binarydecoder

        public class quadInt
        {
            public int a;
            public int b;
            public int c;
            public int d;
            public quadInt() { }
            public quadInt(int pa, int pb, int pc, int pd)
            {
                a = pa;
                b = pb;
                c = pc;
                d = pd;
            }
        }
        public quadInt a2to4binarydecoder(int EN, int I1, int I0) {
            if (EN == 0 && I1 == 2 && I0 == 2) { return new quadInt(0,0,0,0);}
            else if (EN == 1 && I1 == 0 && I0 == 0) { return new quadInt(0, 0, 0, 0); }
            else if (EN == 1 && I1 == 0 && I0 == 1) { return new quadInt(0, 0, 0, 1); }
            else if (EN == 1 && I1 == 1 && I0 == 0) { return new quadInt(0, 0, 1, 0); }
            else if (EN == 1 && I1 == 1 && I0 == 1) { return new quadInt(1, 0, 0, 0); }
            else return new quadInt(2, 2, 2, 2); //2 = illegal x
        }

        //binary decoders
        //disk pos of a mecanical encoding disk with 3 bits
        //disk pos grade        : 0  45 90 135 180 225 270 315
        //binary decoder output : y0 y1 y3  y2 y6  y7  y5  y4

        public string mecanicalEncoderDisk(int I2, int I1, int I0)
        {
            if (I2 == 0  && I1 == 0 && I0 == 0) { return "Y0"; }
            else if (I2 == 0 && I1 == 0 && I0 == 1) { return "Y1"; }
            else if (I2 == 0 && I1 == 1 && I0 == 1) { return "Y3"; }
            else if (I2 == 0 && I1 == 1 && I0 == 0) { return "Y2"; }
            else if (I2 == 1 && I1 == 1 && I0 == 0) { return "Y6"; }
            else if (I2 == 1 && I1 == 1 && I0 == 1) { return "Y7"; }
            else if (I2 == 1 && I1 == 0 && I0 == 1) { return "Y5"; }
            else if (I2 == 1 && I1 == 0 && I0 == 0) { return "Y4"; }
            else return "2"; //2 = illegal x
        }

        //logic symbols for LS elements
        //a 3 to 8 binary decoder for gray code
        //half 74x139
        //74x139 dual 2to4 decoder
        public quadInt a74x139dual2to4decoder(int GL, int B, int A)
        {
            if (GL == 1 && B == 2 && A == 2) { return new quadInt(1,1,1,1); }
            else if (GL == 0 && B == 0 && A == 0) { return new quadInt(1, 1, 1, 0); }
            else if (GL == 0 && B == 0 && A == 1) { return new quadInt(1, 1, 0, 1); }
            else if (GL == 0 && B == 1 && A == 0) { return new quadInt(1, 0, 1, 1); }
            else if (GL == 0 && B == 1 && A == 1) { return new quadInt(0, 1, 1, 1); }
            else return new quadInt(2, 2, 2, 2); //2 = illegal x
        }

        //a 74x138 3 to 8 decoder

        public class octInt
        {
            public int a;
            public int b;
            public int c;
            public int d;
            public int e;
            public int f;
            public int g;
            public int h;

            public octInt() { }
            public octInt(int pa, int pb, int pc, int pd, int pe, int pf, int pg, int ph)
            {
                a = pa;
                b = pb;
                c = pc;
                d = pd;
                e = pe;
                f = pf;
                g = pg;
                h = ph;
            }
        }

        public octInt a74x1393to8decoder(int G1, int G2AL, int G2BL, int C, int B, int A )
        {
            if (G1 == 0 && G2AL == 2 && G2BL == 2 && C == 2 && B == 2 && A == 2) 
            { return new octInt(1, 1, 1, 1,1,1,1,1); }

            else if (G1 == 2 && G2AL == 1 && G2BL == 2 && C == 2 && B == 2 && A == 2)
            { return new octInt(1, 1, 1, 1, 1, 1, 1, 1); }

            else if (G1 == 2 && G2AL == 2 && G2BL == 1 && C == 2 && B == 2 && A == 2)
            { return new octInt(1, 1, 1, 1, 1, 1, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 0 && B == 0 && A == 0)
            { return new octInt(1, 1, 1, 1, 1, 1, 1, 0); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 0 && B == 0 && A == 1)
            { return new octInt(1, 1, 1, 1, 1, 1, 0, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 0 && B == 1 && A == 0)
            { return new octInt(1, 1, 1, 1, 1, 0, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 0 && B == 1 && A == 1)
            { return new octInt(1, 1, 1, 1, 0, 1, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 1 && B == 0 && A == 0)
            { return new octInt(1, 1, 1, 0, 1, 1, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 1 && B == 0 && A == 1)
            { return new octInt(1, 1, 0, 1, 1, 1, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 1 && B == 1 && A == 0)
            { return new octInt(1, 0, 1, 1, 1, 1, 1, 1); }

            else if (G1 == 1 && G2AL == 0 && G2BL == 0 && C == 1 && B == 1 && A == 1)
            { return new octInt(0, 1, 1, 1, 1, 1, 1, 1); }

            else return new octInt(2, 2, 2, 2,2,2,2,2); //2 = illegal x
        }


        //pagina 325
        //cascading binary decoders

        public class ODO : CMOS 
        { 
            
        
        }

        //wired logic 
        public int CMOS2xWired(CMOS C1, CMOS C2, ref int z)
        {
            //unknown
            return 0;
        }

        //multiple open drain outputs gates ODO
        //driving 2 inputs gates 
        //NODODRIVING2INPUTS
        public List<int> NODODRIVING2INPUTS(List<ODO> listOfODOGates, List<CMOS> NANDGatesOutput)
        { 
            List<int> outputs = new List<int>();
            //prelucrari ne realizate
            return outputs;       
        }


        public class NOTTSDevice
        {
            public int A;
            public int EN;

        }
        //multisource buses
        //using NOTTS
        public int MSBUSODONOTTS(ref List <NOTTSDevice> listaNOTTS, ref int DATAOUT)
        {


            return DATAOUT;
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
