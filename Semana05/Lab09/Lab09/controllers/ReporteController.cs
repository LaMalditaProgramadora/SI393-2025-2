using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab09.controllers
{
    internal class ReporteController
    {
        public List<Entrenador> ListarEntrenadorPorRegion(String region)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            return entrenadores
                .Where(e => e.Region.Equals(region))
                .ToList();
        }

        public List<Entrenador> ListarEntrenadorPorNombrePokemon(String nombrePokemon)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            return entrenadores
                .Where(e => e.Pokemons.Exists(p => p.Nombre.Contains(nombrePokemon)))
                .ToList();
        }

        public List<Object> ListarEntrenadoresPorMenorCantidadPokemon()
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            var reporte = entrenadores
                .Select(r => new
                {
                    CodigoEntrenador = r.Codigo,
                    CantidadPokemon = r.Pokemons.Count
                })
                .OrderBy(r => r.CantidadPokemon)
                .Cast<Object>()
                .ToList();

            return reporte;
        }

        public List<Object> ListarEntrenadoresPorMaxPuntosSaludPokemon()
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            var reporte = entrenadores
                 .Select(r => new
                 {
                     CodigoEntrenador = r.Codigo,
                     MaxPuntosSalud =
                        r.Pokemons.Count == 0 ?
                        0 : r.Pokemons.Max(p => p.PuntosSalud)
                 })
                 .OrderBy(r => r.MaxPuntosSalud)
                 .Cast<Object>()
                 .ToList();

            return reporte;
        }

        public List<Pokemon> ListarPokemonsLegendarios()
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            List<Pokemon> pokemons = entrenadores.SelectMany(e => e.Pokemons).ToList();

            return pokemons.Where(p => p.Legendario.Equals(true)).ToList();
        }

        public List<Pokemon> ListarPokemonsPorEdadEntrenadores(int edadMin, int edadMax)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            entrenadores = entrenadores.Where(e => e.Edad >= edadMin && e.Edad <= edadMax).ToList();

            List<Pokemon> pokemons = entrenadores.SelectMany(e => e.Pokemons).ToList();
            return pokemons;
        }
    }
}
