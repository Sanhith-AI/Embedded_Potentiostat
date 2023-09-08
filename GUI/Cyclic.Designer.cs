namespace CIFEA
{
    partial class Cyclic
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.cmbNoofscans = new System.Windows.Forms.ComboBox();
            this.cmbCurrent = new System.Windows.Forms.ComboBox();
            this.lblEstart = new System.Windows.Forms.Label();
            this.lblEstop = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblScanrate = new System.Windows.Forms.Label();
            this.lblNoofscans = new System.Windows.Forms.Label();
            this.cmbScanrate = new System.Windows.Forms.ComboBox();
            this.lblEStep = new System.Windows.Forms.Label();
            this.cmbEstep = new System.Windows.Forms.ComboBox();
            this.infoSerialPort = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.lblGraph = new System.Windows.Forms.Label();
            this.btnSaveGraph = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(382, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cyclic Voltammetry";
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.cmbNoofscans, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurrent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEstart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEstop, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrent, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblScanrate, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblNoofscans, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbScanrate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEStep, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstep, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.infoSerialPort, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 413);
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
            this.cmbSerialPort.Location = new System.Drawing.Point(279, 10);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(326, 37);
            this.cmbSerialPort.TabIndex = 36;
            this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Serial port";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(620, 293);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 58);
            this.label14.TabIndex = 30;
            this.label14.Text = "V/s";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(620, 249);
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
            this.label11.Location = new System.Drawing.Point(620, 131);
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
            this.label10.Location = new System.Drawing.Point(620, 72);
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
            this.label7.Location = new System.Drawing.Point(112, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Scan rate";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 72);
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
            this.label4.Location = new System.Drawing.Point(145, 131);
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
            this.label5.Location = new System.Drawing.Point(134, 190);
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
            this.label6.Location = new System.Drawing.Point(145, 249);
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
            this.label8.Location = new System.Drawing.Point(87, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 49, 0);
            this.label8.Size = new System.Drawing.Size(188, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "No of scans";
            // 
            // txtEstart
            // 
            this.txtEstart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstart.Location = new System.Drawing.Point(279, 69);
            this.txtEstart.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstart.Name = "txtEstart";
            this.txtEstart.Size = new System.Drawing.Size(326, 35);
            this.txtEstart.TabIndex = 9;
            this.txtEstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstart_KeyPress);
            // 
            // txtEstop
            // 
            this.txtEstop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstop.Location = new System.Drawing.Point(279, 128);
            this.txtEstop.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstop.Name = "txtEstop";
            this.txtEstop.Size = new System.Drawing.Size(326, 35);
            this.txtEstop.TabIndex = 10;
            this.txtEstop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstop_KeyPress);
            // 
            // cmbNoofscans
            // 
            this.cmbNoofscans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbNoofscans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoofscans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoofscans.FormattingEnabled = true;
            this.cmbNoofscans.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNoofscans.Location = new System.Drawing.Point(279, 364);
            this.cmbNoofscans.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNoofscans.Name = "cmbNoofscans";
            this.cmbNoofscans.Size = new System.Drawing.Size(326, 37);
            this.cmbNoofscans.TabIndex = 14;
            this.cmbNoofscans.SelectedIndexChanged += new System.EventHandler(this.cmbNoofscans_SelectedIndexChanged);
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
            this.cmbCurrent.Location = new System.Drawing.Point(279, 186);
            this.cmbCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurrent.Name = "cmbCurrent";
            this.cmbCurrent.Size = new System.Drawing.Size(326, 37);
            this.cmbCurrent.TabIndex = 22;
            this.cmbCurrent.SelectedIndexChanged += new System.EventHandler(this.cmbCurrent_SelectedIndexChanged);
            // 
            // lblEstart
            // 
            this.lblEstart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstart.AutoSize = true;
            this.lblEstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstart.ForeColor = System.Drawing.Color.White;
            this.lblEstart.Location = new System.Drawing.Point(670, 74);
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
            this.lblEstop.Location = new System.Drawing.Point(670, 133);
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
            this.lblCurrent.Location = new System.Drawing.Point(670, 192);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(75, 25);
            this.lblCurrent.TabIndex = 18;
            this.lblCurrent.Text = "label12";
            // 
            // lblScanrate
            // 
            this.lblScanrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScanrate.AutoSize = true;
            this.lblScanrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanrate.ForeColor = System.Drawing.Color.White;
            this.lblScanrate.Location = new System.Drawing.Point(670, 310);
            this.lblScanrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScanrate.Name = "lblScanrate";
            this.lblScanrate.Size = new System.Drawing.Size(75, 25);
            this.lblScanrate.TabIndex = 20;
            this.lblScanrate.Text = "label14";
            // 
            // lblNoofscans
            // 
            this.lblNoofscans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNoofscans.AutoSize = true;
            this.lblNoofscans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoofscans.ForeColor = System.Drawing.Color.White;
            this.lblNoofscans.Location = new System.Drawing.Point(670, 370);
            this.lblNoofscans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoofscans.Name = "lblNoofscans";
            this.lblNoofscans.Size = new System.Drawing.Size(75, 25);
            this.lblNoofscans.TabIndex = 21;
            this.lblNoofscans.Text = "label15";
            // 
            // cmbScanrate
            // 
            this.cmbScanrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbScanrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScanrate.FormattingEnabled = true;
            this.cmbScanrate.Items.AddRange(new object[] {
            "0.01",
            "0.02",
            "0.03",
            "0.04",
            "0.05",
            "0.075",
            "0.1",
            "0.15",
            "0.2",
            "0.25",
            "0.4",
            "0.5",
            "0.75",
            "1.0"});
            this.cmbScanrate.Location = new System.Drawing.Point(279, 304);
            this.cmbScanrate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbScanrate.Name = "cmbScanrate";
            this.cmbScanrate.Size = new System.Drawing.Size(326, 37);
            this.cmbScanrate.TabIndex = 31;
            this.cmbScanrate.SelectedIndexChanged += new System.EventHandler(this.cmbScanrate_SelectedIndexChanged);
            // 
            // lblEStep
            // 
            this.lblEStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEStep.AutoSize = true;
            this.lblEStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEStep.ForeColor = System.Drawing.Color.White;
            this.lblEStep.Location = new System.Drawing.Point(670, 251);
            this.lblEStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEStep.Name = "lblEStep";
            this.lblEStep.Size = new System.Drawing.Size(75, 25);
            this.lblEStep.TabIndex = 33;
            this.lblEStep.Text = "label12";
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
            this.cmbEstep.Location = new System.Drawing.Point(279, 245);
            this.cmbEstep.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstep.Name = "cmbEstep";
            this.cmbEstep.Size = new System.Drawing.Size(326, 37);
            this.cmbEstep.TabIndex = 34;
            this.cmbEstep.SelectedIndexChanged += new System.EventHandler(this.cmbEstep_SelectedIndexChanged);
            // 
            // infoSerialPort
            // 
            this.infoSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.infoSerialPort.AutoSize = true;
            this.infoSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSerialPort.ForeColor = System.Drawing.Color.Black;
            this.infoSerialPort.Location = new System.Drawing.Point(670, 16);
            this.infoSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoSerialPort.Name = "infoSerialPort";
            this.infoSerialPort.Size = new System.Drawing.Size(182, 25);
            this.infoSerialPort.TabIndex = 37;
            this.infoSerialPort.Text = "* Select correct port";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(382, 507);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 53);
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
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Format = "0.0000";
            chartArea1.AxisX.Title = "Voltage (V)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "0.0000";
            chartArea1.AxisY.Title = "Current (µA)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.HotTrack;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 638);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Voltage (vs) Current";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(692, 340);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ForeColor = System.Drawing.Color.White;
            this.btnSaveData.Location = new System.Drawing.Point(726, 839);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(196, 58);
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
            this.lblGraph.Location = new System.Drawing.Point(34, 590);
            this.lblGraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(370, 32);
            this.lblGraph.TabIndex = 5;
            this.lblGraph.Text = "Graph: Cyclic voltammetry";
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveGraph.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGraph.ForeColor = System.Drawing.Color.White;
            this.btnSaveGraph.Location = new System.Drawing.Point(726, 686);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(196, 58);
            this.btnSaveGraph.TabIndex = 6;
            this.btnSaveGraph.Text = "Save Graph";
            this.btnSaveGraph.UseVisualStyleBackColor = false;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // Cyclic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 1016);
            this.Controls.Add(this.btnSaveGraph);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(434, 348);
            this.Name = "Cyclic";
            this.Text = "Cyclic";
            this.Load += new System.EventHandler(this.Cyclic_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Cyclic_Scroll);
            this.Leave += new System.EventHandler(this.Cyclic_Leave);
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
        private System.Windows.Forms.ComboBox cmbNoofscans;
        private System.Windows.Forms.Label lblNoofscans;
        private System.Windows.Forms.Label lblScanrate;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblEstop;
        private System.Windows.Forms.Label lblEstart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbCurrent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbScanrate;
        private System.Windows.Forms.Label lblEStep;
        private System.Windows.Forms.ComboBox cmbEstep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoSerialPort;
    }
}