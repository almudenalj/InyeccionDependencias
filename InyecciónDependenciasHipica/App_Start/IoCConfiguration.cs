using Autofac;
using Autofac.Integration.Mvc;
using InyecciónDependenciasHipica.Models;
using InyecciónDependenciasHipica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace InyecciónDependenciasHipica.App_Start
{
    public class IoCConfiguration
    {
        public static void RegistrarControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers
            (Assembly.GetExecutingAssembly());
        }


        public static void RegistrarRepos(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryCaballo>()
                .As<IRepositoryCaballo>().InstancePerRequest();
        }


        public static void RegitrarClases(ContainerBuilder builder)
        {
            builder.Register(z => new CaballosContext()).
                            InstancePerRequest();
        }


        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegistrarControllers(builder);
            RegistrarRepos(builder);
            RegitrarClases(builder);

            IContainer contenedor = builder.Build();

            DependencyResolver.SetResolver
                (new AutofacDependencyResolver(contenedor));
        }
    }
}