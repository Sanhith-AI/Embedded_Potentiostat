﻿namespace CIFEA
{
    partial class Square
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstart = new System.Windows.Forms.TextBox();
            this.txtEstop = new System.Windows.Forms.TextBox();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.cmbCurrent = new System.Windows.Forms.ComboBox();
            this.lblEstart = new System.Windows.Forms.Label();
            this.lblEstop = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblEStep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstep = new System.Windows.Forms.ComboBox();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.lblGraph = new System.Windows.Forms.Label();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.infoSerialPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square Wave Voltammetry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47F));
            this.tableLayoutPanel1.Controls.Add(this.cmbSerialPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSerialPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtEstart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEstop, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFrequency, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurrent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEstart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEstop, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrent, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAmplitude, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFrequency, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblEStep, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstep, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAmplitude, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.infoSerialPort, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90436F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90436F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90436F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90436F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(620, 303);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 29);
            this.label14.TabIndex = 30;
            this.label14.Text = "V";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(620, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "V";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(620, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "V";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "V";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Amplitude";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "E start";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "E stop";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "E step";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Frequency";
            // 
            // txtEstart
            // 
            this.txtEstart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstart.Location = new System.Drawing.Point(279, 61);
            this.txtEstart.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstart.Name = "txtEstart";
            this.txtEstart.Size = new System.Drawing.Size(325, 35);
            this.txtEstart.TabIndex = 9;
            this.txtEstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstart_KeyPress);
            // 
            // txtEstop
            // 
            this.txtEstop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstop.Location = new System.Drawing.Point(279, 117);
            this.txtEstop.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstop.Name = "txtEstop";
            this.txtEstop.Size = new System.Drawing.Size(325, 35);
            this.txtEstop.TabIndex = 10;
            this.txtEstop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstop_KeyPress);
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "30",
            "50",
            "70",
            "90",
            "110",
            "120",
            "135",
            "150"});
            this.cmbFrequency.Location = new System.Drawing.Point(279, 362);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(325, 37);
            this.cmbFrequency.TabIndex = 14;
            this.cmbFrequency.SelectedIndexChanged += new System.EventHandler(this.cmbFrequency_SelectedIndexChanged);
            // 
            // cmbCurrent
            // 
            this.cmbCurrent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrent.FormattingEnabled = true;
            this.cmbCurrent.Items.AddRange(new object[] {
            "100 pA",
            "1 nA",
            "10 nA",
            "100 nA",
            "1 µA",
            "10 µA",
            "100 µA",
            "1 mA",
            "10 mA",
            "100 mA"});
            this.cmbCurrent.Location = new System.Drawing.Point(279, 177);
            this.cmbCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurrent.Name = "cmbCurrent";
            this.cmbCurrent.Size = new System.Drawing.Size(325, 37);
            this.cmbCurrent.TabIndex = 22;
            this.cmbCurrent.SelectedIndexChanged += new System.EventHandler(this.cmbCurrent_SelectedIndexChanged);
            // 
            // lblEstart
            // 
            this.lblEstart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstart.AutoSize = true;
            this.lblEstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstart.ForeColor = System.Drawing.Color.White;
            this.lblEstart.Location = new System.Drawing.Point(670, 66);
            this.lblEstart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstart.Name = "lblEstart";
            this.lblEstart.Size = new System.Drawing.Size(75, 25);
            this.lblEstart.TabIndex = 16;
            this.lblEstart.Text = "label10";
            // 
            // lblEstop
            // 
            this.lblEstop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstop.AutoSize = true;
            this.lblEstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstop.ForeColor = System.Drawing.Color.White;
            this.lblEstop.Location = new System.Drawing.Point(670, 122);
            this.lblEstop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstop.Name = "lblEstop";
            this.lblEstop.Size = new System.Drawing.Size(75, 25);
            this.lblEstop.TabIndex = 17;
            this.lblEstop.Text = "label11";
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(670, 183);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(75, 25);
            this.lblCurrent.TabIndex = 18;
            this.lblCurrent.Text = "label12";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmplitude.ForeColor = System.Drawing.Color.White;
            this.lblAmplitude.Location = new System.Drawing.Point(670, 305);
            this.lblAmplitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(75, 25);
            this.lblAmplitude.TabIndex = 20;
            this.lblAmplitude.Text = "label14";
            // 
            // lblFrequency
            // 
            this.lblFrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.White;
            this.lblFrequency.Location = new System.Drawing.Point(670, 368);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(75, 25);
            this.lblFrequency.TabIndex = 21;
            this.lblFrequency.Text = "label15";
            // 
            // lblEStep
            // 
            this.lblEStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEStep.AutoSize = true;
            this.lblEStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEStep.ForeColor = System.Drawing.Color.White;
            this.lblEStep.Location = new System.Drawing.Point(670, 244);
            this.lblEStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEStep.Name = "lblEStep";
            this.lblEStep.Size = new System.Drawing.Size(75, 25);
            this.lblEStep.TabIndex = 33;
            this.lblEStep.Text = "label12";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Hz";
            // 
            // cmbEstep
            // 
            this.cmbEstep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbEstep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstep.FormattingEnabled = true;
            this.cmbEstep.Items.AddRange(new object[] {
            "0.01",
            "0.02",
            "0.03",
            "0.04",
            "0.05",
            "0.06",
            "0.07",
            "0.08",
            "0.09",
            "0.1"});
            this.cmbEstep.Location = new System.Drawing.Point(279, 238);
            this.cmbEstep.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstep.Name = "cmbEstep";
            this.cmbEstep.Size = new System.Drawing.Size(325, 37);
            this.cmbEstep.TabIndex = 31;
            this.cmbEstep.SelectedIndexChanged += new System.EventHandler(this.cmbEstep_SelectedIndexChanged_1);
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmplitude.Location = new System.Drawing.Point(279, 300);
            this.txtAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.Size = new System.Drawing.Size(325, 35);
            this.txtAmplitude.TabIndex = 36;
            this.txtAmplitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmplitude_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(385, 511);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 51);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "START";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.SystemColors.HotTrack;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Format = "0.0000";
            chartArea3.AxisX.Title = "Voltage (V)";
            chartArea3.AxisX.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.LabelStyle.Format = "0.0000";
            chartArea3.AxisY.Title = "Current (µA)";
            chartArea3.AxisY.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(17, 650);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Voltage (vs) Current";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(695, 350);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ForeColor = System.Drawing.Color.White;
            this.btnSaveData.Location = new System.Drawing.Point(718, 862);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(172, 58);
            this.btnSaveData.TabIndex = 4;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraph.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGraph.Location = new System.Drawing.Point(35, 604);
            this.lblGraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(464, 32);
            this.lblGraph.TabIndex = 5;
            this.lblGraph.Text = "Graph: Square wave voltammetry";
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGraph.ForeColor = System.Drawing.Color.White;
            this.btnSaveGraph.Location = new System.Drawing.Point(718, 725);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(172, 58);
            this.btnSaveGraph.TabIndex = 6;
            this.btnSaveGraph.Text = "Save Graph";
            this.btnSaveGraph.UseVisualStyleBackColor = false;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialPort.Location = new System.Drawing.Point(100, 12);
            this.lblSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.lblSerialPort.Size = new System.Drawing.Size(175, 29);
            this.lblSerialPort.TabIndex = 37;
            this.lblSerialPort.Text = "Serial Port";
            this.lblSerialPort.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Items.AddRange(new object[] {
            "100 pA",
            "1 nA",
            "10 nA",
            "100 nA",
            "1 µA",
            "10 µA",
            "100 µA",
            "1 mA",
            "10 mA",
            "100 mA"});
            this.cmbSerialPort.Location = new System.Drawing.Point(279, 8);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(325, 37);
            this.cmbSerialPort.TabIndex = 38;
            // 
            // infoSerialPort
            // 
            this.infoSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.infoSerialPort.AutoSize = true;
            this.infoSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSerialPort.ForeColor = System.Drawing.Color.Black;
            this.infoSerialPort.Location = new System.Drawing.Point(670, 14);
            this.infoSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoSerialPort.Name = "infoSerialPort";
            this.infoSerialPort.Size = new System.Drawing.Size(182, 25);
            this.infoSerialPort.TabIndex = 39;
            this.infoSerialPort.Text = "* Select correct port";
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 875);
            this.Controls.Add(this.btnSaveGraph);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(434, 348);
            this.Name = "Square";
            this.Text = "Square";
            this.Load += new System.EventHandler(this.Square_Load);
            this.Leave += new System.EventHandler(this.Square_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstart;
        private System.Windows.Forms.TextBox txtEstop;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblEstop;
        private System.Windows.Forms.Label lblEstart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbCurrent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEstep;
        private System.Windows.Forms.Label lblEStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label infoSerialPort;
    }
}