using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1_ugulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTakim1_Click(object sender, EventArgs e)
        {
            lbltakim.BackColor=Color.Red;
            lbltakim.ForeColor=Color.Yellow;
            lbltakim.Text = "ŞAMPİYON GALATASARAY";
               
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            lbltakim.BackColor = Color.Black;
            lbltakim.ForeColor=Color.White;
            lbltakim.Text = "BEŞİKTAŞ";
        }

        private void btnTakim3_Click(object sender, EventArgs e)
        {
            lbltakim.BackColor= Color.Blue;
            lbltakim.ForeColor = Color.Yellow;
            lbltakim.Text = "FENERBAHÇE";

        }

        private void btnTakim4_Click(object sender, EventArgs e)
        {
            lbltakim.BackColor = Color.Pink;
            lbltakim.ForeColor= Color.White;
            lbltakim.Text = "BURSASPOR";

        }
    }
}
