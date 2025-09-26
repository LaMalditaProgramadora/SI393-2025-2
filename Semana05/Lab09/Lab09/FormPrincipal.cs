using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            FormEntrenador form = new FormEntrenador();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
