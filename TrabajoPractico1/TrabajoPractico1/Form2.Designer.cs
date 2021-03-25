
namespace TrabajoPractico1
{
    partial class frmEjercicio1
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
            this.btnVolverEj1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ltbNombres = new System.Windows.Forms.ListBox();
            this.ltbNombresPasados = new System.Windows.Forms.ListBox();
            this.btnPasarNombre = new System.Windows.Forms.Button();
            this.btnPasarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverEj1
            // 
            this.btnVolverEj1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverEj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEj1.Location = new System.Drawing.Point(359, 309);
            this.btnVolverEj1.Name = "btnVolverEj1";
            this.btnVolverEj1.Size = new System.Drawing.Size(93, 33);
            this.btnVolverEj1.TabIndex = 0;
            this.btnVolverEj1.Text = "Volver";
            this.btnVolverEj1.UseVisualStyleBackColor = true;
            this.btnVolverEj1.Click += new System.EventHandler(this.btnVolverEj1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(149, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ingrese un nombre: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(302, 41);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(239, 26);
            this.tbNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(587, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 26);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ltbNombres
            // 
            this.ltbNombres.FormattingEnabled = true;
            this.ltbNombres.Location = new System.Drawing.Point(12, 91);
            this.ltbNombres.Name = "ltbNombres";
            this.ltbNombres.Size = new System.Drawing.Size(314, 212);
            this.ltbNombres.TabIndex = 4;
            // 
            // ltbNombresPasados
            // 
            this.ltbNombresPasados.FormattingEnabled = true;
            this.ltbNombresPasados.Location = new System.Drawing.Point(525, 91);
            this.ltbNombresPasados.Name = "ltbNombresPasados";
            this.ltbNombresPasados.Size = new System.Drawing.Size(306, 212);
            this.ltbNombresPasados.TabIndex = 5;
            // 
            // btnPasarNombre
            // 
            this.btnPasarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarNombre.Location = new System.Drawing.Point(380, 125);
            this.btnPasarNombre.Name = "btnPasarNombre";
            this.btnPasarNombre.Size = new System.Drawing.Size(98, 49);
            this.btnPasarNombre.TabIndex = 6;
            this.btnPasarNombre.Text = ">";
            this.btnPasarNombre.UseVisualStyleBackColor = true;
            // 
            // btnPasarTodo
            // 
            this.btnPasarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodo.Location = new System.Drawing.Point(380, 211);
            this.btnPasarTodo.Name = "btnPasarTodo";
            this.btnPasarTodo.Size = new System.Drawing.Size(98, 52);
            this.btnPasarTodo.TabIndex = 7;
            this.btnPasarTodo.Text = ">>";
            this.btnPasarTodo.UseVisualStyleBackColor = true;
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 370);
            this.Controls.Add(this.btnPasarTodo);
            this.Controls.Add(this.btnPasarNombre);
            this.Controls.Add(this.ltbNombresPasados);
            this.Controls.Add(this.ltbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVolverEj1);
            this.Name = "frmEjercicio1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEj1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox ltbNombres;
        private System.Windows.Forms.ListBox ltbNombresPasados;
        private System.Windows.Forms.Button btnPasarNombre;
        private System.Windows.Forms.Button btnPasarTodo;
    }
}