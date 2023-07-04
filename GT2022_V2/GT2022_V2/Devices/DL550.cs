using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using Ivi.Visa;

namespace GT2022_V2.Devices
{
    public partial class DL550 : Form
    {
        private MessageBasedSession Visa_DL550 = null;
        string IPaddress_DL550 = "TCPIP0::169.254.122.0::10733::SOCKET";
        public DL550()
        {
            InitializeComponent();
            Initial_DL550();
        }
        void Initial_DL550()
        {
            using (var DL = new ResourceManager())
            {
                try
                {
                    Visa_DL550 = (MessageBasedSession)DL.Open(IPaddress_DL550);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Resource selected must be a message-based session");
                }
                catch (Exception exp)
                {
                    DialogResult dlr = MessageBox.Show("Kiểm tra lại kết nối hoặc chờ đến khi biểu tượng LAN trên màn hình DL550 chuyển từ vàng sang xanh dương", "Thông báo", MessageBoxButtons.OKCancel);
                    if(dlr == DialogResult.OK)
                    {
                        //this.Dispose();
                    }
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void DL550_Load(object sender, EventArgs e)
        {
            
        }

        private void button_GET_Click(object sender, EventArgs e)
        {
            string feedback = Visa_DL550.FormattedIO.ReadLine();
            textBox_Feedback.Text = Convert_feedback(feedback);
            //textBox_Feedback.Text = Visa_DL550.FormattedIO.ReadLine();
        }
        string Convert_feedback(string feedback)
        {
            string[] arrListStr = feedback.Split(new char[] { 'e' });
            float N1 = float.Parse(arrListStr[0]);
            int N2 = int.Parse(arrListStr[1]);
            int j = 1;
            if (N2 >= 0)
            {
                for (int i = 0; i < N2; i++)
                {
                    j = j * 10;
                }
            }
            else if (N2 < 0)
            {
                for (int i = N2; i < 0; i++)
                {
                    j = j / 10;
                }
            }
            float N3 = N1 * j;
            return N3.ToString();
        }

        private void DL550_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Visa_DL550 != null)
            {
                Visa_DL550.Dispose();
            }    
            
        }

        private void button_SET_Click(object sender, EventArgs e)
        {
            Visa_DL550.RawIO.Write(comboBox_command.Text+"\n");
            compare_Notes(comboBox_command.Text);
            if(textBox_Feedback.Text != null)
            {
                textBox_Feedback.Text = null;
            }
        }
        void compare_Notes(string command)
        {
            if(command == "SOURce:LVLA:BASic:CC:VALue 0.4")
            {
                label_Note.Text = "Basic level CC current: sets the loading current.";
            }
            else if(command == "SOURce:LVLA:BASic:CC:VALue 1")
            {
                label_Note.Text = "Basic level CC current: sets the loading current.";
            }
            else if(command == "MEASure:REALtime:Power?")
            {
                label_Note.Text = "Queries the real-time power measurement. The response is a single NR3 value. If for some reason the power measurement is not available, the value will be reported as 9.91E37.";
            }
            else if (command == "MEASure:REALtime:VOLTage?")
            {
                label_Note.Text = "Queries the real-time voltage measurement. The response is a single NR3 value. If for some reason the voltage measurement is not available, the value will be reported as 9.91E37.";
            }
            else if (command == "MEASure:REALtime:Current?")
            {
                label_Note.Text = "Queries the real-time current measurement. The response is a single NR3 value. If for some reason the voltage measurement is not available, the value will be reported as 9.91E37.";
            }
            else if (command == "MEASure:REALtime:Resistance?")
            {
                label_Note.Text = "Queries the real-time resistance measurement. The response is a single NR3 value. If for some reason the resistance measurement is not available, the value will be reported as 9.91E37.";
            }
        }

        private void DL550_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
