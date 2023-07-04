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
using NationalInstruments.Visa;
using Ivi.Visa;

namespace GT2022_V2.Devices
{
    public partial class TTi_1908P : Form
    {
        private MessageBasedSession Visa_1908P;
        string IPaddress_1908P = "TCPIP0::169.254.90.147::9221::SOCKET";
        public TTi_1908P()
        {
            InitializeComponent();
            Initial_1908P();
        }
        void Initial_1908P()
        {
            using (var Multimeter1908P = new ResourceManager())
            {
                try
                {
                    Visa_1908P = (MessageBasedSession)Multimeter1908P.Open(IPaddress_1908P);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Resource selected must be a message-based session");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void button_GET_Click(object sender, EventArgs e)
        {
            textBox_Feedback.Text = Visa_1908P.FormattedIO.ReadLine();
        }

        private void button_SET_Click(object sender, EventArgs e)
        {
            Visa_1908P.RawIO.Write(comboBox_command.Text+"\n");
            compare_notes(comboBox_command.Text);
            if(textBox_Feedback.Text != null)
            {
                textBox_Feedback.Text = null;
            }
        }

        private void TTi_1908P_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Visa_1908P.Dispose();
        }
        void compare_notes(string command)
        {
            if(command == "VDC 10V")
            {
                label_Notes.Text = "Sets the main display to dc Volts and optionally sets the range; if no range is specified the display defaults to autorange.The following<CPD> can be used to set the range:< 100MV >,< 1000MV >,< 10V >,< 100V >,< 1000V > ";
            }
            else if(command == "VAC 100V")
            {
                label_Notes.Text = "Sets the main display to ac Volts and optionally sets the range; if no range is specified the display defaults to autorange.The following<CPD> can be used to set the range: < 100MV >,< 1000MV >,< 10V >,< 100V >,< 750V > ";
            }
            else if(command == "OHMS")
            {
                label_Notes.Text = "Sets the main display to two wire Ohms and optionally sets the range; if no range is specified the display defaults to autorange. The following<CPD> can be used to set the range: < 100 >,< 1000 >,< 10K >,< 100K >,< 1000K >,< 10M > ";
            }
            else if(command == "READ?")
            {
                label_Notes.Text = "Returns the next reading from the main display immediately after the command has been parsed.You click on GET button and result will show on display";
            }
        }

        private void TTi_1908P_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Visa_1908P != null)
            {
                Visa_1908P.Dispose();
            }
        }
    }
}
