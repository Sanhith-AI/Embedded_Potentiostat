using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

//Below name spaces are required for serial port programming and real time graph
using System.IO.Ports;
using System.IO;
using System.Drawing.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Microsoft.Office.Interop.Excel;

namespace CIFEA
{
    public partial class Cyclic : Form
    {

        //Serial port object declaration
        SerialPort comPort = new SerialPort();
        public Cyclic()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cyclic_Load(object sender, EventArgs e)
        {
            btnSaveData.Visible = false;
            btnSaveGraph.Visible = false;
            lblGraph.Visible = false;
            chart1.Visible = false;

            // Pop up current serial ports in the system

            string[] currentSerialPorts = SerialPort.GetPortNames();

            cmbSerialPort.Items.Clear();

            foreach(string port in currentSerialPorts)
            {
                cmbSerialPort.Items.Add(port);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check serial port

            bool serialPort = false;

            if (cmbSerialPort.SelectedItem == null)
            {
                infoSerialPort.Text = "* Select correct port";
                infoSerialPort.ForeColor = Color.Red;
            }
            else
            {
                serialPort = true;
                infoSerialPort.Text = " ";
            }

            //# E start and E stop

            bool eStart = false;
            float eStartval = 0f;

            if (txtEstart.Text == "")
            {
                lblEstart.Text = "* E start can not be empty";
                lblEstart.ForeColor = Color.Red;
            }
            else if (txtEstart.Text != "")
            {
                eStartval = float.Parse(Convert.ToString(txtEstart.Text));
                if (eStartval < -1.5f || eStartval > 1.5f)
                {
                    lblEstart.Text = "* Enter E start between -1.5 V and +1.5 V";
                    lblEstart.ForeColor = Color.Red;
                }
                else
                {
                    lblEstart.Text = "";
                    eStart = true;
                }
            }


            bool eStop = false;
            float eStopval = 0f;
            if (txtEstop.Text == "")
            {
                lblEstop.Text = "* E stop can not be empty";
                lblEstop.ForeColor = Color.Red;
            }
            else if (txtEstop.Text != "")
            {
                eStopval = float.Parse(Convert.ToString(txtEstop.Text));
                if (eStopval < -1.5f || eStopval > 1.5f)
                {
                    lblEstop.Text = "* Enter E stop between -1.5 V and +1.5 V";
                    lblEstop.ForeColor = Color.Red;
                }
                else if (txtEstart.Text != null)
                {
                    if (eStopval <= eStartval)
                    {
                        lblEstop.Text = "* E stop must be grater than E start";
                        lblEstop.ForeColor = Color.Red;
                    }
                    else if (eStopval > eStartval)
                    {
                        lblEstop.Text = "";
                        eStop = true;
                    }

                }
                else
                {
                    lblEstop.Text = "";
                    eStop = true;
                }
            }


            //# Current

            bool current = false;
            if (cmbCurrent.SelectedItem ==null)
            {
                lblCurrent.Text = "* Please select a value";
                lblCurrent.ForeColor = Color.Red;
            }
            else
            {
                lblCurrent.Text = "";
                current = true;
            }

            //# E step

            bool eStep = false;
            if (cmbEstep.SelectedItem == null)
            {
                lblEStep.Text = "* Please select a value";
                lblEStep.ForeColor = Color.Red;
            }
            else
            {
                lblEStep.Text = "";
                eStep = true;
            }

            //# Scan rate

            bool scanRate = false;
            if (cmbScanrate.SelectedItem == null)
            {
                lblScanrate.Text = "* Please select a value";
                lblScanrate.ForeColor = Color.Red;
            }
            else
            {
                lblScanrate.Text = "";
                scanRate = true;
            }

            //# No of scans

            bool noofScans = false;
            if (cmbNoofscans.SelectedItem == null)
            {
                lblNoofscans.Text = "* Please select a value";
                lblNoofscans.ForeColor = Color.Red;
            }
            else
            {
                lblNoofscans.Text = "";
                noofScans = true;
            }

            if (eStart && eStop && current && eStep && scanRate && noofScans && serialPort)
            {

                //Conversion of individual data into corresponding byte array ayyays

                int methodval = 1;
                byte[] methodTypeBytes = BitConverter.GetBytes(methodval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(methodTypeBytes);
                }

                //Conversion of E start into byte array

                byte[] eStartvalBytes = BitConverter.GetBytes(eStartval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(eStartvalBytes);
                }


                //Conversion of E stop into byte array
                
                byte[] eStopvalBytes = BitConverter.GetBytes(eStopval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(eStopvalBytes);
                }

                //Conversion of current into byte array
                string currentData = Convert.ToString(cmbCurrent.Text);
                string firstWord = currentData.Substring(0, currentData.IndexOf(" "));
                int currentval = Convert.ToInt32(firstWord);
                string secondWord = currentData.Split(' ').Last();
                char currentType = secondWord[0];
                int currentTypeval = 0;
                if (currentType == 'p')
                {
                    currentTypeval = 1;
                }
                else if (currentType == 'n')
                {
                    currentTypeval = 2;
                }
                else if (currentType == 'µ')
                {
                    currentTypeval = 3;
                }
                else if (currentType == 'm')
                {
                    currentTypeval = 4;
                }
                else
                {
                    currentTypeval = 0;
                }

                byte[] currentvalBytes = BitConverter.GetBytes(currentval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(currentvalBytes);
                }

                byte[] currentTypevalBytes = BitConverter.GetBytes(currentTypeval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(currentTypevalBytes);
                }

                //Conversion of E step into byte array
                float eStepval = float.Parse(Convert.ToString(cmbEstep.Text));
                byte[] eStepvalBytes = BitConverter.GetBytes(eStepval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(eStepvalBytes);
                }

                //Conversion of Scan rate into byte array
                float scanRateval = float.Parse(Convert.ToString(cmbScanrate.Text));
                byte[] scanRatevalBytes = BitConverter.GetBytes(scanRateval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(scanRatevalBytes);
                }

                //Conversion of No of scans into byte array
                int noofScansval = int.Parse(Convert.ToString(cmbNoofscans.Text));
                byte[] noofScansvalBytes = BitConverter.GetBytes(noofScansval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(noofScansvalBytes);
                }

                //Appending all byte ayyars to one byte array
                //Here totalData[0] contains methodTypeBytes[0] and totalData[4] contains eStartvalBytes[0] and so on....
                byte[] totalData = new byte[32];
                totalData = methodTypeBytes.Concat(eStartvalBytes).Concat(eStopvalBytes).Concat(currentvalBytes).Concat(currentTypevalBytes).Concat(eStepvalBytes).Concat(scanRatevalBytes).Concat(noofScansvalBytes).ToArray();

                //Sreial port connection
                
                comPort.PortName = cmbSerialPort.SelectedItem.ToString();
                comPort.BaudRate = 115200;
                comPort.Parity = Parity.None;
                comPort.DataBits = 8;
                comPort.StopBits = StopBits.One;
                comPort.DtrEnable = true;
                comPort.RtsEnable = true;
               
                if (comPort.IsOpen)
                {
                    comPort.Close();
                }

                bool error = false;
                try
                {
                    comPort.Open();
                    comPort.Write(totalData,0,totalData.Length);

                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error)
                {
                    comPort.Close();
                    MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (!error)
                {
                    //Making controls non editable so that user cann't edit data while receiving

                    txtEstart.Enabled = false;
                    txtEstop.Enabled = false;
                    cmbCurrent.Enabled = false;
                    cmbEstep.Enabled = false;
                    cmbScanrate.Enabled = false;
                    cmbNoofscans.Enabled = false;
                    btnSubmit.Enabled = false;

                    btnSaveData.Visible = true;
                    btnSaveGraph.Visible = true;
                    lblGraph.Visible = true;
                    chart1.Visible = true;

                    Thread masterthread;
                    masterthread = new Thread(realTimeGraph);
                    threadRunning = true;
                    masterthread.Start();
                }
            }

        }

        string receivedData;
        string graphVoltageData;
        string graphCurrentData;
        double graphVoltageValue;
        double graphCurrentValue;
        bool threadRunning;
        ArrayList allCurrentValues = new ArrayList();
        ArrayList allVoltageValues = new ArrayList();

        void realTimeGraph()
        {
            while (threadRunning)
            {
                if (comPort.IsOpen == true)
                {
                    try
                    {
                        receivedData = comPort.ReadLine();

                        if (receivedData == "END")
                        {
                            MessageBox.Show("Complete data has been received and real time graph has been plotted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            threadRunning = false;
                        }
                        else if (Convert.ToString(receivedData) != "END")
                        {
                            string[] receivedDataWords = receivedData.Split(' ');
                            graphVoltageData = receivedDataWords[0];
                            graphCurrentData = receivedDataWords[1];
                            graphVoltageValue = Convert.ToDouble(graphVoltageData);
                            graphCurrentValue = Convert.ToDouble(graphCurrentData);
                            allVoltageValues.Add(graphVoltageValue);
                            allCurrentValues.Add(graphCurrentValue);
                            chart1.Invoke((MethodInvoker)(() => chart1.Series[0].Points.AddXY(graphVoltageValue, graphCurrentValue)));

                        }
                    }
                    catch (Exception ex)
                    {
                        threadRunning = false;
                        string exceptionData = Convert.ToString(ex);
                    }
                }
                else if (comPort.IsOpen == false)
                {
                    threadRunning = false;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEstart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtEstart.Text.IndexOf('.') != -1 || e.KeyChar == 45 && txtEstart.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                e.Handled = true;
                lblEstart.Text = "* Enter only numeric value";
                lblEstart.ForeColor = Color.Red;
            }
            else
            {
                lblEstart.Text = "";
            }
        }

        private void txtEstop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtEstop.Text.IndexOf('.') != -1 || e.KeyChar == 45 && txtEstop.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                e.Handled = true;
                lblEstop.Text = "* Enter only numeric value";
                lblEstop.ForeColor = Color.Red;
            }
            else
            {
                lblEstop.Text = "";
            }
        }

        private void cmbCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrent.Text = "";
        }

        private void cmbEstep_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEStep.Text = "";
        }

