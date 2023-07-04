using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace GT2022_V2.XLTT
{
    public partial class XLTT__RelayControl : Form
    {
        UdpClient udpXLTT = new UdpClient(1023);
        string IP_XLTT = "192.168.1.7";
        Int32 localPort_XLTT = 1024;
        bool[] M2_Control = new bool[] { }; 
        Byte[] SendData = new byte[] { 0xAA, 0x55, 0x01, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x23 };
        public XLTT__RelayControl()
        {
            InitializeComponent();
            Connect_CPCU();
        }
        public bool CheckConnect()
        {
            try
            {
                udpXLTT.Connect(IP_XLTT, localPort_XLTT);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Connect_CPCU()
        {
            if (CheckConnect() == true)
            {
                udpXLTT.Send(SendData, SendData.Length);
            }
            else
                MessageBox.Show("Recheck the connection to the block CPCU-0031-VN");
        }
        // close form
        private void XLTT__RelayControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpXLTT.Dispose();
            udpXLTT.Close();
        }
        // Control M2
        private void checkBox_M2_ON_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_ON.Checked == true)
            {
                for (int i = 4; i < 14; i++)
                {
                    SendData[i] = 0x0A;
                }
                if(checkBox_M2_OFF.Checked == true)
                {
                    checkBox_M2_OFF.Checked = false;
                }
            }
            else if (checkBox_M2_ON.Checked == false)
            {
                for (int i = 4; i < 14; i++)
                {
                    SendData[i] = 0x00;
                }
            }
            udpXLTT.Send(SendData, SendData.Length);
        }
        private void checkBox_M2_OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_OFF.Checked == true)
            {
                for (int i = 4; i < 14; i++)
                {
                    SendData[i] = 0x00;
                }
                if(checkBox_M2_ON.Checked == true)
                {
                    checkBox_M2_ON.Checked = false;
                }
            }
            udpXLTT.Send(SendData, SendData.Length);
            checkBox_M2_OFF.Checked = false;
        }

        private void checkBox_M2_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_M2_CH1.Checked ==  true)
            {
                SendData[4] = 0x0A;
            }
            else if(checkBox_M2_CH1.Checked == false)
            {
                SendData[4] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH2.Checked == true)
            {
                SendData[5] = 0x0A;
            }
            else if (checkBox_M2_CH2.Checked == false)
            {
                SendData[5] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH3.Checked == true)
            {
                SendData[6] = 0x0A;
            }
            else if (checkBox_M2_CH3.Checked == false)
            {
                SendData[6] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH4.Checked == true)
            {
                SendData[7] = 0x0A;
            }
            else if (checkBox_M2_CH4.Checked == false)
            {
                SendData[7] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH5.Checked == true)
            {
                SendData[8] = 0x0A;
            }
            else if (checkBox_M2_CH5.Checked == false)
            {
                SendData[8] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH6.Checked == true)
            {
                SendData[9] = 0x0A;
            }
            else if (checkBox_M2_CH6.Checked == false)
            {
                SendData[9] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH7.Checked == true)
            {
                SendData[10] = 0x0A;
            }
            else if (checkBox_M2_CH7.Checked == false)
            {
                SendData[10] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH8.Checked == true)
            {
                SendData[11] = 0x0A;
            }
            else if (checkBox_M2_CH8.Checked == false)
            {
                SendData[11] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH9.Checked == true)
            {
                SendData[12] = 0x0A;
            }
            else if (checkBox_M2_CH9.Checked == false)
            {
                SendData[12] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M2_CH10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M2_CH10.Checked == true)
            {
                SendData[13] = 0x0A;
            }
            else if (checkBox_M2_CH10.Checked == false)
            {
                SendData[13] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }
        // Control M5
        private void checkBox_M5_ON_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_ON.Checked == true)
            {
                for (int i = 14; i < 24; i++)
                {
                    SendData[i] = 0x0A;
                }
                if (checkBox_M5_OFF.Checked == true)
                {
                    checkBox_M5_OFF.Checked = false;
                }
            }
            else if (checkBox_M5_ON.Checked == false)
            {
                for (int i = 14; i < 24; i++)
                {
                    SendData[i] = 0x00;
                }
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_OFF.Checked == true)
            {
                for (int i = 14; i < 24; i++)
                {
                    SendData[i] = 0x00;
                }
                if (checkBox_M5_ON.Checked == true)
                {
                    checkBox_M5_ON.Checked = false;
                }
            }
            udpXLTT.Send(SendData, SendData.Length);
            checkBox_M5_OFF.Checked = false;
        }
        private void checkBox_M5_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH1.Checked == true)
            {
                SendData[14] = 0x0A;
            }
            else if (checkBox_M5_CH1.Checked == false)
            {
                SendData[14] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH2.Checked == true)
            {
                SendData[15] = 0x0A;
            }
            else if (checkBox_M5_CH2.Checked == false)
            {
                SendData[15] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH3.Checked == true)
            {
                SendData[16] = 0x0A;
            }
            else if (checkBox_M5_CH3.Checked == false)
            {
                SendData[16] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH4.Checked == true)
            {
                SendData[17] = 0x0A;
            }
            else if (checkBox_M5_CH4.Checked == false)
            {
                SendData[17] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH5.Checked == true)
            {
                SendData[18] = 0x0A;
            }
            else if (checkBox_M5_CH5.Checked == false)
            {
                SendData[18] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH6.Checked == true)
            {
                SendData[19] = 0x0A;
            }
            else if (checkBox_M5_CH6.Checked == false)
            {
                SendData[19] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH7.Checked == true)
            {
                SendData[20] = 0x0A;
            }
            else if (checkBox_M5_CH7.Checked == false)
            {
                SendData[20] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH8.Checked == true)
            {
                SendData[21] = 0x0A;
            }
            else if (checkBox_M5_CH8.Checked == false)
            {
                SendData[21] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH9.Checked == true)
            {
                SendData[22] = 0x0A;
            }
            else if (checkBox_M5_CH9.Checked == false)
            {
                SendData[22] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M5_CH10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M5_CH10.Checked == true)
            {
                SendData[23] = 0x0A;
            }
            else if (checkBox_M5_CH10.Checked == false)
            {
                SendData[23] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        // control M3
        private void checkBox_M3_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH1.Checked == true)
            {
                SendData[27] = 0x01;
            }
            else if (checkBox_M3_CH1.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH2.Checked == true)
            {
                SendData[27] = 0x02;
            }
            else if (checkBox_M3_CH2.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH3.Checked == true)
            {
                SendData[27] = 0x03;
            }
            else if (checkBox_M3_CH3.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH4.Checked == true)
            {
                SendData[27] = 0x04;
            }
            else if (checkBox_M3_CH4.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH5.Checked == true)
            {
                SendData[27] = 0x05;
            }
            else if (checkBox_M3_CH5.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH6.Checked == true)
            {
                SendData[27] = 0x06;
            }
            else if (checkBox_M3_CH6.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH7.Checked == true)
            {
                SendData[27] = 0x07;
            }
            else if (checkBox_M3_CH7.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH8.Checked == true)
            {
                SendData[27] = 0x08;
            }
            else if (checkBox_M3_CH8.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH9.Checked == true)
            {
                SendData[27] = 0x09;
            }
            else if (checkBox_M3_CH9.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }

        private void checkBox_M3_CH10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_M3_CH10.Checked == true)
            {
                SendData[27] = 0x0A;
            }
            else if (checkBox_M3_CH10.Checked == false)
            {
                SendData[27] = 0x00;
            }
            udpXLTT.Send(SendData, SendData.Length);
        }
    }
}
