using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Auto_Fac
{
    public interface IMobileServive
    {
        void Execute();
    }
    public class SMSService : IMobileServive
    {
        public void Execute()
        {
            Console.WriteLine("SMS service executing.");
        }
    }

    public interface IMailService
    {
        void Ejecutar();
    }

    public class EmailService : IMailService
    {
        public void Ejecutar()
        {
            Console.WriteLine("Email service Ejecutando.");
        }
    }

    public class autoFac
    {
        public autoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SMSService>().As<IMobileServive>();
            builder.RegisterType<EmailService>().As<IMailService>();
            var container = builder.Build();

            container.Resolve<IMobileServive>().Execute();
            container.Resolve<IMailService>().Ejecutar();
        }
    }
}
