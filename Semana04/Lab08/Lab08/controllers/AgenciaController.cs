using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab08.controllers
{
    class AgenciaController
    {
        private static List<Agencia> agencias = new List<Agencia>();

        private bool Existe(String codigo)
        {
            return agencias.Exists(a => a.Codigo.Equals(codigo));
        }

        public bool Registrar(Agencia agencia)
        {
            if (Existe(agencia.Codigo))
            {
                return false;
            }

            agencias.Add(agencia);
            return true;
        }

        public static List<Agencia> ListarTodo()
        {
            return agencias;
        }

        public List<Object> ListarMayorCantidadInmueblesVenta()
        {
            var agenciasCantidad = agencias
                .Select(a => new
                {
                    Agencia = a.Codigo,
                    CantidadInmuebles = a.Inmuebles.Count(i => i.Condicion.Equals("Venta"))
                })
                .OrderByDescending(a => a.CantidadInmuebles)
                .Cast<Object>()
                .ToList();

            return agenciasCantidad;
        }

        public List<Object> ListarMayorSuperficieInmueblesAlquiler()
        {

            var agenciasMayorSuperficie = agencias
                .Select(a => new
                {
                    Agencia = a.Codigo,
                    SuperficieMaximaInmueble = a.Inmuebles.Count != 0 ?
                        a.Inmuebles.Max(i => i.Superficie) :
                        0
                })
                .OrderByDescending(a => a.SuperficieMaximaInmueble)
                .Cast<Object>()
                .ToList();

            return agenciasMayorSuperficie;
        }
    }
}
