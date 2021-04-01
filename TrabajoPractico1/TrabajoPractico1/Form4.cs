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

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            string cadena = "Usted selecciono los siguientes elementos: \n";

            if(rbFemenino.Checked == true)
            {
                cadena += rbFemenino.Text;
            }
            else
            {
                cadena += rbMasculino.Text;
            }

            if(rbCasado.Checked == true)
            {
                cadena += rbCasado.Text;
            }
            else
            {
                cadena += rbSoltero.Text;
            }

            cadena += "\n";

            foreach(object item in clbProfecion.CheckedItems)
            {
                cadena += "-" + item.ToString() + "\n";
            }

            lblMostrarSeleccion.Text = cadena;
        }
    }
}
