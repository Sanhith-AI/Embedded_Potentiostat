namespace CIFEA
{
    partial class Impedance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFrequencytype = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCurrent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEdc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFrequencytype = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblEac = new System.Windows.Forms.Label();
            this.lblEdc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScantype = new System.Windows.Forms.TextBox();
            this.cmbEac = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.infoSerialPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMinfrequency = new System.Windows.Forms.ComboBox();
            this.lblMinfrequency = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMaxfrequency = new System.Windows.Forms.ComboBox();
            this.lblMaxfrequency = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraph = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impedance Spectroscopy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.47675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.572577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47059F));
            this.tableLayoutPanel1.Controls.Add(this.cmbSerialPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFrequencytype, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurrent, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEdc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFrequencytype, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrent, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEac, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEdc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtScantype, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbEac, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSerialPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoSerialPort, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 76);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 328);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbSerialPort.Location = new System.Drawing.Point(279, 8);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(323, 37);
            this.cmbSerialPort.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label6.Size = new System.Drawing.Size(227, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Frequency type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "E ac";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "E dc";
            // 
            // cmbFrequencytype
            // 
            this.cmbFrequencytype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFrequencytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrequencytype.FormattingEnabled = true;
            this.cmbFrequencytype.Items.AddRange(new object[] {
            "Fixed",
            "Scan"});
            this.cmbFrequencytype.Location = new System.Drawing.Point(279, 280);
            this.cmbFrequencytype.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrequencytype.Name = "cmbFrequencytype";
            this.cmbFrequencytype.Size = new System.Drawing.Size(323, 37);
            this.cmbFrequencytype.TabIndex = 34;
            this.cmbFrequencytype.SelectedIndexChanged += new System.EventHandler(this.cmbFrequencytype_SelectedIndexChanged);
            this.cmbFrequencytype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFrequencytype_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(620, 284);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "V";
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
            this.cmbCurrent.Location = new System.Drawing.Point(279, 224);
            this.cmbCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurrent.Name = "cmbCurrent";
            this.cmbCurrent.Size = new System.Drawing.Size(323, 37);
            this.cmbCurrent.TabIndex = 22;
            this.cmbCurrent.SelectedIndexChanged += new System.EventHandler(this.cmbCurrent_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(620, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 54);
            this.label11.TabIndex = 27;
            this.label11.Text = "mV";
            // 
            // txtEdc
            // 
            this.txtEdc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdc.Location = new System.Drawing.Point(279, 117);
            this.txtEdc.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdc.Name = "txtEdc";
            this.txtEdc.ReadOnly = true;
            this.txtEdc.Size = new System.Drawing.Size(323, 35);
            this.txtEdc.TabIndex = 9;
            this.txtEdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdc_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "V";
            // 
            // lblFrequencytype
            // 
            this.lblFrequencytype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFrequencytype.AutoSize = true;
            this.lblFrequencytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequencytype.ForeColor = System.Drawing.Color.White;
            this.lblFrequencytype.Location = new System.Drawing.Point(670, 286);
            this.lblFrequencytype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequencytype.Name = "lblFrequencytype";
            this.lblFrequencytype.Size = new System.Drawing.Size(75, 25);
            this.lblFrequencytype.TabIndex = 33;
            this.lblFrequencytype.Text = "label12";
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(670, 230);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(75, 25);
            this.lblCurrent.TabIndex = 18;
            this.lblCurrent.Text = "label12";
            // 
            // lblEac
            // 
            this.lblEac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEac.AutoSize = true;
            this.lblEac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEac.ForeColor = System.Drawing.Color.White;
            this.lblEac.Location = new System.Drawing.Point(670, 176);
            this.lblEac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEac.Name = "lblEac";
            this.lblEac.Size = new System.Drawing.Size(75, 25);
            this.lblEac.TabIndex = 17;
            this.lblEac.Text = "label11";
            // 
            // lblEdc
            // 
            this.lblEdc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEdc.AutoSize = true;
            this.lblEdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdc.ForeColor = System.Drawing.Color.White;
            this.lblEdc.Location = new System.Drawing.Point(670, 122);
            this.lblEdc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdc.Name = "lblEdc";
            this.lblEdc.Size = new System.Drawing.Size(75, 25);
            this.lblEdc.TabIndex = 16;
            this.lblEdc.Text = "label10";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label9.Size = new System.Drawing.Size(167, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "Scan type";
            // 
            // txtScantype
            // 
            this.txtScantype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtScantype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScantype.Location = new System.Drawing.Point(279, 63);
            this.txtScantype.Margin = new System.Windows.Forms.Padding(2);
            this.txtScantype.Name = "txtScantype";
            this.txtScantype.ReadOnly = true;
            this.txtScantype.Size = new System.Drawing.Size(323, 35);
            this.txtScantype.TabIndex = 37;
            // 
            // cmbEac
            // 
            this.cmbEac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbEac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEac.FormattingEnabled = true;
            this.cmbEac.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbEac.Location = new System.Drawing.Point(279, 170);
            this.cmbEac.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEac.Name = "cmbEac";
            this.cmbEac.Size = new System.Drawing.Size(323, 37);
            this.cmbEac.TabIndex = 38;
            this.cmbEac.SelectedIndexChanged += new System.EventHandler(this.cmbEac_SelectedIndexChanged);
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
            this.lblSerialPort.TabIndex = 40;
            this.lblSerialPort.Text = "Serial Port";
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
            this.infoSerialPort.TabIndex = 42;
            this.infoSerialPort.Text = "* Select correct port";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Hz";
            // 
            // lblFrequency
            // 
            this.lblFrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.White;
            this.lblFrequency.Location = new System.Drawing.Point(670, 14);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(75, 25);
            this.lblFrequency.TabIndex = 21;
            this.lblFrequency.Text = "label15";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Frequency";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label7.Size = new System.Drawing.Size(218, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Min. frequency";
            // 
            // cmbMinfrequency
            // 
            this.cmbMinfrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbMinfrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinfrequency.FormattingEnabled = true;
            this.cmbMinfrequency.Items.AddRange(new object[] {
            "1 Hz",
            "10 Hz",
            "100 Hz",
            "1 kHz",
            "10 kHz"});
            this.cmbMinfrequency.Location = new System.Drawing.Point(279, 8);
            this.cmbMinfrequency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMinfrequency.Name = "cmbMinfrequency";
            this.cmbMinfrequency.Size = new System.Drawing.Size(323, 37);
            this.cmbMinfrequency.TabIndex = 31;
            this.cmbMinfrequency.SelectedIndexChanged += new System.EventHandler(this.cmbMinfrequency_SelectedIndexChanged);
            // 
            // lblMinfrequency
            // 
            this.lblMinfrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMinfrequency.AutoSize = true;
            this.lblMinfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinfrequency.ForeColor = System.Drawing.Color.White;
            this.lblMinfrequency.Location = new System.Drawing.Point(670, 14);
            this.lblMinfrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinfrequency.Name = "lblMinfrequency";
            this.lblMinfrequency.Size = new System.Drawing.Size(75, 25);
            this.lblMinfrequency.TabIndex = 20;
            this.lblMinfrequency.Text = "label14";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(391, 580);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 51);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "START";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(52, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label12.Size = new System.Drawing.Size(223, 29);
            this.label12.TabIndex = 39;
            this.label12.Text = "Max. frequency";
            // 
            // cmbMaxfrequency
            // 
            this.cmbMaxfrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbMaxfrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaxfrequency.FormattingEnabled = true;
            this.cmbMaxfrequency.Items.AddRange(new object[] {
            "10 kHz"});
            this.cmbMaxfrequency.Location = new System.Drawing.Point(279, 62);
            this.cmbMaxfrequency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaxfrequency.Name = "cmbMaxfrequency";
            this.cmbMaxfrequency.Size = new System.Drawing.Size(323, 37);
            this.cmbMaxfrequency.TabIndex = 40;
            this.cmbMaxfrequency.SelectedIndexChanged += new System.EventHandler(this.cmbMaxfrequency_SelectedIndexChanged);
            // 
            // lblMaxfrequency
            // 
            this.lblMaxfrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaxfrequency.AutoSize = true;
            this.lblMaxfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxfrequency.ForeColor = System.Drawing.Color.White;
            this.lblMaxfrequency.Location = new System.Drawing.Point(670, 68);
            this.lblMaxfrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxfrequency.Name = "lblMaxfrequency";
            this.lblMaxfrequency.Size = new System.Drawing.Size(75, 25);
            this.lblMaxfrequency.TabIndex = 41;
            this.lblMaxfrequency.Text = "label14";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFrequency, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFrequency, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 403);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(911, 52);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtFrequency
            // 
            this.txtFrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequency.Location = new System.Drawing.Point(279, 9);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(323, 35);
            this.txtFrequency.TabIndex = 36;
            this.txtFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrequency_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbMinfrequency, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMinfrequency, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbMaxfrequency, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblMaxfrequency, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 454);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(911, 108);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.SystemColors.HotTrack;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.AxisX.Title = "Log(F) (Hz)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "0.00";
            chartArea1.AxisY.Title = "Phase (Degrees)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 701);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Bode plot";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(463, 308);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.SystemColors.HotTrack;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 2;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Format = "0.00";
            chartArea2.AxisX.Title = "Log(F) (Hz)";
            chartArea2.AxisX.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "0.00";
            chartArea2.AxisY.Title = "|Z| (Ohm)";
            chartArea2.AxisY.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(491, 701);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Bode plot";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(438, 308);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraph.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGraph.Location = new System.Drawing.Point(33, 644);
            this.lblGraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(451, 32);
            this.lblGraph.TabIndex = 7;
            this.lblGraph.Text = "Graph: Impedance spectroscopy";
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ForeColor = System.Drawing.Color.White;
            this.btnSaveData.Location = new System.Drawing.Point(526, 1020);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(196, 50);
            this.btnSaveData.TabIndex = 8;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGraph.ForeColor = System.Drawing.Color.White;
            this.btnSaveGraph.Location = new System.Drawing.Point(250, 1020);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(196, 50);
            this.btnSaveGraph.TabIndex = 9;
            this.btnSaveGraph.Text = "Save Graph";
            this.btnSaveGraph.UseVisualStyleBackColor = false;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // Impedance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 1020);
            this.Controls.Add(this.btnSaveGraph);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(434, 348);
            this.Name = "Impedance";
            this.Text = "Impedance";
            this.Load += new System.EventHandler(this.Impedance_Load);
            this.Leave += new System.EventHandler(this.Impedance_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.TextBox txtEdc;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblMinfrequency;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblEac;
        private System.Windows.Forms.Label lblEdc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbCurrent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMinfrequency;
        private System.Windows.Forms.Label lblFrequencytype;
        private System.Windows.Forms.ComboBox cmbFrequencytype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtScantype;
        private System.Windows.Forms.ComboBox cmbEac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMaxfrequency;
        private System.Windows.Forms.Label lblMaxfrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Label infoSerialPort;
    }
}