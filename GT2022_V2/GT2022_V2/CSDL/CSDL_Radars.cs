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
    public partial class CSDL_Radars : Form
    {
        public CSDL_Radars()
        {
            InitializeComponent();
            Console.WriteLine(treeView_Radar.Nodes[1].Nodes.ToString());
            Abode_CSDL.Visible = false;
        }

        private void treeView_Radar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (treeView_Radar.SelectedNode.Tag.ToString())
            {
                case "1":
                    MessageBox.Show("Hello");
                    break;
                case "2":
                    MessageBox.Show("Hi");
                    break;
                case "3":
                    MessageBox.Show("Hello friend");
                    break;
                case "4":
                    MessageBox.Show("Hi friend");
                    break;
                default:
                    break;

            }
        }
    }
}
