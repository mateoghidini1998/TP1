
namespace TrabajoPractico1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.btnEjercicio3 = new System.Windows.Forms.Button();
            this.txtIntegrantes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(98, 55);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(120, 47);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.Location = new System.Drawing.Point(274, 55);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(130, 47);
            this.btnEjercicio2.TabIndex = 1;
            this.btnEjercicio2.Text = "Ejercicio 2";
            this.btnEjercicio2.UseVisualStyleBackColor = true;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio3.Location = new System.Drawing.Point(475, 55);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(124, 47);
            this.btnEjercicio3.TabIndex = 2;
            this.btnEjercicio3.Text = "Ejercicio 3";
            this.btnEjercicio3.UseVisualStyleBackColor = true;
            this.btnEjercicio3.Click += new System.EventHandler(this.btnEjercicio3_Click);
            // 
            // txtIntegrantes
            // 
            this.txtIntegrantes.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegrantes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIntegrantes.Location = new System.Drawing.Point(139, 163);
            this.txtIntegrantes.Multiline = true;
            this.txtIntegrantes.Name = "txtIntegrantes";
            this.txtIntegrantes.ReadOnly = true;
            this.txtIntegrantes.Size = new System.Drawing.Size(360, 155);
            this.txtIntegrantes.TabIndex = 3;
            this.txtIntegrantes.Text = resources.GetString("txtIntegrantes.Text");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 366);
            this.Controls.Add(this.txtIntegrantes);
            this.Controls.Add(this.btnEjercicio3);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.btnEjercicio1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button btnEjercicio3;
        private System.Windows.Forms.TextBox txtIntegrantes;
    }
}

