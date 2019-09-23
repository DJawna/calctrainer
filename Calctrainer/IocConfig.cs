using Autofac;
using CalctrainerContracts.repositories;
using MySQLDAL.repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Debug.Assert(contractInterfaces.Any(),$"expecting interfaces in module {nameof(CalctrainerContracts)}");

           
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MySQLDAL)))
                .Where(t => 
                {
                    var retval = t.Namespace.Contains(nameof(MySQLDAL.repositories));
                    return retval;
                })
                .As(at =>
                {
                    var retval2 = contractInterfaces.Single(ci => ci.Name == ("I" + at.Name));
                    return retval2;
                });


            return builder.Build();
        }
    }
}
