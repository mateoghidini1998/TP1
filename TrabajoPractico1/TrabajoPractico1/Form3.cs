﻿using System;
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
    public partial class frmEjercicio2 : Form
    {
        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private void btnVolverEj2_Click(object sender, EventArgs e)
        {
            this.Close();

            frmPrincipal frm = new frmPrincipal();

            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIngresoNombre.Text.Length != 0 && txtIngresoApellido.Text.Length != 0)
            {
              //  lbElementos.Items.Add(txtIngresoNombre + txtIngresoApellido);
            }
        }
    }
}
