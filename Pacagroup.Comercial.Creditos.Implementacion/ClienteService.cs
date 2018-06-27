using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            try
            {
                using (var instancia = new ClienteFachada())
                {
                    return instancia.ObtenerCliente(numeroDocumento);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error() { CodigoError = "10001" , Descripcion = "Exception Administrada por el Servicio", Mensaje = ex.Message});
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            using (var instancia = new ClienteFachada())
            {
                return instancia.ListarCliente();
            }
        }
    }
}
