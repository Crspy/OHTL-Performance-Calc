using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace OHTL_Performance_Calc
{
    public partial class Form1 : Form
    {
        private readonly NetworkModel model;
        private readonly LineParams lp;
        private readonly OhtlParams ohtl;
        private readonly ReceivingEndParams REP;
        private double _frequency = 60.0;
        private double AngularFreq => 2 * Math.PI * _frequency;

        public Form1()
        {
            InitializeComponent();
            model = new NetworkModel();
            lp = new LineParams();
            REP = new ReceivingEndParams();
            ohtl = new OhtlParams();
        }

        private void CalcShortModel()
        {
            Complex Z = new Complex();
            Z = (lp.R + lp.Xl) * lp.LineLength;
            model.A = new Complex(1.0, 0.0);
            model.B = Z;
            model.C = new Complex(0.0, 0.0);
            model.D = new Complex(1.0, 0.0);

            Complex lineVoltage = REP.FullLoadVoltage / Math.Sqrt(3);
            double lineCurrentMag = REP.P.Real / (REP.PowerFactor * REP.FullLoadVoltage.Magnitude * Math.Sqrt(3));


            REP.I = Complex.FromPolarCoordinates(lineCurrentMag, REP.PhaseAngle);



            ohtl.V = (model.A * lineVoltage) + (model.B * REP.I);
            ohtl.I = (model.C * lineVoltage) + (model.D * REP.I);


            ohtl.VoltReg = ((ohtl.V.Magnitude / lineVoltage.Magnitude) - 1) * 100;

            Complex SE_Power = new Complex();
            SE_Power = 3 * ohtl.V * Complex.Conjugate(ohtl.I);
            ohtl.Efficiency = (REP.P.Real / SE_Power.Real) * 100;
        }

        private void CalcMeduimModel()
        {
            Complex Z = new Complex();
            Z = (lp.R + lp.Xl) * lp.LineLength;
            Complex Y = (1 / lp.Xc) * lp.LineLength;



            model.A = 1 + ((Z * Y) / 2);
            model.B = Z;
            model.C = Y * (1 + (Z * Y / 4));
            model.D = model.A;

            Complex lineVoltage = REP.FullLoadVoltage / Math.Sqrt(3);
            double lineCurrentMag = REP.P.Real / (REP.PowerFactor * REP.FullLoadVoltage.Magnitude * Math.Sqrt(3));

            REP.I = Complex.FromPolarCoordinates(lineCurrentMag, REP.PhaseAngle);

            ohtl.V = (model.A * lineVoltage) + (model.B * REP.I);
            ohtl.I = (model.C * lineVoltage) + (model.D * REP.I);

            ohtl.VoltReg = ((ohtl.V.Magnitude / model.A.Magnitude / lineVoltage.Magnitude) - 1) * 100;

            Complex SE_Power = new Complex();
            SE_Power = 3 * ohtl.V * Complex.Conjugate(ohtl.I);
            ohtl.Efficiency = (REP.P.Real / SE_Power.Real) * 100;
        }

        private void CalcLongModel()
        {
            double stageLength = 0;
            int stageNum = 0;

            for (int i = 2; ; ++i)
            {
                stageLength = lp.LineLength / i;
                if (stageLength <= 250.0)
                {
                    stageNum = i;
                    break;
                }
            }


            Complex Z = new Complex();
            Z = (lp.R + lp.Xl) * stageLength;
            Complex Y = (1 / lp.Xc) * stageLength;


            model.A = 1 + ((Z * Y) / 2);
            model.B = Z;
            model.C = Y * (1 + (Z * Y / 4));
            model.D = model.A;

            Matrix2X2 mat = new Matrix2X2(model.A, model.B, model.C, model.D);
            for (int i = 0; i < (stageNum - 1); ++i)
            {
                mat *= mat;
            }
            model.A = mat.M00;
            model.B = mat.M01;
            model.C = mat.M10;
            model.D = mat.M11;

            Complex lineVoltage = REP.FullLoadVoltage / Math.Sqrt(3);
            double lineCurrentMag = REP.P.Real / (REP.PowerFactor * REP.FullLoadVoltage.Magnitude * Math.Sqrt(3));

            REP.I = Complex.FromPolarCoordinates(lineCurrentMag, REP.PhaseAngle);

            ohtl.V = (model.A * lineVoltage) + (model.B * REP.I);
            ohtl.I = (model.C * lineVoltage) + (model.D * REP.I);


            ohtl.VoltReg = ((ohtl.V.Magnitude / model.A.Magnitude / lineVoltage.Magnitude) - 1) * 100;

            Complex SE_Power = new Complex();
            SE_Power = 3 * ohtl.V * Complex.Conjugate(ohtl.I);
            ohtl.Efficiency = (REP.P.Real / SE_Power.Real) * 100;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            ApplyAllTextBoxChanges();
            bool printOutput = true;
            if (lp.LineLength < 80.0)
            {
                CalcShortModel();
            }
            else if (lp.LineLength >= 80.0
                     && lp.LineLength <= 250.0)
            {
                CalcMeduimModel();
            }
            else if (lp.LineLength > 250.0)
            {
                CalcLongModel();
            }
            else
            {
                printOutput = false;
            }

            if (printOutput)
            {
                Complex seVoltage = ohtl.V / 1000.0;// convert to KV
                seVoltage = new Complex(Math.Round(seVoltage.Real, 3), Math.Round(seVoltage.Imaginary, 3));
                SE_VoltageTB.Text = SE_PhVoltage_RectRB.Checked ? seVoltage.ToString() : ComplexToPolarString(seVoltage);

                Complex seLineVoltage = ohtl.V / 1000.0 * Math.Sqrt(3); // obtain line voltage in KV
                seLineVoltage = new Complex(Math.Round(seLineVoltage.Real, 3), Math.Round(seLineVoltage.Imaginary, 3));
                SE_LineVoltageTB.Text = SE_LineVoltage_RectRB.Checked ? seLineVoltage.ToString() : ComplexToPolarString(seLineVoltage);

                Complex seCurrent = new Complex(Math.Round(ohtl.I.Real, 3), Math.Round(ohtl.I.Imaginary, 3));
                SE_CurrentTB.Text = SE_Current_RectRB.Checked ? seCurrent.ToString() : ComplexToPolarString(seCurrent);

                VoltageRegTB.Text = Math.Round(ohtl.VoltReg, 3).ToString();
                EfficiencyTB.Text = Math.Round(ohtl.Efficiency, 3).ToString();
            }


        }

        private string ComplexToPolarString(Complex cmplxNum)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:f3} ∠{1:f3}", cmplxNum.Magnitude, cmplxNum.Phase);
            return sb.ToString();
        }


        private void ApplyAllTextBoxChanges()
        {
            lp.R = new Complex(double.Parse(ResistanceTB.Text), 0.0);

            lp.Xl = new Complex(0.0, AngularFreq * double.Parse(InductanceTB.Text) / 1000.0);

            lp.Xc = new Complex(0.0, -1 / (AngularFreq * double.Parse(CapacitanceTB.Text) / 1000000.0));

            lp.LineLength = double.Parse(LineLengthTB.Text);


            REP.FullLoadVoltage = Complex.FromPolarCoordinates(double.Parse(RE_FLVoltageTB.Text) * 1000.0, 0.0);

            REP.PowerFactor = double.Parse(PowerfactorTB.Text);

            _frequency = double.Parse(FreqTB.Text);

            switch (REP.PowerType)
            {
                case EPowerType.Active:
                    {
                        double tanTheta = Math.Tan(REP.PhaseAngle);
                        double active = double.Parse(RE_PowerTB.Text) * 1000.0;
                        REP.P = new Complex(active, active * tanTheta);
                        break;
                    }
                case EPowerType.Reactive:
                    {
                        double tanTheta = Math.Tan(REP.PhaseAngle);
                        double reactive = double.Parse(RE_PowerTB.Text) * 1000.0;
                        REP.P = new Complex(reactive / tanTheta, reactive);
                        break;
                    }
                case EPowerType.Apparent:
                    {
                        double sinTheta = Math.Sin(REP.PhaseAngle);
                        double apparent = double.Parse(RE_PowerTB.Text) * 1000.0;
                        REP.P = new Complex(apparent * REP.PowerFactor, sinTheta * REP.PowerFactor);
                        break;
                    }
            }

            REP.PhaseType = LeadingRB.Checked ? EPhaseType.Leading : EPhaseType.Lagging;
        }

        private void ActiveRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveRB.Checked)
            {
                PowerUnitLabel.Text = @"KW";
                REP.PowerType = EPowerType.Active;
            }
        }

        private void ReactiveRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReactiveRB.Checked)
            {
                PowerUnitLabel.Text = @"KVAR";
                REP.PowerType = EPowerType.Reactive;
            }
        }

        private void ApparentRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ApparentRB.Checked)
            {
                PowerUnitLabel.Text = @"KVA";
                REP.PowerType = EPowerType.Apparent;
            }
        }

        private void SE_PhVoltage_RectRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SE_VoltageTB.Text.Length > 0)
            {
                Complex seVoltage = ohtl.V / 1000.0;
                seVoltage = new Complex(Math.Round(seVoltage.Real, 3), Math.Round(seVoltage.Imaginary, 3));
                SE_VoltageTB.Text = SE_PhVoltage_RectRB.Checked ? seVoltage.ToString() : ComplexToPolarString(seVoltage);
            }
        }

        private void SE_LineVoltage_RectRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SE_LineVoltageTB.Text.Length > 0)
            {
                Complex seLineVoltage = ohtl.V / 1000.0 * Math.Sqrt(3); // obtain line voltage in KV
                seLineVoltage = new Complex(Math.Round(seLineVoltage.Real, 3), Math.Round(seLineVoltage.Imaginary, 3));
                SE_LineVoltageTB.Text = SE_LineVoltage_RectRB.Checked ? seLineVoltage.ToString() : ComplexToPolarString(seLineVoltage);
            }
        }

        private void SE_Current_RectRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SE_CurrentTB.Text.Length > 0)
            {
                Complex seCurrent = new Complex(Math.Round(ohtl.I.Real, 3), Math.Round(ohtl.I.Imaginary, 3));
                SE_CurrentTB.Text = SE_Current_RectRB.Checked ? seCurrent.ToString() : ComplexToPolarString(seCurrent);
            }
        }
    }
}
