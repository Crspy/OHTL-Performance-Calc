namespace OHTL_Performance_Calc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcButton = new System.Windows.Forms.Button();
            this.RE_PowerTB = new System.Windows.Forms.TextBox();
            this.RE_FLVoltageTB = new System.Windows.Forms.TextBox();
            this.PowerfactorTB = new System.Windows.Forms.TextBox();
            this.LineLengthTB = new System.Windows.Forms.TextBox();
            this.ResistanceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SE_VoltageTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SE_CurrentTB = new System.Windows.Forms.TextBox();
            this.VoltageRegTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EfficiencyTB = new System.Windows.Forms.TextBox();
            this.ActiveRB = new System.Windows.Forms.RadioButton();
            this.ReactiveRB = new System.Windows.Forms.RadioButton();
            this.ApparentRB = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.InductanceTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CapacitanceTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PowerUnitLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.FreqTB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.LeadingRB = new System.Windows.Forms.RadioButton();
            this.LaggingRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SE_PhVoltage_PolarRB = new System.Windows.Forms.RadioButton();
            this.SE_PhVoltage_RectRB = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SE_LineVoltageTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SE_LineVoltage_PolarRB = new System.Windows.Forms.RadioButton();
            this.SE_LineVoltage_RectRB = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SE_Current_PolarRB = new System.Windows.Forms.RadioButton();
            this.SE_Current_RectRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(434, 420);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // RE_PowerTB
            // 
            this.RE_PowerTB.Location = new System.Drawing.Point(15, 50);
            this.RE_PowerTB.Name = "RE_PowerTB";
            this.RE_PowerTB.Size = new System.Drawing.Size(142, 20);
            this.RE_PowerTB.TabIndex = 1;
            this.RE_PowerTB.Text = "900000.0";
            // 
            // RE_FLVoltageTB
            // 
            this.RE_FLVoltageTB.Location = new System.Drawing.Point(15, 127);
            this.RE_FLVoltageTB.Name = "RE_FLVoltageTB";
            this.RE_FLVoltageTB.Size = new System.Drawing.Size(142, 20);
            this.RE_FLVoltageTB.TabIndex = 2;
            this.RE_FLVoltageTB.Text = "500.0";
            // 
            // PowerfactorTB
            // 
            this.PowerfactorTB.Location = new System.Drawing.Point(15, 177);
            this.PowerfactorTB.Name = "PowerfactorTB";
            this.PowerfactorTB.Size = new System.Drawing.Size(142, 20);
            this.PowerfactorTB.TabIndex = 3;
            this.PowerfactorTB.Text = "0.8";
            // 
            // LineLengthTB
            // 
            this.LineLengthTB.Location = new System.Drawing.Point(15, 258);
            this.LineLengthTB.Name = "LineLengthTB";
            this.LineLengthTB.Size = new System.Drawing.Size(142, 20);
            this.LineLengthTB.TabIndex = 4;
            this.LineLengthTB.Text = "400";
            // 
            // ResistanceTB
            // 
            this.ResistanceTB.Location = new System.Drawing.Point(15, 305);
            this.ResistanceTB.Name = "ResistanceTB";
            this.ResistanceTB.Size = new System.Drawing.Size(142, 20);
            this.ResistanceTB.TabIndex = 5;
            this.ResistanceTB.Text = "0.0125";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Receiving End Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Receiving End Phase Voltage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Receiving End Power Factor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transmission Line Length";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R (per phase per unit length)";
            // 
            // SE_VoltageTB
            // 
            this.SE_VoltageTB.BackColor = System.Drawing.SystemColors.Window;
            this.SE_VoltageTB.Location = new System.Drawing.Point(434, 64);
            this.SE_VoltageTB.Name = "SE_VoltageTB";
            this.SE_VoltageTB.ReadOnly = true;
            this.SE_VoltageTB.Size = new System.Drawing.Size(142, 20);
            this.SE_VoltageTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "OHTL Performance:";
            // 
            // SE_CurrentTB
            // 
            this.SE_CurrentTB.BackColor = System.Drawing.SystemColors.Window;
            this.SE_CurrentTB.Location = new System.Drawing.Point(434, 216);
            this.SE_CurrentTB.Name = "SE_CurrentTB";
            this.SE_CurrentTB.ReadOnly = true;
            this.SE_CurrentTB.Size = new System.Drawing.Size(142, 20);
            this.SE_CurrentTB.TabIndex = 14;
            // 
            // VoltageRegTB
            // 
            this.VoltageRegTB.BackColor = System.Drawing.SystemColors.Window;
            this.VoltageRegTB.Location = new System.Drawing.Point(434, 305);
            this.VoltageRegTB.Name = "VoltageRegTB";
            this.VoltageRegTB.ReadOnly = true;
            this.VoltageRegTB.Size = new System.Drawing.Size(116, 20);
            this.VoltageRegTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sending End Current";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sending End Phase Voltage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Voltage Regulation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Transmission Efficiency";
            // 
            // EfficiencyTB
            // 
            this.EfficiencyTB.BackColor = System.Drawing.SystemColors.Window;
            this.EfficiencyTB.Location = new System.Drawing.Point(434, 353);
            this.EfficiencyTB.Name = "EfficiencyTB";
            this.EfficiencyTB.ReadOnly = true;
            this.EfficiencyTB.Size = new System.Drawing.Size(116, 20);
            this.EfficiencyTB.TabIndex = 19;
            // 
            // ActiveRB
            // 
            this.ActiveRB.AutoSize = true;
            this.ActiveRB.Checked = true;
            this.ActiveRB.Location = new System.Drawing.Point(0, 0);
            this.ActiveRB.Name = "ActiveRB";
            this.ActiveRB.Size = new System.Drawing.Size(55, 17);
            this.ActiveRB.TabIndex = 21;
            this.ActiveRB.TabStop = true;
            this.ActiveRB.Text = "Active";
            this.ActiveRB.UseVisualStyleBackColor = true;
            this.ActiveRB.CheckedChanged += new System.EventHandler(this.ActiveRB_CheckedChanged);
            // 
            // ReactiveRB
            // 
            this.ReactiveRB.AutoSize = true;
            this.ReactiveRB.Location = new System.Drawing.Point(61, 0);
            this.ReactiveRB.Name = "ReactiveRB";
            this.ReactiveRB.Size = new System.Drawing.Size(68, 17);
            this.ReactiveRB.TabIndex = 22;
            this.ReactiveRB.Text = "Reactive";
            this.ReactiveRB.UseVisualStyleBackColor = true;
            this.ReactiveRB.CheckedChanged += new System.EventHandler(this.ReactiveRB_CheckedChanged);
            // 
            // ApparentRB
            // 
            this.ApparentRB.AutoSize = true;
            this.ApparentRB.Location = new System.Drawing.Point(132, 0);
            this.ApparentRB.Name = "ApparentRB";
            this.ApparentRB.Size = new System.Drawing.Size(68, 17);
            this.ApparentRB.TabIndex = 23;
            this.ApparentRB.Text = "Apparent";
            this.ApparentRB.UseVisualStyleBackColor = true;
            this.ApparentRB.CheckedChanged += new System.EventHandler(this.ApparentRB_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "L (per unit length)";
            // 
            // InductanceTB
            // 
            this.InductanceTB.Location = new System.Drawing.Point(15, 353);
            this.InductanceTB.Name = "InductanceTB";
            this.InductanceTB.Size = new System.Drawing.Size(142, 20);
            this.InductanceTB.TabIndex = 24;
            this.InductanceTB.Text = "0.35";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "C (per unit length)";
            // 
            // CapacitanceTB
            // 
            this.CapacitanceTB.Location = new System.Drawing.Point(15, 402);
            this.CapacitanceTB.Name = "CapacitanceTB";
            this.CapacitanceTB.Size = new System.Drawing.Size(142, 20);
            this.CapacitanceTB.TabIndex = 26;
            this.CapacitanceTB.Text = "0.005";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "μF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "mH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "ohm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(160, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "KM";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(160, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "KV";
            // 
            // PowerUnitLabel
            // 
            this.PowerUnitLabel.AutoSize = true;
            this.PowerUnitLabel.Location = new System.Drawing.Point(160, 53);
            this.PowerUnitLabel.Name = "PowerUnitLabel";
            this.PowerUnitLabel.Size = new System.Drawing.Size(25, 13);
            this.PowerUnitLabel.TabIndex = 33;
            this.PowerUnitLabel.Text = "KW";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(582, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "KV";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(582, 219);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Ampere";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(556, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "%";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(556, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "%";
            // 
            // FreqTB
            // 
            this.FreqTB.Location = new System.Drawing.Point(15, 446);
            this.FreqTB.Name = "FreqTB";
            this.FreqTB.Size = new System.Drawing.Size(142, 20);
            this.FreqTB.TabIndex = 44;
            this.FreqTB.Text = "60.0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 430);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Frequency";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(160, 449);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Hz";
            // 
            // LeadingRB
            // 
            this.LeadingRB.AutoSize = true;
            this.LeadingRB.Location = new System.Drawing.Point(3, 2);
            this.LeadingRB.Name = "LeadingRB";
            this.LeadingRB.Size = new System.Drawing.Size(63, 17);
            this.LeadingRB.TabIndex = 47;
            this.LeadingRB.Text = "Leading";
            this.LeadingRB.UseVisualStyleBackColor = true;
            // 
            // LaggingRB
            // 
            this.LaggingRB.AutoSize = true;
            this.LaggingRB.Checked = true;
            this.LaggingRB.Location = new System.Drawing.Point(66, 2);
            this.LaggingRB.Name = "LaggingRB";
            this.LaggingRB.Size = new System.Drawing.Size(63, 17);
            this.LaggingRB.TabIndex = 48;
            this.LaggingRB.TabStop = true;
            this.LaggingRB.Text = "Lagging";
            this.LaggingRB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LaggingRB);
            this.panel1.Controls.Add(this.LeadingRB);
            this.panel1.Location = new System.Drawing.Point(15, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 20);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ActiveRB);
            this.panel2.Controls.Add(this.ReactiveRB);
            this.panel2.Controls.Add(this.ApparentRB);
            this.panel2.Location = new System.Drawing.Point(15, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SE_PhVoltage_PolarRB);
            this.panel3.Controls.Add(this.SE_PhVoltage_RectRB);
            this.panel3.Location = new System.Drawing.Point(434, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 20);
            this.panel3.TabIndex = 51;
            // 
            // SE_PhVoltage_PolarRB
            // 
            this.SE_PhVoltage_PolarRB.AutoSize = true;
            this.SE_PhVoltage_PolarRB.Checked = true;
            this.SE_PhVoltage_PolarRB.Location = new System.Drawing.Point(89, 2);
            this.SE_PhVoltage_PolarRB.Name = "SE_PhVoltage_PolarRB";
            this.SE_PhVoltage_PolarRB.Size = new System.Drawing.Size(49, 17);
            this.SE_PhVoltage_PolarRB.TabIndex = 48;
            this.SE_PhVoltage_PolarRB.TabStop = true;
            this.SE_PhVoltage_PolarRB.Text = "Polar";
            this.SE_PhVoltage_PolarRB.UseVisualStyleBackColor = true;
            // 
            // SE_PhVoltage_RectRB
            // 
            this.SE_PhVoltage_RectRB.AutoSize = true;
            this.SE_PhVoltage_RectRB.Location = new System.Drawing.Point(3, 2);
            this.SE_PhVoltage_RectRB.Name = "SE_PhVoltage_RectRB";
            this.SE_PhVoltage_RectRB.Size = new System.Drawing.Size(83, 17);
            this.SE_PhVoltage_RectRB.TabIndex = 47;
            this.SE_PhVoltage_RectRB.Text = "Rectangular";
            this.SE_PhVoltage_RectRB.UseVisualStyleBackColor = true;
            this.SE_PhVoltage_RectRB.CheckedChanged += new System.EventHandler(this.SE_PhVoltage_RectRB_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(582, 142);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "KV";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(431, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(130, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Sending End Line Voltage";
            // 
            // SE_LineVoltageTB
            // 
            this.SE_LineVoltageTB.BackColor = System.Drawing.SystemColors.Window;
            this.SE_LineVoltageTB.Location = new System.Drawing.Point(434, 139);
            this.SE_LineVoltageTB.Name = "SE_LineVoltageTB";
            this.SE_LineVoltageTB.ReadOnly = true;
            this.SE_LineVoltageTB.Size = new System.Drawing.Size(142, 20);
            this.SE_LineVoltageTB.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SE_LineVoltage_PolarRB);
            this.panel4.Controls.Add(this.SE_LineVoltage_RectRB);
            this.panel4.Location = new System.Drawing.Point(434, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 20);
            this.panel4.TabIndex = 55;
            // 
            // SE_LineVoltage_PolarRB
            // 
            this.SE_LineVoltage_PolarRB.AutoSize = true;
            this.SE_LineVoltage_PolarRB.Checked = true;
            this.SE_LineVoltage_PolarRB.Location = new System.Drawing.Point(89, 2);
            this.SE_LineVoltage_PolarRB.Name = "SE_LineVoltage_PolarRB";
            this.SE_LineVoltage_PolarRB.Size = new System.Drawing.Size(49, 17);
            this.SE_LineVoltage_PolarRB.TabIndex = 48;
            this.SE_LineVoltage_PolarRB.TabStop = true;
            this.SE_LineVoltage_PolarRB.Text = "Polar";
            this.SE_LineVoltage_PolarRB.UseVisualStyleBackColor = true;
            // 
            // SE_LineVoltage_RectRB
            // 
            this.SE_LineVoltage_RectRB.AutoSize = true;
            this.SE_LineVoltage_RectRB.Location = new System.Drawing.Point(3, 2);
            this.SE_LineVoltage_RectRB.Name = "SE_LineVoltage_RectRB";
            this.SE_LineVoltage_RectRB.Size = new System.Drawing.Size(83, 17);
            this.SE_LineVoltage_RectRB.TabIndex = 47;
            this.SE_LineVoltage_RectRB.Text = "Rectangular";
            this.SE_LineVoltage_RectRB.UseVisualStyleBackColor = true;
            this.SE_LineVoltage_RectRB.CheckedChanged += new System.EventHandler(this.SE_LineVoltage_RectRB_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SE_Current_PolarRB);
            this.panel5.Controls.Add(this.SE_Current_RectRB);
            this.panel5.Location = new System.Drawing.Point(434, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 20);
            this.panel5.TabIndex = 56;
            // 
            // SE_Current_PolarRB
            // 
            this.SE_Current_PolarRB.AutoSize = true;
            this.SE_Current_PolarRB.Checked = true;
            this.SE_Current_PolarRB.Location = new System.Drawing.Point(89, 2);
            this.SE_Current_PolarRB.Name = "SE_Current_PolarRB";
            this.SE_Current_PolarRB.Size = new System.Drawing.Size(49, 17);
            this.SE_Current_PolarRB.TabIndex = 48;
            this.SE_Current_PolarRB.TabStop = true;
            this.SE_Current_PolarRB.Text = "Polar";
            this.SE_Current_PolarRB.UseVisualStyleBackColor = true;
            // 
            // SE_Current_RectRB
            // 
            this.SE_Current_RectRB.AutoSize = true;
            this.SE_Current_RectRB.Location = new System.Drawing.Point(3, 2);
            this.SE_Current_RectRB.Name = "SE_Current_RectRB";
            this.SE_Current_RectRB.Size = new System.Drawing.Size(83, 17);
            this.SE_Current_RectRB.TabIndex = 47;
            this.SE_Current_RectRB.Text = "Rectangular";
            this.SE_Current_RectRB.UseVisualStyleBackColor = true;
            this.SE_Current_RectRB.CheckedChanged += new System.EventHandler(this.SE_Current_RectRB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.SE_LineVoltageTB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.FreqTB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.PowerUnitLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CapacitanceTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.InductanceTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EfficiencyTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VoltageRegTB);
            this.Controls.Add(this.SE_CurrentTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SE_VoltageTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResistanceTB);
            this.Controls.Add(this.LineLengthTB);
            this.Controls.Add(this.PowerfactorTB);
            this.Controls.Add(this.RE_FLVoltageTB);
            this.Controls.Add(this.RE_PowerTB);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "OHTL Performance Calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox RE_PowerTB;
        private System.Windows.Forms.TextBox RE_FLVoltageTB;
        private System.Windows.Forms.TextBox PowerfactorTB;
        private System.Windows.Forms.TextBox LineLengthTB;
        private System.Windows.Forms.TextBox ResistanceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SE_VoltageTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SE_CurrentTB;
        private System.Windows.Forms.TextBox VoltageRegTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EfficiencyTB;
        private System.Windows.Forms.RadioButton ActiveRB;
        private System.Windows.Forms.RadioButton ReactiveRB;
        private System.Windows.Forms.RadioButton ApparentRB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox InductanceTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CapacitanceTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label PowerUnitLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox FreqTB;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton LeadingRB;
        private System.Windows.Forms.RadioButton LaggingRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton SE_PhVoltage_PolarRB;
        private System.Windows.Forms.RadioButton SE_PhVoltage_RectRB;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SE_LineVoltageTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton SE_LineVoltage_PolarRB;
        private System.Windows.Forms.RadioButton SE_LineVoltage_RectRB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton SE_Current_PolarRB;
        private System.Windows.Forms.RadioButton SE_Current_RectRB;
    }
}

