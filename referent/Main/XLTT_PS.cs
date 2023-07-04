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
    public partial class XLTT_Monitoring_Parameter : Form
    {
        Thread feedbackXLTT;
        string temp;
        string dataXLTT = null;
        //UdpClient udpXLTT = new UdpClient(1024);
        //string IP_Arduino = "192.168.0.177";
        Int32 localPort_XLTT = 1024;

        public XLTT_Monitoring_Parameter()
        {
            InitializeComponent();
            feedbackXLTT = new Thread(() => { FeedbackArduino(); });
            feedbackXLTT.IsBackground = false;
            feedbackXLTT.Start();
        }
        public void FeedbackArduino()
        {
            //while (true)
            //{
            //IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, localPort_XLTT);
            //Byte[] receiveBytes = udpXLTT.Receive(ref RemoteIpEndPoint);
            //var returnData = Encoding.ASCII.GetString(receiveBytes,0,receiveBytes.Length);
            //MV_1.Invoke(new Action(() => { dataXLTT = returnData; }));
            //MV_1.Invoke(new Action(() => { monitoring(dataXLTT); }));

            //}
            var localIP = IPAddress.Any;
            var localPort = 1024;
            var localEndpoint = new IPEndPoint(localIP, localPort);
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(localEndpoint);
            var size = 1024;
            var receiverBuffer = new byte[size];
            var receiverBuffer_tmp = new byte[size];
            while (true)
            {
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                var length = socket.ReceiveFrom(receiverBuffer, ref remoteEndpoint);
                var temp = Encoding.ASCII.GetString(receiverBuffer, 0, length);
                //MV_1.Invoke(new Action(() => { monitoring(temp); }));


                for (int i = 0; i < length; i++)
                {
                    // HEARD 1
                    string D1 = receiverBuffer[0].ToString("X");
                    // HEARD 2
                    string D2 = receiverBuffer[1].ToString("X");
                    // Type of Data
                    string D3 = receiverBuffer[2].ToString("X");
                    // Length of Data
                    string D4 = receiverBuffer[3].ToString("X");
                    // Data of PS +5V
                    string D5_s = receiverBuffer[4].ToString("X") + receiverBuffer[5].ToString("X");
                    string D5 = convert_String_to_Double_of_PS5(D5_s).ToString();
                    string D6_s = receiverBuffer[6].ToString("X") + receiverBuffer[7].ToString("X");
                    string D6 = convert_String_to_Double_of_PS5(D6_s).ToString();
                    string D7_s = receiverBuffer[8].ToString("X") + receiverBuffer[9].ToString("X");
                    string D7 = convert_String_to_Double_of_PS5(D7_s).ToString();
                    // Data of PS +12V
                    string D8_s = receiverBuffer[10].ToString("X") + receiverBuffer[11].ToString("X");
                    string D8 = convert_String_to_Double_of_PS12(D8_s).ToString();
                    string D9_s = receiverBuffer[12].ToString("X") + receiverBuffer[13].ToString("X");
                    string D9 = convert_String_to_Double_of_PS12(D9_s).ToString();
                    string D10_s = receiverBuffer[14].ToString("X") + receiverBuffer[15].ToString("X");
                    string D10 = convert_String_to_Double_of_PS12(D10_s).ToString();
                    // Data of PS +24V
                    string D11_s = receiverBuffer[16].ToString("X") + receiverBuffer[17].ToString("X");
                    string D11 = convert_String_to_Double_of_PS24(D11_s).ToString();
                    string D12_s = receiverBuffer[18].ToString("X") + receiverBuffer[19].ToString("X");
                    string D12 = convert_String_to_Double_of_PS24(D12_s).ToString();
                    string D13_s = receiverBuffer[20].ToString("X") + receiverBuffer[21].ToString("X");
                    string D13 = convert_String_to_Double_of_PS24(D13_s).ToString();
                    // Data of NONE
                    string D14_s = receiverBuffer[23].ToString("X") + receiverBuffer[22].ToString("X");
                    string D14 = D14_s;
                    string D15_s = receiverBuffer[25].ToString("X") + receiverBuffer[24].ToString("X");
                    string D15 = D15_s;
                    string D16_s = receiverBuffer[27].ToString("X") + receiverBuffer[26].ToString("X");
                    string D16 = D16_s;
                    // Data of storage
                    string D17_s = receiverBuffer[29].ToString("X") + receiverBuffer[28].ToString("X");
                    string D17 = D17_s;
                    string D18_s = receiverBuffer[30].ToString("X");
                    string D18 = D18_s;
                    string D19_s = receiverBuffer[31].ToString("X");
                    string D19 = D19_s;
                    Console.WriteLine(D1 + " " + D2 + " " + D3 + " " + D4 + " " + D5 + " " + D6 + " " + D7 + " " + D8 + " " + D9 + " " + D10 + " " + D11 + " " + D12 + " " + D13 + " " + D14 + " " + D15 + " " + D16 + " " + D17 + " " + D18 + " " + D19);

                }
            }
        }
        double convert_String_to_Double_of_PS27(string number)
        {
            double number_i = Convert.ToInt32(number, 16);
            double number_double = Math.Round(number_i * 27 / 4096,2);
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
        void monitoring(string tamp)
        {
            //Receive value
            //// PS +5V
            //int valueTS01 = Convert.To(tamp[5] + "" + tamp[4]);
            //int valueTS02 = Convert.ToInt32(tamp[7] + "" + tamp[6]);
            //int valueTS03 = Convert.ToInt32(tamp[9] + "" + tamp[8]);
            //// PS +12V
            //int valueTS04 = Convert.ToInt32(tamp[11] + "" + tamp[10]);
            //int valueTS05 = Convert.ToInt32(tamp[13] + "" + tamp[12]);
            //int valueTS06 = Convert.ToInt32(tamp[15] + "" + tamp[14]);
            //// PS +24V
            //int valueTS07 = Convert.ToInt32(tamp[17] + "" + tamp[16]);
            //int valueTS08 = Convert.ToInt32(tamp[19] + "" + tamp[18]);
            //int valueTS09 = Convert.ToInt32(tamp[21] + "" + tamp[20]);
            //// PS -12V 
            //int valueTS10 = Convert.ToInt32(tamp[23] + "" + tamp[22]);
            //// Temp
            //int valueTS11 = Convert.ToInt32(tamp[25] + "" + tamp[24]);
            //// Humd
            //int valueTS12 = Convert.ToInt32(tamp[27] + "" + tamp[26]);
            //// Storage 1
            //int valueTS13 = Convert.ToInt32(tamp[29] + "" + tamp[28]);
            //// Storage 2
            //int valueTS14 = Convert.ToInt32(tamp[30]);
            //// Finish
            //int valueTS15 = Convert.ToInt32(tamp[31]);
            ////compare voltage AC 220V
            //MV_1.Text = Convert.ToString(valueTS01);
            //MV_2.Text = Convert.ToString(valueTS02);
            //MV_3.Text = Convert.ToString(valueTS03);
            //MV_4.Text = Convert.ToString(valueTS04);
            //MV_5.Text = Convert.ToString(valueTS05);
            //MV_6.Text = Convert.ToString(valueTS06);
            //MV_7.Text = Convert.ToString(valueTS07);
            //MV_8.Text = Convert.ToString(valueTS08);
            //MV_9.Text = Convert.ToString(valueTS09);
        }
    }
}

