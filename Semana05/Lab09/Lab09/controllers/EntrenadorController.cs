using Lab09.entities;
using System;
using System.Collections.Generic;

namespace Lab09.controllers
{
    internal class EntrenadorController
    {
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        public bool Existe(String codigo)
        {
            return entrenadores.Exists(en => en.Codigo.Equals(codigo));
        }

        public bool Registrar(Entrenador entrenador)
        {
            if (Existe(entrenador.Codigo))
            {
                return false;
            }

            entrenadores.Add(entrenador);
            return true;
        }

        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }
    }
}
