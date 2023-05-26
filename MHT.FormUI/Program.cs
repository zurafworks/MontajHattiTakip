using Autofac;
using MHT.Business.Abstract;
using MHT.Business.Concrete;
using MHT.DataAccess.Abstract;
using MHT.DataAccess.Concrete.EntityFramework;
using MHT.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using ZrfMusteriTakip.FormUI;
using MHT.DataAccess.Concrete.Contexts;

namespace MHT.FormUI
{
    internal static class Program
    {
        public static IContainer Container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new LoginUI(Container.Resolve<IIslemService>(), Container.Resolve<IKullaniciService>(), Container.Resolve<IKullanimService>(), Container.Resolve<IMakineService>(), Container.Resolve<IVardiyaService>()));
        }


        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // DI Container'a kayýtlarý ekleyin
            builder.RegisterType<MhtContext>().As<DbContext>();

            // Business
            builder.RegisterType<IslemManager>().As<IIslemService>();
            builder.RegisterType<KullaniciManager>().As<IKullaniciService>();
            builder.RegisterType<KullanimManager>().As<IKullanimService>();
            builder.RegisterType<MakineManager>().As<IMakineService>();
            builder.RegisterType<VardiyaManager>().As<IVardiyaService>();

            // DAL
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>();
            builder.RegisterType<EfIslemDal>().As<IIslemDal>();
            builder.RegisterType<EfKullanimDal>().As<IKullanimDal>();
            builder.RegisterType<EfMakineDal>().As<IMakineDal>();
            builder.RegisterType<EfVardiyaDal>().As<IVardiyaDal>();

            // UnitOfWork
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            // GirisYapForm
            builder.RegisterType<LoginUI>();

            return builder.Build();
        }

    }
}