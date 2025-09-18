using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerAgencias_Click(object sender, EventArgs e)
        {
            FormAgencia form = new FormAgencia();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
