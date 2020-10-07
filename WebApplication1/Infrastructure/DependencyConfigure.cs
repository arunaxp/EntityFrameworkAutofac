

using System.Web.Mvc;
using Autofac;
using Data;
using Entity;
using Service;

namespace WebApplication1.Infrastructure
{
    internal class DependencyConfigure
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(
                new Dependency(RegisterServices(builder))
                );
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(
                typeof(WebApiApplication).Assembly
                ).PropertiesAutowired();

            //deal with your dependencies here
            builder.RegisterType<DataContext>().As<IDbContext>().InstancePerDependency();

            builder.RegisterGeneric(typeof(RepositoryService<>)).As(typeof(IRepository<>));

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();


            return
                builder.Build();
        }


    }
}