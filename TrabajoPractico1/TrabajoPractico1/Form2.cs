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
            if(tbNombre.Text.Trim().Length != 0)
            {
                ltbNombres.Items.Add(tbNombre.Text);
                tbNombre.Text = "";
            }
            else
            {
                tbNombre.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un nombre", "Advertencia");
                tbNombre.BackColor = Color.White;
            }

        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            ltbNombresPasados.Items.AddRange(ltbNombres.Items);
            ltbNombres.Items.Clear();
        }

        private void btnPasarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                ltbNombresPasados.Items.Add(ltbNombres.SelectedItem);
                ltbNombres.Items.Remove(ltbNombres.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Seleccione un nombre");
            }
        }
    }
}