//string temp;
//string dataArduino = null;
//UdpClient udpArduino = new UdpClient(8080);
//string IP_Arduino = "192.168.0.177";
//Int32 localPort_Arduino = 8080;
//Thread feedbackArduino;
//public Form_XLTT_Voltages()
//{
//    InitializeComponent();
//feedbackArduino = new Thread(() => { FeedbackArduino(); });
//feedbackArduino.IsBackground = false;
//feedbackArduino.Start();
//}

//private void FeedbackArduino()
//{
//    while (true)
//    {
//        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
//        Byte[] receiveBytes = udpArduino.Receive(ref RemoteIpEndPoint);
//        string returnData = Encoding.ASCII.GetString(receiveBytes);
//        label_ValueTS01.Invoke(new Action(() => { temp = returnData; }));
//        label_ValueTS01.Invoke(new Action(() => { monitoring(temp); }));
//        Console.WriteLine(returnData);
//    }
//}
//void monitoring(string tamp)
//{
//    // Receive value
//    int valueTS01 = Convert.ToInt32(tamp[0] + "" + tamp[1] + "" + tamp[3] + "" + tamp[4]);
//    int valueTS02 = Convert.ToInt32(tamp[6] + "" + tamp[7] + "" + tamp[9] + "" + tamp[10]);
//    int valueTS03 = Convert.ToInt32(tamp[12] + "" + tamp[13] + "" + tamp[15] + "" + tamp[16]);
//    int valueTS04 = Convert.ToInt32(tamp[18] + "" + tamp[19] + "" + tamp[21] + "" + tamp[22]);
//    int valueTS05 = Convert.ToInt32(tamp[24] + "" + tamp[25] + "" + tamp[27] + "" + tamp[28]);
//    int valueTS06 = Convert.ToInt32(tamp[30] + "" + tamp[31] + "" + tamp[33] + "" + tamp[34]);
//    int valueTS07 = Convert.ToInt32(tamp[36] + "" + tamp[37] + "" + tamp[39] + "" + tamp[40]);
// compare voltage AC 220V
//    KL_TS01.Text = Convert.ToString(valueTS01);
//    KL_TS02.Text = Convert.ToString(valueTS02);
//    KL_TS03.Text = Convert.ToString(valueTS03);
//    KL_TS04.Text = Convert.ToString(valueTS04);
//    KL_TS05.Text = Convert.ToString(valueTS05);
//    KL_TS06.Text = Convert.ToString(valueTS06);
//    KL_TS07.Text = Convert.ToString(valueTS07);
//    if (valueTS01 >= 210 && valueTS01 <= 230)
//    {
//        Status_TS01.BackColor = Color.Chartreuse;
//        Status_TS01.Text = "ĐẠT";
//        lable_note_TS02.Visible = false;
//        if (valueTS02 >= 210 && valueTS02 <= 230)
//        {
//            Status_TS02.BackColor = Color.Chartreuse;
//            Status_TS02.Text = "ĐẠT";
//        }
//        else if(valueTS02 > 230)
//        {
//            Status_TS02.BackColor = Color.Red;
//            Status_TS02.Text = "KHÔNG ĐẠT";
//            lable_note_TS02.Visible = true;
//            lable_note_TS02.Text = "CAO";
//            lable_note_TS02.ForeColor = Color.Red;
//        }
//        else if(valueTS02 < 210 && valueTS02 >= 10)
//        {
//            Status_TS02.BackColor = Color.Red;
//            Status_TS02.Text = "KHÔNG ĐẠT";
//            lable_note_TS02.Visible = true;
//            lable_note_TS02.Text = "THẤP";
//            lable_note_TS02.ForeColor = Color.Red;
//        }
//        else if(valueTS02 < 10)
//        {
//            Status_TS02.BackColor = Color.Red;
//            Status_TS02.Text = "KHÔNG ĐẠT";
//            lable_note_TS02.Visible = false;
//        }    
//        // compare voltage DC
//        // compare voltage +27V
//        if (valueTS03 >= 26 && valueTS03 <= 28)
//        {
//            Status_TS03.BackColor = Color.Chartreuse;
//            Status_TS03.Text = "ĐẠT";
//        }
//        else
//        {
//            Status_TS03.BackColor = Color.Red;
//            Status_TS03.Text = "KHÔNG ĐẠT";
//        }
//        // compare voltage +24V
//        if (valueTS04 >= 23 && valueTS04 <= 25)
//        {
//            Status_TS04.BackColor = Color.Chartreuse;
//            Status_TS04.Text = "ĐẠT";
//        }
//        else
//        {
//            Status_TS04.BackColor = Color.Red;
//            Status_TS04.Text = "KHÔNG ĐẠT";
//        }
//        // compare voltage +12V
//            if (valueTS05 >= 11 && valueTS05 <= 13)
//            {
//                Status_TS05.BackColor = Color.Chartreuse;
//                Status_TS05.Text = "ĐẠT";
//            }
//            else
//            {
//                Status_TS05.BackColor = Color.Red;
//                Status_TS05.Text = "KHÔNG ĐẠT";
//            }
//            // compare voltage +5V
//            if (valueTS06 >= 4 && valueTS06 <= 6)
//            {
//                Status_TS06.BackColor = Color.Chartreuse;
//                Status_TS06.Text = "ĐẠT";
//            }
//            else
//            {
//                Status_TS06.BackColor = Color.Red;
//                Status_TS06.Text = "KHÔNG ĐẠT";
//            }
//            // compare voltage -12V
//            if (valueTS07 >= 11 && valueTS05 <= 13)
//            {
//                Status_TS07.BackColor = Color.Chartreuse;
//                Status_TS07.Text = "ĐẠT";
//            }
//            else
//            {
//                Status_TS07.BackColor = Color.Red;
//                Status_TS07.Text = "KHÔNG ĐẠT";
//            }
//    }
//    else
//    {
//        Status_TS01.BackColor = Color.Red;
//        Status_TS01.Text = "KHÔNG ĐẠT";

