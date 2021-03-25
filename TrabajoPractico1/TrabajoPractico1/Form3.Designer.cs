
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
            this.SuspendLayout();
            // 
            // btnVolverEj2
            // 
            this.btnVolverEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj2.Location = new System.Drawing.Point(310, 284);
            this.btnVolverEj2.Name = "btnVolverEj2";
            this.btnVolverEj2.Size = new System.Drawing.Size(111, 56);
            this.btnVolverEj2.TabIndex = 0;
            this.btnVolverEj2.Text = "Volver";
            this.btnVolverEj2.UseVisualStyleBackColor = true;
            this.btnVolverEj2.Click += new System.EventHandler(this.btnVolverEj2_Click);
            // 
            // frmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverEj2);
            this.Name = "frmEjercicio2";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEj2;
    }
}