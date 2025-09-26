using System.Drawing;
using System.Windows.Forms;

namespace Lab09
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarEntrenador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarEntrenador
            // 
            this.btnRegistrarEntrenador.Location = new System.Drawing.Point(103, 13);
            this.btnRegistrarEntrenador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            this.btnRegistrarEntrenador.Size = new System.Drawing.Size(156, 41);
            this.btnRegistrarEntrenador.TabIndex = 1;
            this.btnRegistrarEntrenador.Text = "Ver Entrenador";
            this.btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrenador.Click += new System.EventHandler(this.btnRegistrarEntrenador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(103, 62);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 120);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarEntrenador);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Liga Pokémon";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnRegistrarEntrenador;
        private Button btnSalir;
    }
}