//        Status_TS02.BackColor = Color.Red;
//        Status_TS02.Text = "KHÔNG ĐẠT";

//        Status_TS03.BackColor = Color.Red;
//        Status_TS03.Text = "KHÔNG ĐẠT";

//        Status_TS04.BackColor = Color.Red;
//        Status_TS04.Text = "KHÔNG ĐẠT";

//        Status_TS05.BackColor = Color.Red;
//        Status_TS05.Text = "KHÔNG ĐẠT";

//        Status_TS06.BackColor = Color.Red;
//        Status_TS06.Text = "KHÔNG ĐẠT";

//        Status_TS07.BackColor = Color.Red;
//        Status_TS07.Text = "KHÔNG ĐẠT";
//    }

//}


// copy to feedback
//var localIP = IPAddress.Any;
//var localPort = 1024;
//var localEndpoint = new IPEndPoint(localIP, localPort);
//var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
//socket.Bind(localEndpoint);
//var size = 1024;
//var receiverBuffer = new byte[size];
//var receiverBuffer_tmp = new byte[size];
//while (true)
//{
//    EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
//    var length = socket.ReceiveFrom(receiverBuffer, ref remoteEndpoint);
//    var temp = Encoding.ASCII.GetString(receiverBuffer, 0, length);
//    //MV_1.Invoke(new Action(() => { monitoring(temp); }));


