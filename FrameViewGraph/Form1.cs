using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameViewGraph
{
    public partial class frmMain : Form
    {
        private String nameOfTest = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtBxNameTest_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNameTest.Text == "")
            {
                nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            }
            else
            {
                nameOfTest = txtBxNameTest.Text;
            }
        }
    }
}
