
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
            this.SuspendLayout();
            // 
            // btnVolverEj3
            // 
            this.btnVolverEj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj3.Location = new System.Drawing.Point(316, 291);
            this.btnVolverEj3.Name = "btnVolverEj3";
            this.btnVolverEj3.Size = new System.Drawing.Size(127, 54);
            this.btnVolverEj3.TabIndex = 0;
            this.btnVolverEj3.Text = "Volver";
            this.btnVolverEj3.UseVisualStyleBackColor = true;
            this.btnVolverEj3.Click += new System.EventHandler(this.btnVolverEj3_Click);
            // 
            // frmEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverEj3);
            this.Name = "frmEjercicio3";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEj3;
    }
}