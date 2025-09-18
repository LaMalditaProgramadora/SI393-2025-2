using Lab08.controllers;
using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormInmueble : Form
    {
        private String codigoAgencia;
        private InmuebleController inmuebleController = new InmuebleController();

        public FormInmueble(String codigoAgencia)
        {
            InitializeComponent();
            this.codigoAgencia = codigoAgencia;
            // Mostrar
            MostrarInmuebles(inmuebleController.ListarTodo(codigoAgencia));
        }

        private void MostrarInmuebles(List<Inmueble> inmuebles)
        {
            dgInmuebles.DataSource = null;
            if (inmuebles.Count != 0)
            {
                dgInmuebles.DataSource = inmuebles;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbDireccion.Text == "" || tbSuperficie.Text == "" || tbPrecio.Text == "" || cbCondicion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Inmueble inmueble = new Inmueble()
            {
                Codigo = tbCodigo.Text,
                Direccion = tbDireccion.Text,
                Superficie = double.Parse(tbSuperficie.Text),
                Precio = double.Parse(tbPrecio.Text),
                Condicion = cbCondicion.Text
            };

            // Registrar
            bool registrado = inmuebleController.Registrar(codigoAgencia, inmueble);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar
            MostrarInmuebles(inmuebleController.ListarTodo(codigoAgencia));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
