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
    public partial class frmEjercicio3 : Form
    {
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnVolverEj3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            frmPrincipal frm = new frmPrincipal();

            frm.Show();
        }
    }
}
