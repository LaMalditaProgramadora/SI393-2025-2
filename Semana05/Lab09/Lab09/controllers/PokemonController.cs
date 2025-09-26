using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab09.controllers
{
    internal class PokemonController
    {
        public bool Existe(String codigoPokemon)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            List<Pokemon> pokemons = entrenadores.SelectMany(e => e.Pokemons).ToList();
            return pokemons.Exists(p => p.Codigo.Equals(codigoPokemon));
        }

        public bool Registrar(String codigoEntrenador, Pokemon pokemon)
        {
            if (Existe(pokemon.Codigo))
            {
                return false;
            }

            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            Entrenador entrenador = entrenadores.Find(en => en.Codigo.Equals(codigoEntrenador));

            entrenador.Pokemons.Add(pokemon);
            return true;
        }

        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            List<Entrenador> entrenadores = EntrenadorController.ListarTodo();
            Entrenador entrenador = entrenadores.Find(en => en.Codigo.Equals(codigoEntrenador));

            return entrenador.Pokemons;
        }
    }
}
