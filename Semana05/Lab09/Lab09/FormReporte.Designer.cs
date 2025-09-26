
namespace Lab09
{
    partial class FormReporte
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
            this.tbEdadMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarLegendarios = new System.Windows.Forms.Button();
            this.btnBuscarPorRangoEdadEntrenadores = new System.Windows.Forms.Button();
            this.tbEdadMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscarPorMaxPSPokemon = new System.Windows.Forms.Button();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorMenorCantPokemon = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarPorRegion = new System.Windows.Forms.Button();
            this.btnBuscarPorNombrePokemon = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEdadMax
            // 
            this.tbEdadMax.Location = new System.Drawing.Point(173, 427);
            this.tbEdadMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdadMax.Name = "tbEdadMax";
            this.tbEdadMax.Size = new System.Drawing.Size(219, 22);
            this.tbEdadMax.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(81, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 121;
            this.label6.Text = "Edad Max:";
            // 
            // btnBuscarLegendarios
            // 
            this.btnBuscarLegendarios.Location = new System.Drawing.Point(87, 495);
            this.btnBuscarLegendarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarLegendarios.Name = "btnBuscarLegendarios";
            this.btnBuscarLegendarios.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarLegendarios.TabIndex = 120;
            this.btnBuscarLegendarios.Text = "Buscar Legendarios";
            this.btnBuscarLegendarios.UseVisualStyleBackColor = true;
            this.btnBuscarLegendarios.Click += new System.EventHandler(this.btnBuscarLegendarios_Click);
            // 
            // btnBuscarPorRangoEdadEntrenadores
            // 
            this.btnBuscarPorRangoEdadEntrenadores.Location = new System.Drawing.Point(87, 459);
            this.btnBuscarPorRangoEdadEntrenadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorRangoEdadEntrenadores.Name = "btnBuscarPorRangoEdadEntrenadores";
            this.btnBuscarPorRangoEdadEntrenadores.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarPorRangoEdadEntrenadores.TabIndex = 114;
            this.btnBuscarPorRangoEdadEntrenadores.Text = "Buscar por rango de edad de entrenadores";
            this.btnBuscarPorRangoEdadEntrenadores.UseVisualStyleBackColor = true;
            this.btnBuscarPorRangoEdadEntrenadores.Click += new System.EventHandler(this.btnBuscarPorRangoEdadEntrenadores_Click);
            // 
            // tbEdadMin
            // 
            this.tbEdadMin.Location = new System.Drawing.Point(173, 395);
            this.tbEdadMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdadMin.Name = "tbEdadMin";
            this.tbEdadMin.Size = new System.Drawing.Size(219, 22);
            this.tbEdadMin.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(85, 398);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 112;
            this.label8.Text = "Edad Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(124, 354);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 111;
            this.label9.Text = "Reportes Pokémon";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(64, 340);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(367, 220);
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscarPorMaxPSPokemon
            // 
            this.btnBuscarPorMaxPSPokemon.Location = new System.Drawing.Point(87, 274);
            this.btnBuscarPorMaxPSPokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorMaxPSPokemon.Name = "btnBuscarPorMaxPSPokemon";
            this.btnBuscarPorMaxPSPokemon.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarPorMaxPSPokemon.TabIndex = 110;
            this.btnBuscarPorMaxPSPokemon.Text = "Buscar por máx PS de pokémons";
            this.btnBuscarPorMaxPSPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorMaxPSPokemon.Click += new System.EventHandler(this.btnBuscarPorMaxPSPokemon_Click);
            // 
            // dgReporte
            // 
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Location = new System.Drawing.Point(449, 47);
            this.dgReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.Size = new System.Drawing.Size(760, 559);
            this.dgReporte.TabIndex = 109;
            // 
            // btnBuscarPorMenorCantPokemon
            // 
            this.btnBuscarPorMenorCantPokemon.Location = new System.Drawing.Point(87, 239);
            this.btnBuscarPorMenorCantPokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorMenorCantPokemon.Name = "btnBuscarPorMenorCantPokemon";
            this.btnBuscarPorMenorCantPokemon.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarPorMenorCantPokemon.TabIndex = 108;
            this.btnBuscarPorMenorCantPokemon.Text = "Buscar por menor cantidad de pokémons";
            this.btnBuscarPorMenorCantPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorMenorCantPokemon.Click += new System.EventHandler(this.btnBuscarPorMenorCantPokemon_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(87, 578);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(307, 28);
            this.btnSalir.TabIndex = 103;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarPorRegion
            // 
            this.btnBuscarPorRegion.Location = new System.Drawing.Point(87, 203);
            this.btnBuscarPorRegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            this.btnBuscarPorRegion.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarPorRegion.TabIndex = 102;
            this.btnBuscarPorRegion.Text = "Buscar por región";
            this.btnBuscarPorRegion.UseVisualStyleBackColor = true;
            this.btnBuscarPorRegion.Click += new System.EventHandler(this.btnBuscarPorRegion_Click);
            // 
            // btnBuscarPorNombrePokemon
            // 
            this.btnBuscarPorNombrePokemon.Location = new System.Drawing.Point(87, 134);
            this.btnBuscarPorNombrePokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorNombrePokemon.Name = "btnBuscarPorNombrePokemon";
            this.btnBuscarPorNombrePokemon.Size = new System.Drawing.Size(307, 28);
            this.btnBuscarPorNombrePokemon.TabIndex = 101;
            this.btnBuscarPorNombrePokemon.Text = "Buscar por nombre del pokémon";
            this.btnBuscarPorNombrePokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombrePokemon.Click += new System.EventHandler(this.btnBuscarPorNombrePokemon_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Kanto",
            "Johto",
            "Hoenn",
            "Sinnoh",
            "Teselia/Unova",
            "Kalos",
            "Alola",
            "Galar",
            "Paldea"});
            this.cbRegion.Location = new System.Drawing.Point(173, 170);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(219, 24);
            this.cbRegion.TabIndex = 100;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(173, 102);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(219, 22);
            this.tbNombre.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(100, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Región:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(124, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Reportes Entrenador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(64, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 274);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 660);
            this.Controls.Add(this.tbEdadMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarLegendarios);
            this.Controls.Add(this.btnBuscarPorRangoEdadEntrenadores);
            this.Controls.Add(this.tbEdadMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBuscarPorMaxPSPokemon);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.btnBuscarPorMenorCantPokemon);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPorRegion);
            this.Controls.Add(this.btnBuscarPorNombrePokemon);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEdadMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarLegendarios;
        private System.Windows.Forms.Button btnBuscarPorRangoEdadEntrenadores;
        private System.Windows.Forms.TextBox tbEdadMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscarPorMaxPSPokemon;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Button btnBuscarPorMenorCantPokemon;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarPorRegion;
        private System.Windows.Forms.Button btnBuscarPorNombrePokemon;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}