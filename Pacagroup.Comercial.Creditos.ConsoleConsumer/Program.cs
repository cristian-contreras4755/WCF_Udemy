using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Xml;
using Pacagroup.Comercial.Creditos.ConsoleConsumer.ProxyCredito;
using Pacagroup.Comercial.Creditos.Dominio;

namespace Pacagroup.Comercial.Creditos.ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rest();
            Soap();
        }

        private static void Rest()
        {
            WebClient proxy = new WebClient();
            string serviceURL = "http://localhost/WcfServiceCliente/CreditoService.svc/rest/ListarCredito";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);

            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Credito>));

            IEnumerable<Credito> credito = obj.ReadObject(stream) as IEnumerable<Credito>;

            if (credito != null)
                foreach (var item in credito)
                {
                    Console.WriteLine("IdCredito : " + item.IdCredito + " Fecha : " + item.Fecha +  " Monto : " + item.Monto);
                }

            Console.ReadLine();
        }

        private static void Soap()
        {
            ProxyCredito.CreditoServiceClient proxy = new CreditoServiceClient();
            IEnumerable<Credito> colleccion = proxy.ListarCredito();

            if (colleccion != null)
                foreach (var item in colleccion)
                {
                    Console.WriteLine("IdCredito : " + item.IdCredito + " Fecha : " + item.Fecha + " Monto : " + item.Monto);
                }

            if (proxy.State == CommunicationState.Opened)
                proxy.Close();

            Console.ReadLine();
        }
    }
}
