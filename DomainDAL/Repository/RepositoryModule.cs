using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDAL.DataAccessLayer;
using DomainDAL.Objects;
using Ninject;
using Ninject.Modules;

namespace DomainDAL.Repository
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<>()
            //    .ToMethod
            //    (
            //        e =>
            //            Fluently.Configure()
            //                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c =>
            //                    c.FromConnectionStringWithKey("JustBlogDbConnString")))
            //                .Cache(c => c.UseQueryCache().ProviderClass<HashtableCacheProvider>())
            //                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Post>())
            //                //.ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false))
            //                .BuildConfiguration()
            //                .BuildSessionFactory()
            //    )
            //    .InSingletonScope();

            var connectionString = "";
            Bind<IBlogRepository>().To<BlogRepository>()
                .WithConstructorArgument("sqlConnectionString", connectionString);


        }
    }
}
