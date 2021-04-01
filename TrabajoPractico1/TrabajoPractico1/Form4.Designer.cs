
namespace TrabajoPractico1
{
    partial class frmEjercicio3
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
            this.btnVolverEj3 = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.clbProfecion = new System.Windows.Forms.CheckedListBox();
            this.lblMostrarSeleccion = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverEj3
            // 
            this.btnVolverEj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj3.Location = new System.Drawing.Point(660, 347);
            this.btnVolverEj3.Name = "btnVolverEj3";
            this.btnVolverEj3.Size = new System.Drawing.Size(73, 33);
            this.btnVolverEj3.TabIndex = 0;
            this.btnVolverEj3.Text = "Volver";
            this.btnVolverEj3.UseVisualStyleBackColor = true;
            this.btnVolverEj3.Click += new System.EventHandler(this.btnVolverEj3_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(102, 16);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(171, 111);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(45, 72);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(45, 32);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(450, 12);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(183, 115);
            this.gbEstadoCivil.TabIndex = 2;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(52, 76);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(69, 17);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero/a";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(52, 36);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(72, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado/a";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(289, 242);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccion.TabIndex = 3;
            this.btnSeleccion.Text = "Mostrar Seleccion";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // clbProfecion
            // 
            this.clbProfecion.FormattingEnabled = true;
            this.clbProfecion.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbProfecion.Location = new System.Drawing.Point(251, 142);
            this.clbProfecion.Name = "clbProfecion";
            this.clbProfecion.Size = new System.Drawing.Size(215, 94);
            this.clbProfecion.TabIndex = 4;
            // 
            // lblMostrarSeleccion
            // 
            this.lblMostrarSeleccion.AutoSize = true;
            this.lblMostrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSeleccion.Location = new System.Drawing.Point(109, 285);
            this.lblMostrarSeleccion.Name = "lblMostrarSeleccion";
            this.lblMostrarSeleccion.Size = new System.Drawing.Size(0, 24);
            this.lblMostrarSeleccion.TabIndex = 5;
            // 
            // frmEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostrarSeleccion);
            this.Controls.Add(this.clbProfecion);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.btnVolverEj3);
            this.Name = "frmEjercicio3";
            this.Text = "Ejercicio 3";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEj3;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.CheckedListBox clbProfecion;
        private System.Windows.Forms.Label lblMostrarSeleccion;
    }
}