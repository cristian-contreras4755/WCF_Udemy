using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;
using System.ServiceProcess;
using System.ComponentModel;

namespace Pacagroup.Comercial.Creditos.InstaladorWinService
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            var process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;

            var service = new ServiceInstaller();
            service.ServiceName = "WCFServicioCliente";

            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
