using Lab08.controllers;
using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormReporte : Form
    {
        private AgenciaController agenciaController = new AgenciaController();
        private InmuebleController inmuebleController = new InmuebleController();

        public FormReporte()
        {
            InitializeComponent();

            // Calcular monto total alquiler
            lblMontoTotalAlquilerInmuebles.Text = inmuebleController.MontoTotalAlquilerInmuebles().ToString();
        }

        private void MostrarAgencias(List<Object> agencias)
        {
            dgAgencias.DataSource = null;
            if (agencias.Count != 0)
            {
                dgAgencias.DataSource = agencias;
            }
        }

        private void MostrarInmuebles(List<Inmueble> inmuebles)
        {
            dgInmuebles.DataSource = null;
            if (inmuebles.Count != 0)
            {
                dgInmuebles.DataSource = inmuebles;
            }
        }

        private void btnAgenciasAlquilerInmueblesMayorSuperficie_Click(object sender, EventArgs e)
        {
            MostrarAgencias(agenciaController.ListarMayorSuperficieInmueblesAlquiler());
        }

        private void btnAgenciasMayorCantidadInmueblesVenta_Click(object sender, EventArgs e)
        {
            MostrarAgencias(agenciaController.ListarMayorCantidadInmueblesVenta());
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código de agencia");
                return;
            }

            String codigoAgencia = tbBuscar.Text;

            MostrarInmuebles(inmuebleController.ListarPorAgenciaVenta(codigoAgencia));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
