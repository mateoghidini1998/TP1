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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEjercicio1 frm = new frmEjercicio1();

            frm.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEjercicio2 frm = new frmEjercicio2();

            frm.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEjercicio3 frm = new frmEjercicio3();

            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
