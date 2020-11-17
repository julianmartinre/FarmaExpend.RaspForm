using FarmaExpend.RaspForm.Entidades;
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
    public partial class frmProductos : Form
    {
        MaquinaApiBE m = new MaquinaApiBE();
        int index = -1;
        Sesion sesion = Sesion.GetInstance();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Api a = new Api();
            m = a.GetMachine(sesion.nro_maquina, sesion.token);
            p1.Load(m.productos[0].url_img);
            p1Precio.Text = m.productos[0].precio.ToString();
            p2.Load(m.productos[1].url_img);
            p2Precio.Text = m.productos[1].precio.ToString();
            pbLogo.Load("https://i.ibb.co/hW1F3Ch/farmaexpendlogo.png");
            serialPort1.Open();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            pbSeleccionado.Load(m.productos[0].url_img);
            index = 0;
        }

        private void p2_Click(object sender, EventArgs e)
        {
            pbSeleccionado.Load(m.productos[1].url_img);
            index = 1;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (index>= 0) {
                Api a = new Api();
                a.RegisterSale(m.nro_maquina, sesion.token, m.productos[index].nro_producto, m.productos[index].precio);
                serialPort1.Write("a");
            }
            frmQR frmQR = new frmQR();
            frmQR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
