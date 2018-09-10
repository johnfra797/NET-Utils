using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Utils.Auto_Fac;

namespace Utils.Unity_
{
    public class unity
    {
        public unity()
        {
            var container = new UnityContainer();
            container.RegisterType<IMobileServive, SMSService>();
            container.RegisterType<IMailService, EmailService>();

            container.Resolve<IMobileServive>().Execute();
            container.Resolve<IMailService>().Ejecutar();
        }
    }
}
