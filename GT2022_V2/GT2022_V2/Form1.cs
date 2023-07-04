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

namespace GT2022_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VisibleFalse();
        }

        private void Button_Language_VietNamese_Click(object sender, EventArgs e)
        {
            Button_Menu_Items.Text = "Đối tượng kiểm tra";
            Button_Menu_Devices.Text = "Thiết bị đo tổng hợp";
            Button_Menu_Processor.Text = "Bộ xử lý trung tâm";
            Button_Menu_Data.Text = "Cơ sở dữ liệu";
            Button_Menu_Support.Text = "Hỗ trợ";
            Button_Menu_Introduce.Text = "Giới thiệu";
            Button_Menu_Support_Language.Text = "Ngôn ngữ";
            Button_Language_English.Text = "Tiếng Anh";
            Button_Language_VietNamese.Text = "Tiếng Việt";
            btnMenu_Devices_Oscilloscope.Text = "Hiện sóng số DSOX2022A";
            btnMenu_Devices_DL550.Text = "Tải lập trình điện tử DL550";
            btnMenu_Devices_1908P.Text = "Đồng hồ vạn năng số TTi 1908P";
            btnMenu_XLTT_Voltages.Text = "Giám sát tham số";
            btnMenu_XLTT_Relay.Text = "Điều khiển chuyển mạch";

        }

        private void Button_Language_English_Click(object sender, EventArgs e)
        {
            Button_Menu_Items.Text = "Test Subjects";
            Button_Menu_Devices.Text = "Dedicated Measuring System";
            Button_Menu_Processor.Text = "Processing, Control and Monitoring Systems";
            Button_Menu_Data.Text = "Database";
            Button_Menu_Support.Text = "Supports";
            Button_Menu_Introduce.Text = "Introduce";
            Button_Menu_Support_Language.Text = "Language";
            Button_Language_English.Text = "English";
            Button_Language_VietNamese.Text = "VietNamese";
            btnMenu_Devices_Oscilloscope.Text = "Oscilloscope DSOX2022A";
            btnMenu_Devices_DL550.Text = "DC Electronics Load DL550";
            btnMenu_Devices_1908P.Text = "Digit Dual Measurement Multimeter TTi 1908P";
            btnMenu_XLTT_Voltages.Text = "Parameters Monitoring";
            btnMenu_XLTT_Relay.Text = "Switch Control";
        }
        void VisibleFalse()
        {
            panel_Main.BackgroundImage = Image.FromFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\Picture\\Background.PNG");
            panel_Main.BackgroundImageLayout = ImageLayout.Zoom;
            label_Title.Visible = false;
            button_Cancel_Test.Visible = false;
            tabMenu.Visible = false;
        }
        void VisibleTrue()
        {
            panel_Main.BackgroundImage = null;
            tabMenu.Visible = true;
            button_Cancel_Test.Visible = true;
            label_Title.Visible = true;
        }
        void EnableMenu()
        {
            Button_Menu_Items.Enabled = true;
            Button_Menu_Devices.Enabled = true;
            Button_Menu_Processor.Enabled = true;
        }
        void DisableMenu()
        {
            Button_Menu_Items.Enabled = false;
            Button_Menu_Devices.Enabled = false;
            Button_Menu_Processor.Enabled = false;
        }
        private void button_Cancel_Test_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            EnableMenu();
        }
        private void tabMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            //switch (e.Index)
            //{
            //    case 0:
            //        e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
            //        break;
            //    case 1:
            //        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
            //        break;
            //    default:
            //        break;
            //}

            //// Then draw the current tab button text 
            //Rectangle paddedBounds = e.Bounds;
            //paddedBounds.Inflate(-2, -2);
            //e.Graphics.DrawString(tabMenu.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);
            //Brush BackBrush = new SolidBrush(Color.GreenYellow);
            //e.Graphics.FillRectangle(BackBrush, e.Bounds);
        }

        private void btnMenu_Colchuga_MP1_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP1.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.user_colchuga_MP1 userColchuga_MP1 = new User_Colchuga.user_colchuga_MP1() { Location = new Point(0, 0),Dock = DockStyle.Fill,Width = 800,Height = 700};
            panel_User.Controls.Add(userColchuga_MP1);
        }

        private void btnMenu_Colchuga_MP2_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP2.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.User_RD01_MP2 userColchuga_MP2 = new User_Colchuga.User_RD01_MP2() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userColchuga_MP2);
        }

        private void btnMenu_Colchuga_MP5_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP5.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.User_RD01_MP5 userColchuga_MP5 = new User_Colchuga.User_RD01_MP5() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userColchuga_MP5);
        }

        private void btnMenu_Colchuga_MP6_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP6.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.User_RD01_MP6 userColchuga_MP6 = new User_Colchuga.User_RD01_MP6() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userColchuga_MP6);
        }

        private void btnMenu_Colchuga_MP8_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP8.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.User_RD01_MP8 userColchuga_MP8 = new User_Colchuga.User_RD01_MP8() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userColchuga_MP8);
        }

        private void btnMenu_Colchuga_MP10_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_MP10.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_Colchuga.User_RD01_MP10 userColchuga_MP10 = new User_Colchuga.User_RD01_MP10() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userColchuga_MP10);
        }

        private void btnMenu_Colchuga_PS246_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_PS246.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_Colchuga_PS224_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_PS224.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_Colchuga_K21_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_K21.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_Colchuga_K23_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_K23.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_Colchuga_K29_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Colchuga_K29.Text + "/" + btnMenu_Colchuga.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_36D6_I3BB02_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BB02.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_36D6_I3BB03_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BB03.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
        }

        private void btnMenu_36D6_I3BV01_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV01.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV01 user36D6_I3BV01 = new User_RD02.User_RD02_I3BV01() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV01);
        }

        private void btnMenu_36D6_I3BV02_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV02.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV02 user36D6_I3BV02 = new User_RD02.User_RD02_I3BV02() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV02);
        }

        private void btnMenu_36D6_I3BV03_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV03.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV03 user36D6_I3BV03 = new User_RD02.User_RD02_I3BV03() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV03);
        }

        private void btnMenu_36D6_I3BV04_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV04.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV04 user36D6_I3BV04 = new User_RD02.User_RD02_I3BV04() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV04);
        }

        private void btnMenu_36D6_I3BV05_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV05.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV05 user36D6_I3BV05 = new User_RD02.User_RD02_I3BV05() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV05);
        }

        private void btnMenu_36D6_I3BV07_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_I3BV07.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_I3BV07 user36D6_I3BV07 = new User_RD02.User_RD02_I3BV07() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_I3BV07);
        }

        private void btnMenu_36D6_MP48V_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_MP48V.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_MP48 user36D6_MP48 = new User_RD02.User_RD02_MP48() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_MP48);
        }

        private void btnMenu_36D6_BPI27V25A_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_36D6_BPI27V25A.Text + "/" + btnMenu_36D6.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD02.User_RD02_BPI27V25 user36D6_BPI27V25 = new User_RD02.User_RD02_BPI27V25() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(user36D6_BPI27V25);
        }

        private void btnMenu_Kacta2E_V3BH12_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH12.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN12 userKacta2E_V3BN12 = new User_RD03.User_RD03_V3BN12() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN12);
        }

        private void btnMenu_Kacta2E_V3BH15_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH15.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN15 userKacta2E_V3BN15 = new User_RD03.User_RD03_V3BN15() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN15);
        }

        private void btnMenu_Kacta2E_V3BH17_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH17.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN17 userKacta2E_V3BN17 = new User_RD03.User_RD03_V3BN17() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN17);
        }

        private void btnMenu_Kacta2E_V3BH32_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH32.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN32 userKacta2E_V3BN32 = new User_RD03.User_RD03_V3BN32() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN32);
        }

        private void btnMenu_Kacta2E_V3BH72_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH72.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN72 userKacta2E_V3BN72 = new User_RD03.User_RD03_V3BN72() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN72);
        }

        private void btnMenu_Kacta2E_V3BH77_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3BH77.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3BN77 userKacta2E_V3BN77 = new User_RD03.User_RD03_V3BN77() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_V3BN77);
        }

        private void btnMenu_Kacta2E_394BH57_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_394BH57.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_394BN57 userKacta2E_394BN57 = new User_RD03.User_RD03_394BN57() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_394BN57);
        }

        private void btnMenu_Kacta2E_352EH1_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_352EH1.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_352EN1 userKacta2E_352EN1 = new User_RD03.User_RD03_352EN1() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_352EN1);
        }

        private void btnMenu_Kacta2E_352EH2_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_352EH2.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_352EN2 userKacta2E_352EN2 = new User_RD03.User_RD03_352EN2() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userKacta2E_352EN2);
        }

        private void btnMenu_Kacta2E_I3BV03_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_I3BV03.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_I3BV03 userRD03_I3BV03 = new User_RD03.User_RD03_I3BV03() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_I3BV03);
        }

        private void btnMenu_Kacta2E_I3BV04_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_I3BV04.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_I3BV04 userRD03_I3BV04 = new User_RD03.User_RD03_I3BV04() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_I3BV04);
        }

        private void btnMenu_Kacta2E_I3BV06_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_I3BV06.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_I3BV06 userRD03_I3BV06 = new User_RD03.User_RD03_I3BV06() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_I3BV06);
        }

        private void btnMenu_Kacta2E_I3BV07_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_I3BV07.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_I3BV07 userRD03_I3BV07 = new User_RD03.User_RD03_I3BV07() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_I3BV07);
        }

        private void btnMenu_Kacta2E_I3BV13_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_I3BV13.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_I3BV13 userRD03_I3BV13 = new User_RD03.User_RD03_I3BV13() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_I3BV13);
        }

        private void btnMenu_Kacta2E_V3UU01_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3UU01.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3UU01 userRD03_V3UU01 = new User_RD03.User_RD03_V3UU01() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_V3UU01);
        }

        private void btnMenu_Kacta2E_V3UU07_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_Kacta2E_V3UU07.Text + "/" + btnMenu_Kacta2E.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD03.User_RD03_V3UU07 userRD03_V3UU07 = new User_RD03.User_RD03_V3UU07() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD03_V3UU07);
        }

        private void btnMenu_P18M_DRI_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_P18M_DRI.Text + "/" + btnMenu_P18M.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD04.User_RD04_DRI userRD04_DRI = new User_RD04.User_RD04_DRI() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD04_DRI);
        }

        private void btnMenu_P18M_SCP_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_P18M_SCP.Text + "/" + btnMenu_P18M.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD04.User_RD04_SCP userRD04_SCP = new User_RD04.User_RD04_SCP() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD04_SCP);
        }

        private void btnMenu_P18M_SCS_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_P18M_SCS.Text + "/" + btnMenu_P18M.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD04.User_RD04_SCS userRD04_SCS = new User_RD04.User_RD04_SCS() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD04_SCS);
        }

        private void btnMenu_P18M_CCS_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_P18M_CCS.Text + "/" + btnMenu_P18M.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD04.User_RD04_CCS userRD04_CCS = new User_RD04.User_RD04_CCS() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD04_CCS);
        }

        private void btnMenu_P18M_CPS_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_P18M_CPS.Text + "/" + btnMenu_P18M.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD04.User_RD04_CPS userRD04_CPS = new User_RD04.User_RD04_CPS() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD04_CPS);
        }

        private void btnMenu_1L133_B2EH3_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH3.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN3 userRD05_B2EN3 = new User_RD05.User_RD05_B2EN3() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN3);
        }

        private void btnMenu_1L133_B2EH4_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH4.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN4 userRD05_B2EN4 = new User_RD05.User_RD05_B2EN4() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN4);
        }

        private void btnMenu_1L133_B2EH5_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH5.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN5 userRD05_B2EN5 = new User_RD05.User_RD05_B2EN5() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN5);
        }

        private void btnMenu_1L133_B2EH6_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH6.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN6 userRD05_B2EN6 = new User_RD05.User_RD05_B2EN6() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN6);
        }

        private void btnMenu_1L133_B2EH7_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH7.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN7 userRD05_B2EN7 = new User_RD05.User_RD05_B2EN7() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN7);
        }

        private void btnMenu_1L133_B2EH10_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH10.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN10 userRD05_B2EN10 = new User_RD05.User_RD05_B2EN10() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN10);
        }

        private void btnMenu_1L133_B2EH14_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH14.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN14 userRD05_B2EN14 = new User_RD05.User_RD05_B2EN14() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN14);
        }

        private void btnMenu_1L133_B2EH15_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH15.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN15 userRD05_B2EN15 = new User_RD05.User_RD05_B2EN15() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN15);
        }

        private void btnMenu_1L133_B2EH16_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH16.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN16 userRD05_B2EN16 = new User_RD05.User_RD05_B2EN16() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN16);
        }

        private void btnMenu_1L133_B2EH17_Click(object sender, EventArgs e)
        {
            label_Title.Text = btnMenu_1L133_B2EH17.Text + "/" + btnMenu_1L133.Text;
            VisibleTrue();
            DisableMenu();
            AbodePDF.LoadFile("E:\\Works 2022\\The\\GT2022\\GT2022_V2\\Data\\RDColchuga\\HDSC_MP1.PDF");
            panel_User.Controls.Clear();
            User_RD05.User_RD05_B2EN17 userRD05_B2EN17 = new User_RD05.User_RD05_B2EN17() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 800, Height = 700 };
            panel_User.Controls.Add(userRD05_B2EN17);
        }

        private void Button_Menu_Introduce_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMenu_XLTT_Voltages_Click(object sender, EventArgs e)
        {
            XLTT.XLTT_Monitoring frmVoltage = new XLTT.XLTT_Monitoring();
            frmVoltage.Show();
        }

        private void btnMenu_Devices_1908P_Click(object sender, EventArgs e)
        {
            Devices.TTi_1908P frmTTi_1908P = new Devices.TTi_1908P();
            frmTTi_1908P.Show();
        }

        private void btnMenu_Devices_Oscilloscope_Click(object sender, EventArgs e)
        {
            Devices.DSOX2022A frmDSOX2022A = new Devices.DSOX2022A();
            frmDSOX2022A.Show();
        }

        private void btnMenu_Devices_DL550_Click(object sender, EventArgs e)
        {
            Devices.DL550 frmDL550 = new Devices.DL550();
            frmDL550.Show();
        }

        private void Button_Menu_Data_Click(object sender, EventArgs e)
        {
            CSDL.CSDL_Radars frmCSDL = new CSDL.CSDL_Radars();
            frmCSDL.Show();
        }

        private void btnMenu_XLTT_Relay_Click(object sender, EventArgs e)
        {
            XLTT.XLTT__RelayControl frmRelay_Control = new XLTT.XLTT__RelayControl();
            frmRelay_Control.Show();
        }
    }
}
