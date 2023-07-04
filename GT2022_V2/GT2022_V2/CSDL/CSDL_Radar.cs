using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT2022_V2.CSDL
{
    public partial class CSDL_Radar : Form
    {
        public CSDL_Radar()
        {
            InitializeComponent();
        }

        private void btnCSDL_Colchuga_MP1_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP1.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP1.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP1.PDF");
        }

        private void btnCSDL_Colchuga_MP2_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP2.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP2.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP2.PDF");
        }

        private void btnCSDL_Colchuga_MP5_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP5.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP5.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP5.PDF");
        }

        private void btnCSDL_Colchuga_MP6_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP6.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP6.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP6.PDF");
        }

        private void btnCSDL_Colchuga_MP8_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP8.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP8.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP8.PDF");
        }

        private void btnCSDL_Colchuga_MP10_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_MP10.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-MP10.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-MP10.PDF");
        }

        private void btnCSDL_Colchuga_PS246_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_PS246.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-PS246.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-PS246.PDF");
        }

        private void btnCSDL_Colchuga_PS224_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_PS224.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-PS224.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-PS224.PDF");
        }

        private void btnCSDL_Colchuga_K21_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_K21.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-K21.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-K21.PDF");
        }

        private void btnCSDL_Colchuga_K23_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_K23.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-K23.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-K23.PDF");
        }

        private void btnCSDL_Colchuga_K29_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Colchuga_K29.Text + " / " + btnCSDL_Colchuga.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Colchuga\\SDNL\\SDNL-K29.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Colchuga\\TMKT\\TMKT-K29.PDF");
        }

        private void btnCSDL_36D6_I3BB02_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BB02.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BB02.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BB02.PDF");
        }

        private void btnCSDL_36D6_I3BB03_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BB03.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BB03.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BB03.PDF");
        }

        private void btnCSDL_36D6_I3BV01_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV01.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV01.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV01.PDF");
        }

        private void btnCSDL_36D6_I3BV02_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV02.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV02.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV02.PDF");
        }

        private void btnCSDL_36D6_I3BV03_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV03.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV03.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV03.PDF");
        }

        private void btnCSDL_36D6_I3BV04_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV04.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV04.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV04.PDF");
        }

        private void btnCSDL_36D6_I3BV05_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV05.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV05.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV05.PDF");
        }

        private void btnCSDL_36D6_I3BV07_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_I3BV07.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-I3BV07.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-I3BV07.PDF");
        }

        private void btnCSDL_36D6_MP48V_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_MP48V.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-MP48V.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-MP48V.PDF");
        }

        private void btnCSDL_36D6_BPI27V25A_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_36D6_BPI27V25A.Text + " / " + btnCSDL_36D6.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 36D6\\SDNL\\SDNL-BPI27V25A.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 36D6\\TMKT\\TMKT-BPI27V25A.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN12_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN12.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN12.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN12.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN15_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN15.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN15.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN15.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN17_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN17.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN17.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN17.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN32_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN32.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN32.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN32.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN72_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN72.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN72.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN72.PDF");
        }

        private void btnCSDL_Kacta2E_B3BN77_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3BN77.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3BN77.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3BN77.PDF");
        }

        private void btnCSDL_Kacta2E_394BN57_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_394BN57.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-394BN57.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-394BN57.PDF");
        }

        private void btnCSDL_Kacta2E_352EN1_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_352EN1.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-352EN1.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-352EN1.PDF");
        }

        private void btnCSDL_Kacta2E_352EN2_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_352EN2.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-352EN2.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-352EN2.PDF");
        }

        private void btnCSDL_Kacta2E_I3BV03_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_I3BV03.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-I3BV03.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-I3BV03.PDF");
        }

        private void btnCSDL_Kacta2E_I3BV04_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_I3BV04.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-I3BV04.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-I3BV04.PDF");
        }

        private void btnCSDL_Kacta2E_I3BV06_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_I3BV06.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-I3BV06.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-I3BV06.PDF");
        }

        private void btnCSDL_Kacta2E_I3BV07_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_I3BV07.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-I3BV07.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-I3BV07.PDF");
        }

        private void btnCSDL_Kacta2E_I3BV13_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_I3BV13.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-I3BV13.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-I3BV13.PDF");
        }
        private void btnCSDL_Kacta2E_B3UU01_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3UU01.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3UU01.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3UU01.PDF");
        }

        private void btnCSDL_Kacta2E_B3UU07_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_Kacta2E_B3UU07.Text + " / " + btnCSDL_Kacta2E.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar Kacta2E\\SDNL\\SDNL-B3UU07.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar Kacta2E\\TMKT\\TMKT-B3UU07.PDF");
        }

        private void btnCSDL_P18M_DRI_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_P18M_DRI.Text + " / " + btnCSDL_P18M.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar P18M\\SDNL\\SDNL-DRI.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar P18M\\TMKT\\TMKT-DRI.PDF");
        }

        private void btnCSDL_P18M_SCP_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_P18M_SCP.Text + " / " + btnCSDL_P18M.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar P18M\\SDNL\\SDNL-SCP.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar P18M\\TMKT\\TMKT-SCP.PDF");
        }

        private void btnCSDL_P18M_SCS_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_P18M_SCS.Text + " / " + btnCSDL_P18M.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar P18M\\SDNL\\SDNL-SCS.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar P18M\\TMKT\\TMKT-SCS.PDF");
        }

        private void btnCSDL_P18M_CCS_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_P18M_CCS.Text + " / " + btnCSDL_P18M.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar P18M\\SDNL\\SDNL-CCS.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar P18M\\TMKT\\TMKT-CCS.PDF");
        }

        private void btnCSDL_P18M_CPS_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_P18M_CPS.Text + " / " + btnCSDL_P18M.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar P18M\\SDNL\\SDNL-CPS.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar P18M\\TMKT\\TMKT-CPS.PDF");
        }

        private void btnCSDL_1L133_B2EN3_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN3.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN3.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN3.PDF");
        }

        private void btnCSDL_1L133_B2EN4_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN4.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN4.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN4.PDF");
        }

        private void btnCSDL_1L133_B2E5_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN5.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN5.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN5.PDF");
        }

        private void btnCSDL_1L133_B2EN6_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN6.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN6.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN6.PDF");
        }

        private void btnCSDL_1L133_B2EN7_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN7.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN7.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN7.PDF");
        }

        private void btnCSDL_1L133_B2EN10_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN10.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN10.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN10.PDF");
        }

        private void btnCSDL_1L133_B2EN14_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN14.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN14.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN14.PDF");
        }

        private void btnCSDL_1L133_B2EN15_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN15.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN15.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN15.PDF");
        }

        private void btnCSDL_1L133_B2EN16_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN16.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN16.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN16.PDF");
        }

        private void btnCSDL_1L133_B2EN17_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = btnCSDL_1L133_B2EN17.Text + " / " + btnCSDL_1L133.Text;
            Abode_SDNL.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\SDNL\\SDNL-B2EN17.PDF");
            Abode_TMKT.LoadFile("D:\\CSDL\\Radar 1L133 - 55D6\\TMKT\\TMKT-B2EN17.PDF");
        }

        private void btnCSDL_36D6_Click(object sender, EventArgs e)
        {

        }

        private void btnCSDL_Kacta2E_Click(object sender, EventArgs e)
        {

        }

        private void btnCSDL_P18M_Click(object sender, EventArgs e)
        {

        }

        private void btnCSDL_1L133_Click(object sender, EventArgs e)
        {

        }
    }
}
