using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab08.controllers
{
    class InmuebleController
    {
        private bool Existe(String codigoInmueble)
        {
            List<Agencia> agencias = AgenciaController.ListarTodo();
            return agencias.Exists(a => a.Inmuebles.Exists(i => i.Codigo.Equals(codigoInmueble)));
        }

        public bool Registrar(String codigoAgencia, Inmueble inmueble)
        {
            if (Existe(inmueble.Codigo))
            {
                return false;
            }

            List<Agencia> agencias = AgenciaController.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            agencia.Inmuebles.Add(inmueble);
            return true;
        }

        public List<Inmueble> ListarTodo(String codigoAgencia)
        {
            List<Agencia> agencias = AgenciaController.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));
            return agencia.Inmuebles;
        }

        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            List<Agencia> agencias = AgenciaController.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agencia == null) return new List<Inmueble>();

            return agencia.Inmuebles
                .Where(i => i.Condicion.Equals("Venta"))
                .ToList();
        }

        public double MontoTotalAlquilerInmuebles()
        {
            List<Agencia> agencias = AgenciaController.ListarTodo();

            double monto = agencias
                .SelectMany(a => a.Inmuebles)
                .Where(i => i.Condicion.Equals("Alquiler"))
                .ToList()
                .Sum(i => i.Precio);

            return monto;
        }
    }
}
