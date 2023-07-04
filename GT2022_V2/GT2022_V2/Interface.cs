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

namespace GT2022_V2
{
    public partial class Interface : UserControl
    {
        
        public Interface()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            SendtoArduino();    
        }
        private void SendtoArduino()
        {
            try
            {
                UdpClient udpClient = new UdpClient(8080);
                string IP_Arduino = "192.168.0.177";
                Int32 localPort_Arduino = 8080;
                udpClient.Connect(IP_Arduino, localPort_Arduino);
                string Datasend = "1234";
                label_Result1.Text = Datasend;
                Byte[] SendData = Encoding.ASCII.GetBytes(Datasend);
                udpClient.Send(SendData, SendData.Length);
                udpClient.Dispose();
            }
            catch
            {
                MessageBox.Show("Can't connect with Arduino!");
            }
        }
        private void ReceiData()
        {
            //nhan it du lieu
            while (true)
            {
                UdpClient udpClient = new UdpClient(8080);
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                label_Result2.Text = returnData;
                Console.WriteLine(returnData);
                udpClient.Dispose();
                break;
            }
            // nhan nhieu du lieu
            //var localIP = IPAddress.Any;
            //var localPort = 8080;
            //var localEndpoint = new IPEndPoint(localIP, localPort);
            //var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ////socket.Bind(localEndpoint);
            //var size = 1024;
            //var receiverBuffer = new byte[size];
            //while (true)
            //{

            //    EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            //    var length = socket.ReceiveFrom(receiverBuffer, ref remoteEndpoint);
            //    var text = Encoding.ASCII.GetString(receiverBuffer, 0, length);
            //    label_Result2.Text = text;
            //}

        }
        void Demo()
        {
            //while (true)
            {
                UdpClient udpClient = new UdpClient(8080);
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                label_Result4.Invoke(new Action(() => { label_Result4.Text = returnData; }));
                Console.WriteLine(returnData);
                udpClient.Dispose();
            }
        }


        private void button_Recei_Click(object sender, EventArgs e)
        {
            ReceiData();
        }

        private void button_Auto_Click(object sender, EventArgs e)
        {
            Thread receiverData = new Thread(() => { Demo(); });
            receiverData.Start();
        }


    }
}
