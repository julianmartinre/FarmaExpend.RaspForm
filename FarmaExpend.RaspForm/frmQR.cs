using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaExpend.RaspForm
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQR_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("https://farmaexpend.com/mp.jpeg");
        }
    }
}
