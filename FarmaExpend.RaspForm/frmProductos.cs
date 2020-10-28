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
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Api a = new Api();
            m = a.GetMachine(6, "7b23a0fd-8105-492b-9fc6-2765f0e6e5b1");
            p1.Load(m.productos[0].url_img);
            p1Precio.Text = m.productos[0].precio.ToString();
            p2.Load(m.productos[1].url_img);
            p2Precio.Text = m.productos[1].precio.ToString();
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
                a.RegisterSale(m.nro_maquina, "7b23a0fd-8105-492b-9fc6-2765f0e6e5b1", m.productos[index].nro_producto, m.productos[index].precio);
            } 
        }
    }
}
