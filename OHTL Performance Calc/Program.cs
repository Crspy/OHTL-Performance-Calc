using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OHTL_Performance_Calc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class NetworkModel
    {
        public Complex A;
        public Complex B;
        public Complex C;
        public Complex D;
    
        public NetworkModel()
        {
            A = new Complex();
            B = new Complex();
            C = new Complex();
            D = new Complex();
        }
    
    }
    public class LineParams
    {
        public Complex R;
        public Complex Xl;
        public Complex Xc;
        public double LineLength = 0.0;
    
        public LineParams()
        {
            R = new Complex();
            Xl = new Complex();
            Xc = new Complex();
        }
    
    }
    
    public enum EPowerType
    {
        Active,
        Reactive,
        Apparent
    }
    
    public enum EPhaseType
    {
        Leading,
        Lagging
    }
    
    public class ReceivingEndParams
    {
        public Complex P;
        public Complex I;
        public Complex NoLoadVoltage;
        public Complex FullLoadVoltage;
        public double PowerFactor;
    
        public double PhaseAngle =>
            PhaseType == EPhaseType.Leading ? Math.Acos(PowerFactor) : -Math.Acos(PowerFactor);
    
        public EPowerType PowerType = EPowerType.Active;
        public EPhaseType PhaseType = EPhaseType.Leading;
    
    
        public ReceivingEndParams()
        {
            P = new Complex();
            I = new Complex();
            NoLoadVoltage = new Complex();
            FullLoadVoltage = new Complex();
        }
    
    }
    
    public class OhtlParams
    {
        public Complex V;
        public Complex I;
        public double VoltReg;
        public double Efficiency;
    
        public OhtlParams()
        {
            V = new Complex();
            I = new Complex();
        }
    
    }

}
