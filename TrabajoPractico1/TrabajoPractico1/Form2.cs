using System;
using System.Drawing;
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
            /* if (tbNombre.Text.Trim().Length != 0)
            {
                ltbNombres.Items.Add(tbNombre.Text);
                tbNombre.Text = "";
            }
            else
            {
                tbNombre.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un nombre", "Advertencia");
                tbNombre.BackColor = Color.White;
            }*/
            bool existe = false;

            if (tbNombre.Text.Trim().ToLower().Length != 0)
            {
                foreach (string item in ltbNombres.Items)
                {
                    if (tbNombre.Text.Trim().ToLower() == item.Trim().ToLower())
                    {
                        MessageBox.Show("Este nombre ya existe", "ERROR");
                        tbNombre.Text = "";
                        existe = true;
                    }
                }

                if(existe == false)
                {
                    ltbNombres.Items.Add(tbNombre.Text.Trim());
                    tbNombre.Text = "";
                }
                existe = false;
            }
            else
            {
                MessageBox.Show("No se puede ingresar espacios en blanco", "ERROR");
                tbNombre.Text = "";
            }

        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            if (ltbNombres.Items.Count == 0)
                MessageBox.Show("No hay nada","ERROR");
            else
            {
                bool existe = false;
                foreach (string nombre1 in ltbNombres.Items) // Verifico nombre por nombre
                {
                    foreach (string nombre2 in ltbNombresPasados.Items)
                    {
                        if (nombre1.Trim().ToLower() == nombre2.Trim().ToLower())
                        {
                            existe = true;
                        }
                    }
                    if (existe == false)
                    {
                        ltbNombresPasados.Items.Add(nombre1);
                    }
                    existe = false;
                }
                //ltbNombresPasados.Items.AddRange(ltbNombres.Items);
                ltbNombres.Items.Clear();
            }
        }

        private void btnPasarNombre_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                foreach (string nombre in ltbNombresPasados.Items)
                {
                    if (ltbNombres.SelectedItem.ToString().Trim().ToLower() == nombre.Trim().ToLower())
                        existe = true;
                }
                if (existe == false)
                {
                    ltbNombresPasados.Items.Add(ltbNombres.SelectedItem);
                    ltbNombres.Items.Remove(ltbNombres.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Este nombre ya existe", "ERROR");
                    existe = false;
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un nombre");
            }
        }
    }
}
