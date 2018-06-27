using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface ICreditoRepositorio
    {
        IEnumerable<Credito> ListarCredito();
        Credito ObtenerCredito(string idCredito);
        Credito RegistrarCredito(Credito credito);
        Credito ActualizarCredito(Credito credito);
        bool EliminarCredito(string idCredito);
    }
}
