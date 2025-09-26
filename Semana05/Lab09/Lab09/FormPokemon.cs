using Lab09.controllers;
using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormPokemon : Form
    {
        private PokemonController pokemonController = new PokemonController();
        private String codigoEntrenador;

        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            this.codigoEntrenador = codigoEntrenador;
            MostrarDatagrid(pokemonController.ListarTodo(codigoEntrenador));
        }

        private void MostrarDatagrid<T>(List<T> lista)
        {
            dgPokemons.DataSource = null;

            if (lista.Count != 0)
            {
                dgPokemons.DataSource = lista;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || cbTipo.Text == "" || tbPs.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validar si tiene más de 6 pokémos
            if (pokemonController.ListarTodo(codigoEntrenador).Count == 6)
            {
                MessageBox.Show("No se puede agregar más de 6 pokémons");
                return;
            }

            // Crear el objeto
            Pokemon pokemon = new Pokemon()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPs.Text),
                Legendario = chBEsLegendario.Checked
            };

            // Registramos
            bool registrado = pokemonController.Registrar(codigoEntrenador, pokemon);
            if (!registrado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            MostrarDatagrid(pokemonController.ListarTodo(codigoEntrenador));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
