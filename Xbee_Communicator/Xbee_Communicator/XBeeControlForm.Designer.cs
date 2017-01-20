using System;
using System.Windows.Forms;
using System.IO.Ports;
namespace Xbee_Communicator
{
    partial class XbeeControlForm
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.ClosePortButton = new System.Windows.Forms.Button();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.SerialPortGuardingTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(18, 79);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(75, 23);
            this.OpenPortButton.TabIndex = 0;
            this.OpenPortButton.Text = "Open Port";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.Location = new System.Drawing.Point(112, 79);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.Size = new System.Drawing.Size(75, 23);
            this.ClosePortButton.TabIndex = 1;
            this.ClosePortButton.Text = "Close Port";
            this.ClosePortButton.UseVisualStyleBackColor = true;
            this.ClosePortButton.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(78, 33);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PortName.TabIndex = 2;
            //this.comboBox_PortName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SerialPortGuardingTimer
            // 
            this.SerialPortGuardingTimer.Enabled = true;
            this.SerialPortGuardingTimer.Interval = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClosePortButton);
            this.groupBox1.Controls.Add(this.comboBox_PortName);
            this.groupBox1.Controls.Add(this.OpenPortButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Distance measured (cm):";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 65);
            this.label4.TabIndex = 5;
            this.label4.Text = "- Press W to move forwards\r\n- Press S to move backwards\r\n- Press A to turn left\r\n" +
    "- Press D to turn right\r\n- Press J/K to look left/right";
            //this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(239, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 112);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruction";
            // 
            // XbeeControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "XbeeControlForm";
            this.Text = "WallE Control";
            this.Load += new System.EventHandler(this.XbeeControlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        bool isSending;
        public SerialPort serialPort1;
        private Button OpenPortButton;
        private Button ClosePortButton;
        private ComboBox comboBox_PortName;
        public string ControlSignal;
        //public string Distance;
        public char[] Distance;
        public bool isStart;

        private void XbeeControlForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.W:
                    ControlSignal = "w";
                    break;
                case Keys.A:
                    ControlSignal = "a";
                    break;
                case Keys.D:
                    ControlSignal = "d";
                    break;
                case Keys.S:
                    ControlSignal = "s";
                    break;
                case Keys.J:
                    ControlSignal = "j";
                    break;
                case Keys.K:
                    ControlSignal = "k";
                    break;
                case Keys.O:
                    ControlSignal = "o";
                    break;
                default:
                    ControlSignal = " ";
                    break;
            }
  
        }



        private void XbeeControlForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D) || (e.KeyCode == Keys.A) ||
                (e.KeyCode == Keys.W) || (e.KeyCode == Keys.S) ||
                (e.KeyCode == Keys.J) || (e.KeyCode == Keys.K) ||
                (e.KeyCode == Keys.P) || (e.KeyCode == Keys.O) 
                )
            {
                ControlSignal = " ";
            }
        }

        private Timer SerialPortGuardingTimer;
        string strResult;
        void SerialPortGuardingTimer_Tick(object sender, System.EventArgs e)
        {
            if (isStart != true)
            {

            }
            else
            {
                if (isSending)
                {
                    serialPort1.Write(ControlSignal);
                    isSending = false;
                }
                else
                {
                    strResult = "";
                    int NumberOfBytesToRead = serialPort1.BytesToRead;
                    if (NumberOfBytesToRead > 10)
                    {
                        NumberOfBytesToRead = 10;
                    }
                    serialPort1.Read(Distance, 0, NumberOfBytesToRead);
                    serialPort1.DiscardInBuffer();
                    int index = 0;
                    try
                    {
                        int length = Convert.ToInt32(Convert.ToString(Distance[index]));
                        for (int number_index = index + 1; number_index <= index + length; number_index++)
                        {
                            strResult += Convert.ToString(Distance[number_index]);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    isSending = true;
                    label3.Text = strResult;
                }
            }
            
        }

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
    }
}

