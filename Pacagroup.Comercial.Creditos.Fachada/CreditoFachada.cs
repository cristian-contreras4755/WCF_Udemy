using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> ListarCredito()
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ListarCredito();
        }

        public Credito ObtenerCredito(string idCredito)
        {
            ICreditoRepositorio creditoRepositorio = new CreditoRepositorio();
            return creditoRepositorio.ObtenerCredito(idCredito);
        }

        public Credito RegistrarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.RegistrarCredito(credito);
        }
        public Credito ActualizarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ActualizarCredito(credito);
        }
        public bool EliminarCredito(string idCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.EliminarCredito(idCredito);
        }
        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