//    for (int i = 0; i < length; i++)
//    {
//        // HEARD 1
//        string D1 = receiverBuffer[0].ToString("X");
//        // HEARD 2
//        string D2 = receiverBuffer[1].ToString("X");
//        // Type of Data
//        string D3 = receiverBuffer[2].ToString("X");
//        // Length of Data
//        string D4 = receiverBuffer[3].ToString("X");
//        // Data of PS +5V
//        string D5_s = receiverBuffer[5].ToString("X") + receiverBuffer[4].ToString("X");
//        string D5 = convert_String_to_Double_of_PS5(D5_s).ToString();
//        string D6_s = receiverBuffer[7].ToString("X") + receiverBuffer[6].ToString("X");
//        string D6 = convert_String_to_Double_of_PS5(D6_s).ToString();
//        string D7_s = receiverBuffer[9].ToString("X") + receiverBuffer[8].ToString("X");
//        string D7 = convert_String_to_Double_of_PS5(D7_s).ToString();
//        // Data of PS +12V
//        string D8_s = receiverBuffer[11].ToString("X") + receiverBuffer[10].ToString("X");
//        string D8 = convert_String_to_Double_of_PS12(D8_s).ToString();
//        string D9_s = receiverBuffer[13].ToString("X") + receiverBuffer[12].ToString("X");
//        string D9 = convert_String_to_Double_of_PS12(D9_s).ToString();
//        string D10_s = receiverBuffer[15].ToString("X") + receiverBuffer[14].ToString("X");
//        string D10 = convert_String_to_Double_of_PS12(D10_s).ToString();
//        // Data of PS +24V
//        string D11_s = receiverBuffer[17].ToString("X") + receiverBuffer[16].ToString("X");
//        string D11 = convert_String_to_Double_of_PS24(D11_s).ToString();
//        string D12_s = receiverBuffer[19].ToString("X") + receiverBuffer[18].ToString("X");
//        string D12 = convert_String_to_Double_of_PS24(D12_s).ToString();
//        string D13_s = receiverBuffer[21].ToString("X") + receiverBuffer[20].ToString("X");
//        string D13 = convert_String_to_Double_of_PS24(D13_s).ToString();
//        // Data of NONE
//        string D14_s = receiverBuffer[23].ToString("X") + receiverBuffer[22].ToString("X");
//        string D14 = D14_s;
//        string D15_s = receiverBuffer[25].ToString("X") + receiverBuffer[24].ToString("X");
//        string D15 = D15_s;
//        string D16_s = receiverBuffer[27].ToString("X") + receiverBuffer[26].ToString("X");
//        string D16 = D16_s;
//        // Data of storage
//        string D17_s = receiverBuffer[29].ToString("X") + receiverBuffer[28].ToString("X");
//        string D17 = D17_s;
//        string D18_s = receiverBuffer[30].ToString("X");
//        string D18 = D18_s;
//        string D19_s = receiverBuffer[31].ToString("X");
//        string D19 = D19_s;
//        Console.WriteLine(Convert.ToInt32(temp[0] + "" + temp[1]));
//        Console.WriteLine(D1 + " " + D2 + " " + D3 + " " + D4 + " " + D5 + " " + D6 + " " + D7 + " " + D8 + " " + D9 + " " + D10 + " " + D11 + " " + D12 + " " + D13 + " " + D14 + " " + D15 + " " + D16 + " " + D17 + " " + D18 + " " + D19);

//    }
//}