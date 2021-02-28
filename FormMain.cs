using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace SoftSensConf
{
    public partial class FormMain : Form
    {

        public FormMain()

        {
            InitializeComponent();
        }
        string receivedConfig;
        string[] instrumentConfigs = { };
        string nydata;
        string writeString;
        //List<MeasurementPoint> allMeasuredPoints = new List<MeasurementPoint>(); 
        string configurationMonitor()

        {
            return string.Format("{0};{1};{2};{3};{4};", textBoxPass.Text, textBoxName.Text,
                                                         textBoxLowerRV.Text, textBoxUpperRV.Text,
                                                         textBoxAlarmL.Text, textBoxAlarmH.Text);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //string[] ports = SerialPort.GetPortNames();
            //foreach (string port in ports)
            {
                string[] ports = SerialPort.GetPortNames();
                ComboBoxPort.Items.AddRange(ports);
                //instrumentConfigs = new string[5];
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {

            try
            {
                //serialPort1.PortName = ComboBoxPort.SelectedItem.ToString();
                //serialPort1.BaudRate = int.Parse(ComboBoxBaudRate.SelectedItem.ToString());
                //COM PORT Parameters
                serialPort1.PortName = ComboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(ComboBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ComboBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), ComboBoxParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;

                LabelStatus.Text = "Status : Connected";
                ButtonConnect.SendToBack();
                ButtonDisconnect.BringToFront();
                PictureBoxConnectionStatus.BackColor = Color.Green;
            }
            //COM PORT Error Message
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            LabelStatus.Text = "Status : Disconnected";
            ButtonDisconnect.SendToBack();
            ButtonConnect.BringToFront();
            PictureBoxConnectionStatus.Visible = true;
            PictureBoxConnectionStatus.BackColor = Color.Red;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            if (textBoxPass.Text == "")
            {
                MessageBox.Show("Plaese enter the password");
            }
            
            else
            {

                string passwordString = textBoxPass.Text;

                instrumentConfigs[0] = textBoxName.Text;
                instrumentConfigs[1] = textBoxLowerRV.Text;
                instrumentConfigs[2] = textBoxUpperRV.Text;
                instrumentConfigs[3] = textBoxAlarmH.Text;
                instrumentConfigs[4] = textBoxAlarmL.Text;

                writeString = "writeconf>" + passwordString + ">" + string.Join(";", receivedConfig);
                serialPort1.Write(writeString);
                textBoxPass.Clear();
                textBoxCommand.Text = writeString;

            }
        }

        
        private void buttonWrite_Click(object sender, EventArgs e)
        {

            nydata = configurationMonitor();
            if (textBoxPass.Text == "")
            {
                MessageBox.Show("Plaese enter the password", "Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                receivedConfig = configurationMonitor();
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("ERROR, Configuration empty");
                    textBoxName.Focus();
                }

                else if (textBoxLowerRV.Text == "")
                {
                    MessageBox.Show("ERROR, Configuration empty");
                    textBoxLowerRV.Focus();
                }

                else if (textBoxUpperRV.Text == "")
                {
                    MessageBox.Show("ERROR, Configuration empty");
                    textBoxUpperRV.Focus();
                }

                else if (textBoxAlarmL.Text == "")

                {
                    MessageBox.Show("ERROR, Configuration empty");
                    textBoxAlarmL.Focus();
                }

                else if (textBoxAlarmH.Text == "")
                {
                    MessageBox.Show("ERROR, Configuration empty");
                    textBoxAlarmH.Focus();
                }

                else
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("writeconf>" + textBoxPass.Text + ">" + nydata);
                        int milliseconds = 2000;
                        System.Threading.Thread.Sleep(milliseconds);
                        string receivedConfimartion = serialPort1.ReadExisting();
                        string writeSuccsess = receivedConfimartion;
                        if (writeSuccsess == "1")
                        {
                            MessageBox.Show("Configuration written succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Configuration write error");
                        }

                    }
                }
                       
        }


        int millisecond = 2000;
        private void buttonRead_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxLowerRV.Clear();
            textBoxUpperRV.Clear();
            textBoxAlarmL.Clear();
            textBoxAlarmH.Clear();
            System.Threading.Thread.Sleep(millisecond);


            serialPort1.Write("readconf");
            System.Threading.Thread.Sleep(millisecond);
            receivedConfig = serialPort1.ReadExisting();
            receivedConfig = receivedConfig.Replace("\r\n", "");
            instrumentConfigs = receivedConfig.Split(';');
            TextBox[] textboxes = { textBoxName,
                                    textBoxLowerRV,
                                    textBoxUpperRV,
                                    textBoxAlarmL,
                                    textBoxAlarmH
            };
     
            textBoxName.Text = instrumentConfigs[0];
            textBoxLowerRV.Text = instrumentConfigs[1];
            textBoxUpperRV.Text = instrumentConfigs[2];
            textBoxAlarmL.Text = instrumentConfigs[3];
            textBoxAlarmH.Text = instrumentConfigs[4];
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
           /* if (serialPort1.IsOpen)
            {
                
                serialPort1.WriteLine("readraw");
                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
            }*/
        }
        private void timerChartAddScaled_Tick(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readscaled");
                timerSerialReceieveScaled.Enabled = true;
                timerChartAddScaled.Enabled = false;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {/*
            timerChartAdd.Enabled = true;
            */
        }
        private void StartScaled_Click(object sender, EventArgs e)
        {
            timerChartAddScaled.Enabled = true;
        }

        private void timerSerialReceived_Tick(object sender, EventArgs e)
        {/*
            
            if (serialPort1.BytesToRead > 0)
            {
                
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                string[] analogReadings = availableData.Split(';');

                
                //textBoxTextFile.AppendText(availableData +"\r\n");
                if (analogReadings.Length == 1)
                {
                   
                    listBoxValueAB.Items.Add(analogReadings[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxValueAB.Items.Count - 1),
                                                    Convert.ToDouble(listBoxValueAB.Items[listBoxValueAB.Items.Count - 1]));
                    
                }
                timerChartAdd.Enabled = true;
                timerSerialReceive.Enabled = false;
            }
            */
        }
        private void timerSerialReceieveScaled_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string availableDataScaled = "";
                availableDataScaled += serialPort1.ReadExisting().ToString();
                string[] analogReadingsScaled = availableDataScaled.Split(';');

                //textBoxTextFileScaled.AppendText(availableDataScaled + "\r\n");
                if (analogReadingsScaled.Length == 1)
                {
                    listBoxValueS.Items.Add(analogReadingsScaled[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxValueS.Items.Count - 1),
                                                    Convert.ToDouble(listBoxValueS.Items[listBoxValueS.Items.Count - 1]));
                        
                }
                timerChartAddScaled.Enabled = true;
                timerSerialReceieveScaled.Enabled = false;
            }
 
        }


        string readconf = "readconf";
        string writeconf = "writeconf";
        string readraw = "readraw";
        string readscaled = "readcaled";
        string readstatus = "readstatus";
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            textBoxCommand.Clear();

            if (textBoxWriteCommand.Text.Equals(readconf))
            {
                
                serialPort1.WriteLine(readconf);
                int millisecond = 2000;
                System.Threading.Thread.Sleep(millisecond);
                textBoxCommand.AppendText(serialPort1.ReadExisting().ToString());
            }
            if (textBoxWriteCommand.Text.Equals(writeconf))
            {
                
                serialPort1.WriteLine(writeconf);
                int millisecond = 2000;
                System.Threading.Thread.Sleep(millisecond);
                textBoxCommand.AppendText(serialPort1.ReadExisting().ToString());
            }
            if (textBoxWriteCommand.Text.Equals(readraw))
            {
                serialPort1.WriteLine(readraw);
                int millisecond = 2000;
                System.Threading.Thread.Sleep(millisecond);
                textBoxCommand.AppendText(serialPort1.ReadExisting().ToString());
            }
            if (textBoxWriteCommand.Text.Equals(readscaled))
            {
                serialPort1.WriteLine(readscaled);
                int millisecond = 2000;
                System.Threading.Thread.Sleep(millisecond);
                textBoxCommand.AppendText(serialPort1.ReadExisting().ToString());
            }
            if (textBoxWriteCommand.Text.Equals(readstatus))
            {
                serialPort1.WriteLine(readstatus);
                int millisecond = 2000;
                System.Threading.Thread.Sleep(millisecond);
                textBoxCommand.AppendText(serialPort1.ReadExisting().ToString());
            }
           
        }


        private void buttonLoadToFile_Click(object sender, EventArgs e)
        {
            string filepath = "";
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }
            if(File.Exists(filepath))
            {
                string[] fileData;
                using(StreamReader sr = new StreamReader(filepath))
                {
                    fileData = sr.ReadToEnd().Split(';');

                    textBoxCommand.Text = string.Join(";", fileData);

                    textBoxName.Text = fileData[0];
                    textBoxLowerRV.Text = fileData[1];
                    textBoxUpperRV.Text = fileData[2];
                    textBoxAlarmL.Text = fileData[3];
                    textBoxAlarmH.Text = fileData[4];
                }
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            
            if(saveFileDialogConf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogConf.FileName, string.Join(";", instrumentConfigs));
                MessageBox.Show("Successfully saved", " Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerChartAddScaled.Enabled = false;
            timerSerialReceieveScaled.Enabled = false;
            timerChartAdd.Enabled = false;
            timerSerialReceive.Enabled = false;

        }
    }   
}
