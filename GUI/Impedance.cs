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
    public partial class Impedance : Form
    {

        //Serial port object declaration
        SerialPort comPort = new SerialPort();

        public Impedance()
        {
            InitializeComponent();
            txtScantype.Text = "Fixed";
            txtEdc.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            //# E dc
            bool eDc = false;
            float eDcval = 0f;
            if (txtEdc.Text == "")
            {
                lblEdc.Text = "* E dc can not be empty";
                lblEdc.ForeColor = Color.Red;
            }
            else if (txtEdc.Text != "")
            {
                eDcval = float.Parse(Convert.ToString(txtEdc.Text));
                if (eDcval < -1.0f || eDcval > 1.0f)
                {
                    lblEdc.Text = "* Enter E dc between -1.0 V and +1.0 V";
                    lblEdc.ForeColor = Color.Red;
                }
                else
                {
                    lblEdc.Text = "";
                    eDc = true;
                }
            }

            //# E ac

            bool eAc = false;

            if (cmbEac.SelectedItem == null)
            {
                lblEac.Text = "* Please select a value";
                lblEac.ForeColor = Color.Red;
            }
            else
            {
                lblEac.Text = "";
                eAc = true;
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
                current = true;
                lblCurrent.Text = "";
            }

            //# Frequencytype

            bool frequencyType = false;

            if (cmbFrequencytype.SelectedItem == null)
            {
                lblFrequencytype.Text = "* Please select a value";
                lblFrequencytype.ForeColor = Color.Red;
            }
            else
            {
                lblFrequencytype.Text = "";
                frequencyType = true;
            }

            //Frequency
            
            bool frequency = false;
            float frequencyval = 0f;

            if (txtFrequency.Text == "")
            {
                lblFrequency.Text = "* Frequency can not be empty";
                lblFrequency.ForeColor = Color.Red;
            }
            else if (txtFrequency.Text != "")
            {
                frequencyval = float.Parse(Convert.ToString(txtFrequency.Text));
                if (frequencyval < 0.1f || frequencyval > 100000f)
                {
                    lblFrequency.Text = "* Enter Frequency between 0.1 Hz and 100 kHz";
                    lblFrequency.ForeColor = Color.Red;
                }
                else
                {
                    lblFrequency.Text = "";
                    frequency = true;
                }
            }

            //# Min. frequency

            bool minFrequency = false;

            if (cmbMinfrequency.SelectedItem == null)
            {
                lblMinfrequency.Text = "* Please select a value";
                lblMinfrequency.ForeColor = Color.Red;
            }
            else
            {
                lblMinfrequency.Text = "";
                minFrequency = true;
            }

            //# Max. frequency

            bool maxFrequency = false;

            if (cmbMaxfrequency.SelectedItem == null)
            {
                lblMaxfrequency.Text = "* Please select a value";
                lblMaxfrequency.ForeColor = Color.Red;
            }
            else
            {
                lblMaxfrequency.Text = "";
                maxFrequency = true;
            }


            if(cmbFrequencytype.Text == "Fixed")
            {
                minFrequency = true;
                maxFrequency = true;
            }
            else if(cmbFrequencytype.Text == "Scan")
            {
                frequency = true;
            }

            if(eDc && eAc && current && frequencyType && frequency && minFrequency && maxFrequency && serialPort)
            {
                //Conversion of individual data into corresponding byte array ayyays

                int methodval = 3;
                byte[] methodTypeBytes = BitConverter.GetBytes(methodval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(methodTypeBytes);
                }

                //Conversion of E dc into byte array

                byte[] eDcvalBytes = BitConverter.GetBytes(eDcval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(eDcvalBytes);
                }

                //Conversion of E ac into byte array

                float eAcval = float.Parse(Convert.ToString(cmbEac.Text));
                byte[] eAcvalBytes = BitConverter.GetBytes(eAcval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(eAcvalBytes);
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

                //Conversion of Frequencytype into byte array

                int frequencyTypeval = 0;

                if(Convert.ToString(cmbFrequencytype.Text) == "Fixed")
                {
                    frequencyTypeval = 1;
                }
                else if (Convert.ToString(cmbFrequencytype.Text) == "Scan")
                {
                    frequencyTypeval = 2;
                }

                byte[] frequencyTypevalBytes = BitConverter.GetBytes(frequencyTypeval);

                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(frequencyTypevalBytes);
                }

                //Conversion of Frequency into byte array

                byte[] frequencyvalBytes = BitConverter.GetBytes(frequencyval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(frequencyvalBytes);
                }


                //Conversion of Min.frequency into byte array

                float minFrequencyval = 0f;
                int minFrequencyTypeval = 0;

                if (cmbMinfrequency.SelectedItem !=null)
                {
                    string minFrequencyData = Convert.ToString(cmbMinfrequency.Text);
                    string firstval = minFrequencyData.Substring(0, minFrequencyData.IndexOf(" "));
                    minFrequencyval = float.Parse(firstval);
                    string secondval = minFrequencyData.Split(' ').Last();

                    if (secondval == "Hz")
                    {
                        minFrequencyTypeval = 1;
                    }
                    else if (secondval == "kHz")
                    {
                        minFrequencyTypeval = 2;
                    }
                    else
                    {
                        minFrequencyTypeval = 0;
                    }
                }


                byte[] minFrequencyvalBytes = BitConverter.GetBytes(minFrequencyval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(minFrequencyvalBytes);
                }

                byte[] minFrequencyTypevalBytes = BitConverter.GetBytes(minFrequencyTypeval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(minFrequencyTypevalBytes);
                }


                //Conversion of Max.frequency into byte array

                float maxFrequencyval = 0f;

                if (cmbMaxfrequency.SelectedItem != null)
                {
                    string maxFrequencyData = Convert.ToString(cmbMaxfrequency.Text);
                    string firstpart = maxFrequencyData.Substring(0, maxFrequencyData.IndexOf(" "));
                    maxFrequencyval = float.Parse(firstpart);
                }
 
                byte[] maxFrequencyvalBytes = BitConverter.GetBytes(maxFrequencyval);
                if (!BitConverter.IsLittleEndian)
                {
                    Array.Reverse(maxFrequencyvalBytes);
                }


                //Appending all byte ayyars to one byte array
                //Here totalData[0] contains methodTypeBytes[0] and totalData[4] contains eStartvalBytes[0] and so on....
               
                byte[] totalData = new byte[40];
                totalData = methodTypeBytes.Concat(eDcvalBytes).Concat(eAcvalBytes).Concat(currentvalBytes).Concat(currentTypevalBytes).Concat(frequencyTypevalBytes).Concat(frequencyvalBytes).Concat(minFrequencyvalBytes).Concat(minFrequencyTypevalBytes).Concat(maxFrequencyvalBytes).ToArray();

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

                    comPort.Write(totalData, 0, totalData.Length);
 
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
                    txtEdc.Enabled = false;
                    cmbEac.Enabled = false;
                    cmbCurrent.Enabled = false;
                    cmbFrequencytype.Enabled = false;
                    txtFrequency.Enabled = false;
                    cmbMinfrequency.Enabled = false;
                    cmbMaxfrequency.Enabled = false;
                    btnSubmit.Enabled = false;

                    lblGraph.Visible = true;
                    chart1.Visible = true;
                    chart2.Visible = true;
                    btnSaveGraph.Visible = true;
                    btnSaveData.Visible = true;

                    threadRunning = true;
                    Thread masterthread;
                    masterthread = new Thread(realTimeGraph);
                    masterthread.Start();
                }

            }

        }

        string receivedData;
        string graphRealImpedance;
        string graphImgImpedance;
        string graphFrequency;
        double graphRealImpedancevalue;
        double graphImgImpedancevalue;
        double graphFrequencyvalue;
        double impedanceMagnitude;
        bool threadRunning;
        double graphPhase;
        ArrayList realImpedancevalues = new ArrayList();
        ArrayList imgImpedancevalues = new ArrayList();
        ArrayList allFrequencyvalues = new ArrayList();
        ArrayList impedanceMagnitudevalues = new ArrayList();
        ArrayList phasevalues = new ArrayList();

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
                            graphRealImpedance = receivedDataWords[0];
                            graphImgImpedance = receivedDataWords[1];
                            graphFrequency = receivedDataWords[2];
                            graphRealImpedancevalue = Convert.ToDouble(graphRealImpedance);
                            graphImgImpedancevalue = Convert.ToDouble(graphImgImpedance);
                            graphFrequencyvalue = Convert.ToDouble(graphFrequency);
                            impedanceMagnitude = Math.Sqrt(Math.Pow(graphRealImpedancevalue, 2) + Math.Pow(graphImgImpedancevalue, 2));
                            graphPhase = (Math.Atan(graphImgImpedancevalue / graphRealImpedancevalue)*(180/Math.PI));
                            realImpedancevalues.Add(graphRealImpedancevalue);
                            imgImpedancevalues.Add(graphImgImpedancevalue);
                            allFrequencyvalues.Add(graphFrequencyvalue);
                            impedanceMagnitudevalues.Add(impedanceMagnitude);
                            phasevalues.Add(graphPhase);
                            graphFrequencyvalue = Math.Log10(graphFrequencyvalue);
                            chart1.Invoke((MethodInvoker)(() => chart1.Series[0].Points.AddXY(graphFrequencyvalue, graphPhase)));
                            chart2.Invoke((MethodInvoker)(() => chart2.Series[0].Points.AddXY(graphFrequencyvalue, impedanceMagnitude)));
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

        private void txtEdc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtEdc.Text.IndexOf('.') != -1 || e.KeyChar == 45 && txtEdc.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                e.Handled = true;
                lblEdc.Text = "* Enter only numeric value";
                lblEdc.ForeColor = Color.Red;
            }
            else
            {
                lblEdc.Text = "";
            }
        }

        private void cmbCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrent.Text = "";
        }

        private void Impedance_Load(object sender, EventArgs e)
        {
            btnSaveGraph.Visible = false;
            btnSaveData.Visible = false;
            lblGraph.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;

            // Pop up current serial ports in the system

            string[] currentSerialPorts = SerialPort.GetPortNames();

            cmbSerialPort.Items.Clear();

            foreach (string port in currentSerialPorts)
            {
                cmbSerialPort.Items.Add(port);
            }

        }

        private void cmbEac_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEac.Text = "";
        }

        private void cmbFrequencytype_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblFrequencytype.Text = "";

            if (Convert.ToString(cmbFrequencytype.Text) == "Fixed")
            {
                tableLayoutPanel3.Visible = false;
                tableLayoutPanel2.Visible = true;
            }
            else if (Convert.ToString(cmbFrequencytype.Text) == "Scan")
            {
                tableLayoutPanel3.Visible = true;
                tableLayoutPanel2.Visible = false;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFrequencytype_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbMinfrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMinfrequency.Text = "";

        }

        private void cmbMaxfrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaxfrequency.Text = "";
        }

        private void txtFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtFrequency.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblFrequency.Text = "* Enter only numeric value";
                lblFrequency.ForeColor = Color.Red;
            }
            else
            {
                lblFrequency.Text = "";
            }
        }

        private void Impedance_Leave(object sender, EventArgs e)
        {
            if (comPort.IsOpen == true)
            {
                comPort.Close();
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            btnSaveData.Enabled = false;

            //Saving data to excel file
            DialogResult response = MessageBox.Show("Please select the path to save graph data into an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (response == DialogResult.OK)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xls", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Name = "Impedance spectroscopy";
                        ws.Cells[1, 1] = "Real Impedance";
                        ws.Cells[1, 2] = "Img Impedance";
                        ws.Cells[1, 3] = "Magnitude";
                        ws.Cells[1, 4] = "Phase";
                        ws.Cells[1, 5] = "Frequency";
                        int row = 2;
                        int column;
                        for (int k = 0; k < imgImpedancevalues.Count; k++)
                        {
                            column = 1;
                            ws.Cells[row, column] = realImpedancevalues[k];
                            column++;
                            ws.Cells[row, column] = imgImpedancevalues[k];
                            column++;
                            ws.Cells[row, column] = impedanceMagnitudevalues[k];
                            column++;
                            ws.Cells[row, column] = phasevalues[k];
                            column++;
                            ws.Cells[row, column] = allFrequencyvalues[k];
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
            DialogResult pathSelect_nquist = MessageBox.Show("Please select the file path to export the Nquist plot into an image", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (pathSelect_nquist == DialogResult.OK)
            {
                SaveFileDialog savingPath = new SaveFileDialog() { Filter = "JPEG Image (.jpeg)|*.jpeg", ValidateNames = true };
                if (savingPath.ShowDialog() == DialogResult.OK)
                {
                    this.chart1.SaveImage(savingPath.FileName, ChartImageFormat.Png);      
                    DialogResult savingresponse =  MessageBox.Show("Graph has been exported to image successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(savingresponse == DialogResult.OK)
                    {
                        //Do nothing
                    }
                }
            }
            DialogResult pathSelect_bode = MessageBox.Show("Please select the file path to export the Bode plot into an image", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (pathSelect_bode == DialogResult.OK)
            {
                SaveFileDialog savingPath = new SaveFileDialog() { Filter = "JPEG Image (.jpeg)|*.jpeg", ValidateNames = true };
                if (savingPath.ShowDialog() == DialogResult.OK)
                {
                    this.chart2.SaveImage(savingPath.FileName, ChartImageFormat.Png);
                    DialogResult savingresponse = MessageBox.Show("Graph has been exported to image successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (savingresponse == DialogResult.OK)
                    {
                        //Do nothing
                    }
                }
            }
            btnSaveGraph.Enabled = true;
        }
    }
}
