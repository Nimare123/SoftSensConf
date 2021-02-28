
namespace SoftSensConf
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ComboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.ComboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.ComboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.LabelParityBits = new System.Windows.Forms.Label();
            this.LabelStopBits = new System.Windows.Forms.Label();
            this.LabelDataBits = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelComboPort = new System.Windows.Forms.Label();
            this.PictureBoxConnectionStatus = new System.Windows.Forms.PictureBox();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ConnectionTitle = new System.Windows.Forms.Label();
            this.LabelBaudRate = new System.Windows.Forms.Label();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWriteCommand = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonLoadToFile = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.ConfigurationPanel = new System.Windows.Forms.Panel();
            this.labelCM = new System.Windows.Forms.Label();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAlarmL = new System.Windows.Forms.TextBox();
            this.labelLowerRV = new System.Windows.Forms.Label();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.labelUpperRV = new System.Windows.Forms.Label();
            this.textBoxAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxLowerRV = new System.Windows.Forms.TextBox();
            this.textBoxUpperRV = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonScaled = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxValueS = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialReceieveScaled = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogConf = new System.Windows.Forms.SaveFileDialog();
            this.timerChartAddScaled = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogChart = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatus)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ConfigurationPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxParityBits
            // 
            this.ComboBoxParityBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxParityBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxParityBits.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxParityBits.ForeColor = System.Drawing.Color.White;
            this.ComboBoxParityBits.FormattingEnabled = true;
            this.ComboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.ComboBoxParityBits.Location = new System.Drawing.Point(555, 268);
            this.ComboBoxParityBits.Name = "ComboBoxParityBits";
            this.ComboBoxParityBits.Size = new System.Drawing.Size(185, 29);
            this.ComboBoxParityBits.TabIndex = 5;
            // 
            // ComboBoxStopBits
            // 
            this.ComboBoxStopBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxStopBits.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStopBits.ForeColor = System.Drawing.Color.White;
            this.ComboBoxStopBits.FormattingEnabled = true;
            this.ComboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.ComboBoxStopBits.Location = new System.Drawing.Point(555, 225);
            this.ComboBoxStopBits.Name = "ComboBoxStopBits";
            this.ComboBoxStopBits.Size = new System.Drawing.Size(185, 29);
            this.ComboBoxStopBits.TabIndex = 4;
            // 
            // ComboBoxDataBits
            // 
            this.ComboBoxDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDataBits.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDataBits.ForeColor = System.Drawing.Color.White;
            this.ComboBoxDataBits.FormattingEnabled = true;
            this.ComboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.ComboBoxDataBits.Location = new System.Drawing.Point(555, 182);
            this.ComboBoxDataBits.Name = "ComboBoxDataBits";
            this.ComboBoxDataBits.Size = new System.Drawing.Size(185, 29);
            this.ComboBoxDataBits.TabIndex = 3;
            // 
            // LabelParityBits
            // 
            this.LabelParityBits.AutoSize = true;
            this.LabelParityBits.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelParityBits.ForeColor = System.Drawing.Color.Violet;
            this.LabelParityBits.Location = new System.Drawing.Point(377, 268);
            this.LabelParityBits.Name = "LabelParityBits";
            this.LabelParityBits.Size = new System.Drawing.Size(141, 28);
            this.LabelParityBits.TabIndex = 16;
            this.LabelParityBits.Text = "Parity Bits ";
            // 
            // LabelStopBits
            // 
            this.LabelStopBits.AutoSize = true;
            this.LabelStopBits.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStopBits.ForeColor = System.Drawing.Color.Violet;
            this.LabelStopBits.Location = new System.Drawing.Point(377, 225);
            this.LabelStopBits.Name = "LabelStopBits";
            this.LabelStopBits.Size = new System.Drawing.Size(121, 28);
            this.LabelStopBits.TabIndex = 15;
            this.LabelStopBits.Text = "Stop Bits ";
            // 
            // LabelDataBits
            // 
            this.LabelDataBits.AutoSize = true;
            this.LabelDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.LabelDataBits.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDataBits.ForeColor = System.Drawing.Color.Violet;
            this.LabelDataBits.Location = new System.Drawing.Point(377, 182);
            this.LabelDataBits.Name = "LabelDataBits";
            this.LabelDataBits.Size = new System.Drawing.Size(125, 28);
            this.LabelDataBits.TabIndex = 14;
            this.LabelDataBits.Text = "Data Bits ";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(75)))));
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(382, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 43);
            this.progressBar1.TabIndex = 13;
            // 
            // LabelComboPort
            // 
            this.LabelComboPort.AutoSize = true;
            this.LabelComboPort.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComboPort.ForeColor = System.Drawing.Color.Violet;
            this.LabelComboPort.Location = new System.Drawing.Point(378, 95);
            this.LabelComboPort.Name = "LabelComboPort";
            this.LabelComboPort.Size = new System.Drawing.Size(124, 28);
            this.LabelComboPort.TabIndex = 12;
            this.LabelComboPort.Text = "Com Port ";
            // 
            // PictureBoxConnectionStatus
            // 
            this.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.PictureBoxConnectionStatus.Location = new System.Drawing.Point(339, 456);
            this.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus";
            this.PictureBoxConnectionStatus.Size = new System.Drawing.Size(34, 35);
            this.PictureBoxConnectionStatus.TabIndex = 2;
            this.PictureBoxConnectionStatus.TabStop = false;
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(555, 138);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(185, 29);
            this.ComboBoxBaudRate.TabIndex = 2;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.Violet;
            this.LabelStatus.Location = new System.Drawing.Point(6, 456);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(305, 35);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "Status: Disconnected";
            // 
            // ConnectionTitle
            // 
            this.ConnectionTitle.AutoSize = true;
            this.ConnectionTitle.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTitle.ForeColor = System.Drawing.Color.Violet;
            this.ConnectionTitle.Location = new System.Drawing.Point(437, 28);
            this.ConnectionTitle.Name = "ConnectionTitle";
            this.ConnectionTitle.Size = new System.Drawing.Size(286, 39);
            this.ConnectionTitle.TabIndex = 8;
            this.ConnectionTitle.Text = "Connection Panel";
            // 
            // LabelBaudRate
            // 
            this.LabelBaudRate.AutoSize = true;
            this.LabelBaudRate.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaudRate.ForeColor = System.Drawing.Color.Violet;
            this.LabelBaudRate.Location = new System.Drawing.Point(377, 138);
            this.LabelBaudRate.Name = "LabelBaudRate";
            this.LabelBaudRate.Size = new System.Drawing.Size(136, 28);
            this.LabelBaudRate.TabIndex = 7;
            this.LabelBaudRate.Text = "Baud Rate ";
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPort.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPort.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.ItemHeight = 21;
            this.ComboBoxPort.Location = new System.Drawing.Point(555, 95);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(185, 29);
            this.ComboBoxPort.TabIndex = 1;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(95)))));
            this.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(382, 324);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(358, 43);
            this.ButtonConnect.TabIndex = 10;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.White;
            this.ButtonDisconnect.Location = new System.Drawing.Point(382, 324);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(358, 43);
            this.ButtonDisconnect.TabIndex = 11;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.tabPage1.Controls.Add(this.ComboBoxParityBits);
            this.tabPage1.Controls.Add(this.ComboBoxPort);
            this.tabPage1.Controls.Add(this.LabelBaudRate);
            this.tabPage1.Controls.Add(this.ComboBoxBaudRate);
            this.tabPage1.Controls.Add(this.LabelDataBits);
            this.tabPage1.Controls.Add(this.ComboBoxStopBits);
            this.tabPage1.Controls.Add(this.ButtonConnect);
            this.tabPage1.Controls.Add(this.PictureBoxConnectionStatus);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.LabelStopBits);
            this.tabPage1.Controls.Add(this.LabelParityBits);
            this.tabPage1.Controls.Add(this.LabelStatus);
            this.tabPage1.Controls.Add(this.ConnectionTitle);
            this.tabPage1.Controls.Add(this.ComboBoxDataBits);
            this.tabPage1.Controls.Add(this.ButtonDisconnect);
            this.tabPage1.Controls.Add(this.LabelComboPort);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port Confirguration";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxWriteCommand);
            this.tabPage2.Controls.Add(this.buttonConfirm);
            this.tabPage2.Controls.Add(this.textBoxCommand);
            this.tabPage2.Controls.Add(this.buttonEnter);
            this.tabPage2.Controls.Add(this.buttonLoadToFile);
            this.tabPage2.Controls.Add(this.labelPassword);
            this.tabPage2.Controls.Add(this.buttonSaveToFile);
            this.tabPage2.Controls.Add(this.textBoxPass);
            this.tabPage2.Controls.Add(this.buttonRead);
            this.tabPage2.Controls.Add(this.ConfigurationPanel);
            this.tabPage2.Controls.Add(this.buttonWrite);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1141, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Command";
            // 
            // textBoxWriteCommand
            // 
            this.textBoxWriteCommand.Location = new System.Drawing.Point(126, 88);
            this.textBoxWriteCommand.Multiline = true;
            this.textBoxWriteCommand.Name = "textBoxWriteCommand";
            this.textBoxWriteCommand.Size = new System.Drawing.Size(160, 30);
            this.textBoxWriteCommand.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(126, 124);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(160, 30);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(305, 11);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ReadOnly = true;
            this.textBoxCommand.Size = new System.Drawing.Size(413, 305);
            this.textBoxCommand.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(126, 47);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(160, 30);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonLoadToFile
            // 
            this.buttonLoadToFile.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadToFile.Location = new System.Drawing.Point(896, 384);
            this.buttonLoadToFile.Name = "buttonLoadToFile";
            this.buttonLoadToFile.Size = new System.Drawing.Size(135, 35);
            this.buttonLoadToFile.TabIndex = 12;
            this.buttonLoadToFile.Text = "&Open";
            this.buttonLoadToFile.UseVisualStyleBackColor = true;
            this.buttonLoadToFile.Click += new System.EventHandler(this.buttonLoadToFile_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(8, 18);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 23);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToFile.Location = new System.Drawing.Point(737, 384);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(135, 35);
            this.buttonSaveToFile.TabIndex = 11;
            this.buttonSaveToFile.Text = "&Save";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(126, 11);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(160, 30);
            this.textBoxPass.TabIndex = 0;
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(896, 333);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(135, 35);
            this.buttonRead.TabIndex = 10;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // ConfigurationPanel
            // 
            this.ConfigurationPanel.Controls.Add(this.labelCM);
            this.ConfigurationPanel.Controls.Add(this.labelAlarmL);
            this.ConfigurationPanel.Controls.Add(this.textBoxName);
            this.ConfigurationPanel.Controls.Add(this.textBoxAlarmL);
            this.ConfigurationPanel.Controls.Add(this.labelLowerRV);
            this.ConfigurationPanel.Controls.Add(this.labelAlarmH);
            this.ConfigurationPanel.Controls.Add(this.labelUpperRV);
            this.ConfigurationPanel.Controls.Add(this.textBoxAlarmH);
            this.ConfigurationPanel.Controls.Add(this.textBoxLowerRV);
            this.ConfigurationPanel.Controls.Add(this.textBoxUpperRV);
            this.ConfigurationPanel.Controls.Add(this.labelName);
            this.ConfigurationPanel.Location = new System.Drawing.Point(724, 11);
            this.ConfigurationPanel.Name = "ConfigurationPanel";
            this.ConfigurationPanel.Size = new System.Drawing.Size(318, 305);
            this.ConfigurationPanel.TabIndex = 6;
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM.Location = new System.Drawing.Point(27, 5);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(265, 28);
            this.labelCM.TabIndex = 0;
            this.labelCM.Text = "Configuration Monitor";
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmL.Location = new System.Drawing.Point(26, 210);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(81, 23);
            this.labelAlarmL.TabIndex = 8;
            this.labelAlarmL.Text = "AlarmL";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 51);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 35);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAlarmL
            // 
            this.textBoxAlarmL.Location = new System.Drawing.Point(144, 207);
            this.textBoxAlarmL.Multiline = true;
            this.textBoxAlarmL.Name = "textBoxAlarmL";
            this.textBoxAlarmL.Size = new System.Drawing.Size(160, 35);
            this.textBoxAlarmL.TabIndex = 5;
            // 
            // labelLowerRV
            // 
            this.labelLowerRV.AutoSize = true;
            this.labelLowerRV.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowerRV.Location = new System.Drawing.Point(26, 106);
            this.labelLowerRV.Name = "labelLowerRV";
            this.labelLowerRV.Size = new System.Drawing.Size(96, 23);
            this.labelLowerRV.TabIndex = 6;
            this.labelLowerRV.Text = "LowerRV";
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmH.Location = new System.Drawing.Point(26, 262);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(85, 23);
            this.labelAlarmH.TabIndex = 9;
            this.labelAlarmH.Text = "AlarmH";
            // 
            // labelUpperRV
            // 
            this.labelUpperRV.AutoSize = true;
            this.labelUpperRV.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpperRV.Location = new System.Drawing.Point(26, 158);
            this.labelUpperRV.Name = "labelUpperRV";
            this.labelUpperRV.Size = new System.Drawing.Size(95, 23);
            this.labelUpperRV.TabIndex = 7;
            this.labelUpperRV.Text = "UpperRV";
            // 
            // textBoxAlarmH
            // 
            this.textBoxAlarmH.Location = new System.Drawing.Point(144, 259);
            this.textBoxAlarmH.Multiline = true;
            this.textBoxAlarmH.Name = "textBoxAlarmH";
            this.textBoxAlarmH.Size = new System.Drawing.Size(160, 35);
            this.textBoxAlarmH.TabIndex = 6;
            // 
            // textBoxLowerRV
            // 
            this.textBoxLowerRV.Location = new System.Drawing.Point(144, 103);
            this.textBoxLowerRV.Multiline = true;
            this.textBoxLowerRV.Name = "textBoxLowerRV";
            this.textBoxLowerRV.Size = new System.Drawing.Size(160, 35);
            this.textBoxLowerRV.TabIndex = 3;
            // 
            // textBoxUpperRV
            // 
            this.textBoxUpperRV.Location = new System.Drawing.Point(144, 155);
            this.textBoxUpperRV.Multiline = true;
            this.textBoxUpperRV.Name = "textBoxUpperRV";
            this.textBoxUpperRV.Size = new System.Drawing.Size(160, 35);
            this.textBoxUpperRV.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(26, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(737, 333);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(135, 35);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.tabPage3.Controls.Add(this.buttonStop);
            this.tabPage3.Controls.Add(this.buttonScaled);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.listBoxValueS);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1141, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current Values";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(440, 428);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(135, 35);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonScaled
            // 
            this.buttonScaled.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScaled.Location = new System.Drawing.Point(299, 428);
            this.buttonScaled.Name = "buttonScaled";
            this.buttonScaled.Size = new System.Drawing.Size(135, 35);
            this.buttonScaled.TabIndex = 1;
            this.buttonScaled.Text = "StartScaled";
            this.buttonScaled.UseVisualStyleBackColor = true;
            this.buttonScaled.Click += new System.EventHandler(this.StartScaled_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ValueScaled";
            // 
            // listBoxValueS
            // 
            this.listBoxValueS.BackColor = System.Drawing.Color.White;
            this.listBoxValueS.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxValueS.ForeColor = System.Drawing.Color.DarkViolet;
            this.listBoxValueS.FormattingEnabled = true;
            this.listBoxValueS.ItemHeight = 21;
            this.listBoxValueS.Location = new System.Drawing.Point(31, 59);
            this.listBoxValueS.Name = "listBoxValueS";
            this.listBoxValueS.Size = new System.Drawing.Size(145, 235);
            this.listBoxValueS.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Violet;
            chartArea6.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Violet;
            chartArea6.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            legend6.ForeColor = System.Drawing.Color.DarkViolet;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(204, 0);
            this.chart1.Name = "chart1";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.DarkViolet;
            series6.Legend = "Legend1";
            series6.Name = "SeriessS";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(934, 422);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.CheckFileExists = true;
            this.saveFileDialogConfig.DefaultExt = "ssc";
            this.saveFileDialogConfig.FileName = "IntrumentConfig";
            // 
            // timerSerialReceive
            // 
            this.timerSerialReceive.Tick += new System.EventHandler(this.timerSerialReceived_Tick);
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // timerSerialReceieveScaled
            // 
            this.timerSerialReceieveScaled.Interval = 2000;
            this.timerSerialReceieveScaled.Tick += new System.EventHandler(this.timerSerialReceieveScaled_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "ssc";
            this.openFileDialog.FileName = "FileName";
            this.openFileDialog.Filter = "\"txt files (*.ssc)|*.txt|All files (*.*)|*.*\"";
            // 
            // saveFileDialogConf
            // 
            this.saveFileDialogConf.DefaultExt = "ssc";
            this.saveFileDialogConf.FileName = "InstrumentConfig";
            this.saveFileDialogConf.Filter = "\"txt files (*.ssc)|*.txt|All files (*.*)|*.*\"";
            // 
            // timerChartAddScaled
            // 
            this.timerChartAddScaled.Tick += new System.EventHandler(this.timerChartAddScaled_Tick);
            // 
            // saveFileDialogChart
            // 
            this.saveFileDialogChart.DefaultExt = "csv";
            this.saveFileDialogChart.FileName = "Chart";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatus)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ConfigurationPanel.ResumeLayout(false);
            this.ConfigurationPanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelBaudRate;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label ConnectionTitle;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.PictureBox PictureBoxConnectionStatus;
        private System.Windows.Forms.Label LabelComboPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox ComboBoxParityBits;
        private System.Windows.Forms.ComboBox ComboBoxStopBits;
        private System.Windows.Forms.ComboBox ComboBoxDataBits;
        private System.Windows.Forms.Label LabelParityBits;
        private System.Windows.Forms.Label LabelStopBits;
        private System.Windows.Forms.Label LabelDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxValueS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelAlarmH;
        private System.Windows.Forms.Label labelAlarmL;
        private System.Windows.Forms.Label labelUpperRV;
        private System.Windows.Forms.Label labelLowerRV;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAlarmH;
        private System.Windows.Forms.TextBox textBoxAlarmL;
        private System.Windows.Forms.TextBox textBoxUpperRV;
        private System.Windows.Forms.TextBox textBoxLowerRV;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonLoadToFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Panel ConfigurationPanel;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWriteCommand;
        private System.Windows.Forms.Timer timerSerialReceieveScaled;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConf;
        private System.Windows.Forms.Timer timerChartAddScaled;
        private System.Windows.Forms.Button buttonScaled;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.SaveFileDialog saveFileDialogChart;
    }
}