        private void cmbScanrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblScanrate.Text = "";
        }

        private void cmbNoofscans_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNoofscans.Text = "";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Cyclic_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Cyclic_Leave(object sender, EventArgs e)
        {
            if(comPort.IsOpen == true)
            {
                comPort.Close();
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            btnSaveData.Enabled = false;

            //Saving data to excel file
            DialogResult response = MessageBox.Show("Please select the path to save graph data into an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(response == DialogResult.OK)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xls", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Name = "Cyclic voltammetry";
                        ws.Cells[1, 1] = "Voltage (V)";
                        ws.Cells[1, 2] = "Current (mA)";
                        int row = 2;
                        int column;
                        for (int k = 0; k < allVoltageValues.Count; k++)
                        {
                            column = 1;
                            ws.Cells[row, column] = allVoltageValues[k];
                            column++;
                            ws.Cells[row, column] = allCurrentValues[k];
                            row++;
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        DialogResult dataExported = MessageBox.Show("Your data has been successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dataExported == DialogResult.OK)
                        {
                            btnSaveData.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnSaveGraph_Click(object sender, EventArgs e)
        {
            btnSaveGraph.Enabled = false;
            DialogResult pathSelect = MessageBox.Show("Please select the file path to export the grapth into an image", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (pathSelect == DialogResult.OK)
            {
                SaveFileDialog savingPath = new SaveFileDialog() { Filter = "JPEG Image (.jpeg)|*.jpeg", ValidateNames = true };
                if (savingPath.ShowDialog() == DialogResult.OK)
                {
                    this.chart1.SaveImage(savingPath.FileName, ChartImageFormat.Png);
                    MessageBox.Show("Graph has been exported to image successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            btnSaveGraph.Enabled = true;
        }

        private void cmbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoSerialPort.Text = "";
        }
    }
}
