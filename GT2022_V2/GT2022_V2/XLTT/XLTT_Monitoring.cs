using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace GT2022_V2.XLTT
{
    public partial class XLTT_Monitoring : Form
    {
        Thread feedbackXLTT;
        UdpClient udpXLTT = new UdpClient(1024);
        //UdpClient udpXLTT;
        Int32 localPort_XLTT = 1024;
        string IP_XLTT = "169.254.1.7";

        public XLTT_Monitoring()
        {

            InitializeComponent();
            feedbackXLTT = new Thread(() => { ReceiverData(); });
            feedbackXLTT.IsBackground = false;
            feedbackXLTT.Start();
        }
        // if use this void, initial UdpClient udpXLTT;
        // void for UDP
        public bool CheckConnect()
        {
            try
            {
                udpXLTT.Connect(IP_XLTT, localPort_XLTT);
                return true;
            }
            catch
            {
                MessageBox.Show("Recheck the connection to the block CPCU-0031-VN");
                return false;
            }

        }
        public void ReceiverData()
        {
            while(CheckConnect())
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes;
                try
                {
                    receiveBytes = udpXLTT.Receive(ref RemoteIpEndPoint);
                    label_Value_1.Invoke(new Action(() => { monitoring(receiveBytes); }));
                }
                catch
                {
                    break;
                }
                
            }
        }
        // if use this void, remove UdpClient udpXLTT;
        // void for socket
        //public void ReceiverData()
        //{
        //    var localIP = IPAddress.Any;
        //    var localPort = 1024;
        //    var localEndpoint = new IPEndPoint(localIP, localPort);
        //    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        //    socket.Bind(localEndpoint);
        //    var size = 1024;
        //    var receiverBuffer = new byte[size];
        //    byte[] receiverBuffer_tmp = new byte[size];
        //    while (true)
        //    {
        //        EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
        //        var length = socket.ReceiveFrom(receiverBuffer, ref remoteEndpoint);
        //        var temp = Encoding.ASCII.GetString(receiverBuffer, 0, length);
        //        Console.WriteLine(receiverBuffer[0]);
        //        label_Value_1.Invoke(new Action(() => { receiverBuffer_tmp = receiverBuffer; }));
        //        label_Value_1.Invoke(new Action(() => { monitoring(receiverBuffer_tmp); }));
        //    }

        //}
        double convert_String_to_Double_of_PS27(string number)
        {
            double number_i = Convert.ToInt32(number, 16);
            double number_double = Math.Round(number_i * 27 / 4096, 2);
            return number_double;
        }
        double convert_String_to_Double_of_PS24(string number)
        {
            double number_i = Convert.ToInt32(number, 16);
            double number_double = Math.Round(number_i * 27 / 4096, 2);
            return number_double;
        }
        double convert_String_to_Double_of_PS12(string number)
        {
            double number_i = Convert.ToInt32(number, 16);
            double number_double = Math.Round(number_i * 15 / 4096, 2);
            return number_double;
        }
        double convert_String_to_Double_of_PS5(string number)
        {
            double number_i = Convert.ToInt32(number, 16);
            double number_double = Math.Round(number_i * 6 / 4096, 2);
            return number_double;
        }
        Color convert_color_PS5(float color)
        {
            if (color >= 4.5 && color <= 5.5)
            {
                return Color.GreenYellow;
            }
            else
                return Color.Red;
        }
        Color convert_color_PS12(float color)
        {
            if (color >= 11.5 && color <= 12.5)
            {
                return Color.GreenYellow;
            }
            else
                return Color.Red;
        }
        Color convert_color_PS24(float color)
        {
            if (color >= 23.5 && color <= 25.5)
            {
                return Color.GreenYellow;
            }
            else
                return Color.Red;
        }
        private void monitoring(byte[] temp)
        {
            for (int i = 0; i < 31; i++)
            {
                // HEARD 1
                string D1 = temp[0].ToString("X");
                // HEARD 2
                string D2 = temp[1].ToString("X");
                // Type of Data
                string D3 = temp[2].ToString("X");
                // Length of Data
                string D4 = temp[3].ToString("X");
                // Data of PS +5V
                string D5_s = temp[4].ToString("X") + temp[5].ToString("X");
                string D5 = convert_String_to_Double_of_PS5(D5_s).ToString();
                label_Stt_1.BackColor = convert_color_PS5((float)convert_String_to_Double_of_PS5(D5_s));
                string D6_s = temp[6].ToString("X") + temp[7].ToString("X");
                string D6 = convert_String_to_Double_of_PS5(D6_s).ToString();
                label_Stt_2.BackColor = convert_color_PS5((float)convert_String_to_Double_of_PS5(D6_s));
                string D7_s = temp[8].ToString("X") + temp[9].ToString("X");
                string D7 = convert_String_to_Double_of_PS5(D7_s).ToString();
                label_Stt_3.BackColor = convert_color_PS5((float)convert_String_to_Double_of_PS5(D7_s));
                // Data of PS +12V
                string D8_s = temp[10].ToString("X") + temp[11].ToString("X");
                string D8 = convert_String_to_Double_of_PS12(D8_s).ToString();
                label_Stt_4.BackColor = convert_color_PS12((float)convert_String_to_Double_of_PS12(D8_s));
                string D9_s = temp[12].ToString("X") + temp[13].ToString("X");
                string D9 = convert_String_to_Double_of_PS12(D9_s).ToString();
                label_Stt_5.BackColor = convert_color_PS12((float)convert_String_to_Double_of_PS12(D9_s));
                string D10_s = temp[14].ToString("X") + temp[15].ToString("X");
                string D10 = convert_String_to_Double_of_PS12(D10_s).ToString();
                label_Stt_6.BackColor = convert_color_PS12((float)convert_String_to_Double_of_PS12(D10_s));
                // Data of PS +24V
                string D11_s = temp[16].ToString("X") + temp[17].ToString("X");
                string D11 = convert_String_to_Double_of_PS24(D11_s).ToString();
                label_Stt_7.BackColor = convert_color_PS24((float)convert_String_to_Double_of_PS24(D11_s));
                string D12_s = temp[18].ToString("X") + temp[19].ToString("X");
                string D12 = convert_String_to_Double_of_PS24(D12_s).ToString();
                label_Stt_8.BackColor = convert_color_PS24((float)convert_String_to_Double_of_PS24(D12_s));
                string D13_s = temp[20].ToString("X") + temp[21].ToString("X");
                string D13 = convert_String_to_Double_of_PS24(D13_s).ToString();
                label_Stt_9.BackColor = convert_color_PS24((float)convert_String_to_Double_of_PS24(D13_s));
                // Data of NONE
                string D14_s = temp[23].ToString("X") + temp[22].ToString("X");
                string D14 = D14_s;
                string D15_s = temp[25].ToString("X") + temp[24].ToString("X");
                string D15 = D15_s;
                string D16_s = temp[27].ToString("X") + temp[26].ToString("X");
                string D16 = D16_s;
                // Data of storage
                string D17_s = temp[29].ToString("X") + temp[28].ToString("X");
                string D17 = D17_s;
                string D18_s = temp[30].ToString("X");
                string D18 = D18_s;
                string D19_s = temp[31].ToString("X");
                string D19 = D19_s;
                label_Value_1.Text = D5;
                label_Value_2.Text = D6;
                label_Value_3.Text = D7;
                label_Value_4.Text = D8;
                label_Value_5.Text = D9;
                label_Value_6.Text = D10;
                label_Value_7.Text = D11;
                label_Value_8.Text = D12;
                label_Value_9.Text = D13;
            }
        }

        private void XLTT_Monitoring_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpXLTT.Close();
            udpXLTT.Dispose();
        }

    }
}
