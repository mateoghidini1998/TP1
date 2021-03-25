using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnVolverEj1_Click(object sender, EventArgs e)
        {
            this.Close();

            frmPrincipal frm = new frmPrincipal();

            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbNombre.Text.Trim();

            if(tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un nombre", "Advertencia");
            }
            else
            {
                ltbNombres.Items.Add(tbNombre.Text);
                tbNombre.Text = "";
            }

        }
    }
}
