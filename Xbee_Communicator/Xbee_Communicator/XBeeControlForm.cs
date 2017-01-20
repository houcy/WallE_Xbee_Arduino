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

namespace Xbee_Communicator
{
    public partial class XbeeControlForm : Form
    {

        public XbeeControlForm()
        {

            InitializeComponent();
            getAvailablePorts();
            this.KeyDown += XbeeControlForm_KeyDown;
            this.KeyUp += XbeeControlForm_KeyUp;
            SerialPortGuardingTimer.Tick += SerialPortGuardingTimer_Tick;
            Distance = new char[10];
            ControlSignal = " ";
        }

        private void XbeeControlForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (comboBox_PortName.Text == "")
            {
                
            } else
            {
                serialPort1.PortName = comboBox_PortName.Text;
                serialPort1.BaudRate = Convert.ToInt32(9600);
                serialPort1.Open();
                isStart = true;
                OpenPortButton.Enabled = false;
                ClosePortButton.Enabled = true;
            }
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            isStart = false;
            serialPort1.Close();
            OpenPortButton.Enabled = true;
            ClosePortButton.Enabled = false;
        }


        void getAvailablePorts()
        {
            string[] AvailabePorts = SerialPort.GetPortNames();
            comboBox_PortName.Items.AddRange(AvailabePorts);
        }

    }
}
