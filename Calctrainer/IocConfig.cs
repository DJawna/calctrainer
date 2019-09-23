using Autofac;
using CalctrainerContracts.repositories;
using MySQLDAL.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calctrainer
{
    public static class IocConfig
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            var contractInterfaces = Assembly.Load(nameof(CalctrainerContracts)).GetTypes().Where(i => i.IsInterface);

           
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MySQLDAL)))
                .Where(t => t.Namespace.Equals(nameof(MySQLDAL.repositories)))
                .As(at => contractInterfaces.Single(ci => ci.Name == "I" + at.Name));


            return builder.Build();
        }
    }
}
