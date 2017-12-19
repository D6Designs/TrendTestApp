using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.BusinessServices;
using TrendTestApp.BusinessServices.Interfaces;
using TrendTestApp.ModelServices;
using TrendTestApp.ModelServices.Interfaces;
using TrendTestApp.Repository;
using TrendTestApp.Repository.Interfaces;

namespace TrendTestApp.Common
{
    public static class IoCInit
    {
        private static ILifetimeScope AppScope;
        private static IContainer AppContainer;
        public static void InitialiseIoC()
        {
            var builder = new ContainerBuilder();
            //repos
            builder.RegisterType<DataContext>().SingleInstance().As<IDataContext>();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();

            //business services
            builder.RegisterType<CompanyBusinessService>().As<ICompanyBusinessService>();


            //builder.RegisterType<>().As<I>();
            //ms
            builder.RegisterType<CompanyModelService>().As<ICompanyModelService>();



            AppContainer = builder.Build();


        }

        public static ILifetimeScope GetScope()
        {

            return AppScope ?? (AppScope = AppContainer.BeginLifetimeScope());
        }


    }
}
