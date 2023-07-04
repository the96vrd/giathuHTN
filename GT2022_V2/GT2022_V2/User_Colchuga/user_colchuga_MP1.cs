using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT2022_V2.User_Colchuga
{
    public partial class user_colchuga_MP1 : UserControl
    {
        public user_colchuga_MP1()
        {
            InitializeComponent();
        }

        private void button_Step2_Click(object sender, EventArgs e)
        {
            button_Step3.Visible = true;
            label_Step3.Visible = true;
            label_Result3.Visible = true;
        }

        private void button_Step1_Click(object sender, EventArgs e)
        {
            button_Step2.Visible = true;
            label_Step2.Visible = true;
            label_Result2.Visible = true;
        }

        private void button_Step3_Click(object sender, EventArgs e)
        {
            button_Step4.Visible = true;
            label_Step4.Visible = true;
            label_Result4.Visible = true;
        }

        private void button_Step4_Click(object sender, EventArgs e)
        {
            label_Conclusion.Text = "KHÔNG ĐẠT";
            label_Conclusion.Visible = true;
        }

        private void label_Step1_Click(object sender, EventArgs e)
        {

        }
    }
}
