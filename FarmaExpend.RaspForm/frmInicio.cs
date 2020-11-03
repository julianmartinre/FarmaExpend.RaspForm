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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //pbLogo.Load("logofe.png");
            Sesion sesion = Sesion.GetInstance();
            sesion.login("a", "a", 6);
            Api a = new Api();
            sesion.token = a.GenerarToken(sesion.username, sesion.password);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.Show();
            this.Hide();
        }
    }
}
