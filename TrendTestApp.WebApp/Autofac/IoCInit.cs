using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TrendTestApp.BusinessServices;
using TrendTestApp.BusinessServices.Interfaces;
using TrendTestApp.ModelServices;
using TrendTestApp.ModelServices.Interfaces;
using TrendTestApp.Repository;
using TrendTestApp.Repository.Interfaces;
using TrendTestApp.Models;
using TrendTestApp.WebApp.Models;
using TrendTestApp.WebApp;

namespace TrendTestApp.Web
{
    public class IoCInit
    {

        private static ILifetimeScope AppScope;
        private static IContainer AppContainer;
        public static void InitialiseIoC(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationDbContext>().AsSelf().InstancePerRequest();
            builder.Register<IAuthenticationManager>(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register<IDataProtectionProvider>(c => app.GetDataProtectionProvider()).InstancePerRequest();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //repos
            builder.RegisterType<DataContext>().SingleInstance().As<IDataContext>();

            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();


            builder.RegisterType<CompanyBusinessService>().As<ICompanyBusinessService>();


            builder.RegisterType<CompanyModelService>().As<ICompanyModelService>();



            AppContainer = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(AppContainer));

            // REGISTER WITH OWIN
            app.UseAutofacMiddleware(AppContainer);
            app.UseAutofacMvc();

        }

        public static ILifetimeScope GetScope()
        {

            return AppScope ?? (AppScope = AppContainer.BeginLifetimeScope());
        }

    }
}
