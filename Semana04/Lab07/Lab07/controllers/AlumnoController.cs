using Lab07.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07.repositories
{
    class AlumnoController
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        private bool Existe(String dni)
        {
            return alumnos.Exists(a => a.Dni.Equals(dni));
        }

        public bool Registrar(Alumno alumno)
        {
            if (Existe(alumno.Dni))
            {
                return false;
            }

            alumno.Codigo = GenerarCodigo();
            alumnos.Add(alumno);
            return true;
        }

        public static List<Alumno> ListarTodo()
        {
            return alumnos;
        }

        public void Eliminar(int codigo)
        {
            alumnos.RemoveAll(alumno => alumno.Codigo.Equals(codigo));
        }

        private int GenerarCodigo()
        {
            if (alumnos.Count == 0)
            {
                return 1;
            }

            int ultimo = alumnos.Last().Codigo;
            return ultimo + 1;
        }
    }
}
