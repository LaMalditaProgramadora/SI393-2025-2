using Lab09.controllers;
using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormEntrenador : Form
    {
        private EntrenadorController entrenadorController = new EntrenadorController();

        public FormEntrenador()
        {
            InitializeComponent();
            MostrarDatagrid(EntrenadorController.ListarTodo());
        }

        private void MostrarDatagrid<T>(List<T> lista)
        {
            dgEntrenadores.DataSource = null;

            if (lista.Count != 0)
            {
                dgEntrenadores.DataSource = lista;
            }
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbEdad.Text == "" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Entrenador entrenador = new Entrenador()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Edad = int.Parse(tbEdad.Text),
                Region = cbRegion.Text,
                Pokemons = new List<Pokemon>()
            };

            // Registrar
            bool registrado = entrenadorController.Registrar(entrenador);
            if (!registrado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar Datagrid
            MostrarDatagrid(EntrenadorController.ListarTodo());
        }

        private void btnVerPokemon_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (dgEntrenadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador");
                return;
            }

            String codigoEntrenador = dgEntrenadores.SelectedRows[0].Cells[0].Value.ToString();
            // Abrir formulario de Pokémon enviando el código del entrenador
            FormPokemon form = new FormPokemon(codigoEntrenador);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }
    }
}
