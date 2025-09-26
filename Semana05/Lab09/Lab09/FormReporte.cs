using Lab09.controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormReporte : Form
    {
        private ReporteController reporteController = new ReporteController();

        public FormReporte()
        {
            InitializeComponent();
        }


        private void MostrarDatagrid<T>(List<T> lista)
        {
            dgReporte.DataSource = null;

            if (lista.Count != 0)
            {
                dgReporte.DataSource = lista;
            }
        }

        private void btnBuscarPorNombrePokemon_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            String nombrePokemon = tbNombre.Text;
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese la región");
                return;
            }

            String region = cbRegion.Text;
            MostrarDatagrid(reporteController.ListarEntrenadorPorRegion(region));
        }

        private void btnBuscarPorMenorCantPokemon_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(reporteController.ListarEntrenadoresPorMenorCantidadPokemon());
        }

        private void btnBuscarPorMaxPSPokemon_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(reporteController.ListarEntrenadoresPorMaxPuntosSaludPokemon());
        }

        private void btnBuscarPorRangoEdadEntrenadores_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEdadMin.Text == "" || tbEdadMax.Text == "")
            {
                MessageBox.Show("Ingrese el rango de edad");
                return;
            }

            int edadMin = int.Parse(tbEdadMin.Text);
            int edadMax = int.Parse(tbEdadMax.Text);
            MostrarDatagrid(reporteController.ListarPokemonsPorEdadEntrenadores(edadMin, edadMax));
        }

        private void btnBuscarLegendarios_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(reporteController.ListarPokemonsLegendarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
