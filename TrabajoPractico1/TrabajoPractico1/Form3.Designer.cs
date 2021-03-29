
namespace TrabajoPractico1
{
    partial class frmEjercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolverEj2 = new System.Windows.Forms.Button();
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtIngresoApellido = new System.Windows.Forms.TextBox();
            this.txtIngresoNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpElementos = new System.Windows.Forms.GroupBox();
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbIngresoDatos.SuspendLayout();
            this.gpElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverEj2
            // 
            this.btnVolverEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj2.Location = new System.Drawing.Point(361, 370);
            this.btnVolverEj2.Name = "btnVolverEj2";
            this.btnVolverEj2.Size = new System.Drawing.Size(77, 33);
            this.btnVolverEj2.TabIndex = 0;
            this.btnVolverEj2.Text = "Volver";
            this.btnVolverEj2.UseVisualStyleBackColor = true;
            this.btnVolverEj2.Click += new System.EventHandler(this.btnVolverEj2_Click);
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbIngresoDatos.Controls.Add(this.txtIngresoApellido);
            this.gbIngresoDatos.Controls.Add(this.txtIngresoNombre);
            this.gbIngresoDatos.Controls.Add(this.txtApellido);
            this.gbIngresoDatos.Controls.Add(this.txtNombre);
            this.gbIngresoDatos.Controls.Add(this.btnAgregar);
            this.gbIngresoDatos.Location = new System.Drawing.Point(31, 38);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Size = new System.Drawing.Size(324, 343);
            this.gbIngresoDatos.TabIndex = 1;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Ingreso de datos";
            // 
            // txtIngresoApellido
            // 
            this.txtIngresoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresoApellido.Location = new System.Drawing.Point(98, 158);
            this.txtIngresoApellido.Name = "txtIngresoApellido";
            this.txtIngresoApellido.Size = new System.Drawing.Size(220, 26);
            this.txtIngresoApellido.TabIndex = 4;
            // 
            // txtIngresoNombre
            // 
            this.txtIngresoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresoNombre.Location = new System.Drawing.Point(98, 109);
            this.txtIngresoNombre.Name = "txtIngresoNombre";
            this.txtIngresoNombre.Size = new System.Drawing.Size(220, 26);
            this.txtIngresoNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(6, 158);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(68, 26);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(68, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(98, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpElementos
            // 
            this.gpElementos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpElementos.Controls.Add(this.lbElementos);
            this.gpElementos.Controls.Add(this.btnBorrar);
            this.gpElementos.Location = new System.Drawing.Point(445, 38);
            this.gpElementos.Name = "gpElementos";
            this.gpElementos.Size = new System.Drawing.Size(312, 343);
            this.gpElementos.TabIndex = 2;
            this.gpElementos.TabStop = false;
            this.gpElementos.Text = "Elementos";
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.Location = new System.Drawing.Point(27, 44);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(254, 238);
            this.lbElementos.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(118, 303);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 30);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpElementos);
            this.Controls.Add(this.gbIngresoDatos);
            this.Controls.Add(this.btnVolverEj2);
            this.Name = "frmEjercicio2";
            this.Text = "Ejercicio 2";
            this.gbIngresoDatos.ResumeLayout(false);
            this.gbIngresoDatos.PerformLayout();
            this.gpElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEj2;
        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpElementos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtIngresoApellido;
        private System.Windows.Forms.TextBox txtIngresoNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lbElementos;
    }
}