using System.ComponentModel;
using System.ServiceProcess;

namespace z.Web.Hosting
{
    [RunInstaller(true)]
    public sealed class MyServiceInstallerProcess : ServiceProcessInstaller
    {
        public MyServiceInstallerProcess()
        {
            this.Account = ServiceAccount.NetworkService;
        }
    }
    [RunInstaller(true)]
    public sealed class MyServiceInstaller : ServiceInstaller
    {
        public MyServiceInstaller()
        {
            this.Description = "z.Web.Hosting";
            this.DisplayName = "z.Web.Hosting";
            this.ServiceName = "z.Web.Hosting";
            this.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
        }
    }
     
}
