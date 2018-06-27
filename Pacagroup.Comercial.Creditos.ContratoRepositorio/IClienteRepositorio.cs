using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerCliente(string numeroDocumento);

        IEnumerable<Cliente> ListarCliente();
    }
}
