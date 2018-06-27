using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public IEnumerable<Credito> ListarCredito()
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ListarCredito();
            }
        }

        public Credito ObtenerCredito(string idCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ObtenerCredito(idCredito);
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.RegistrarCredito(credito);
            }
        }

        public Credito ActualizarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ActualizarCredito(credito);
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.EliminarCredito(idCredito);
            }
        }
    }
}
