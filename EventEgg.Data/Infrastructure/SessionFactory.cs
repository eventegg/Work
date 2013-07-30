using FluentNHibernate;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;

namespace EventEgg.Data.Infrastructure
{
    public static class SessionFactory
    {
        public static ISessionFactory CreateFactory<T>() where T : class
        {

            IPersistenceConfigurer persistenceConfigurer =
               MsSqlConfiguration.MsSql2008.ConnectionString
                       (c => c.FromConnectionStringWithKey("ConnectionString"));

            Configuration cfg = persistenceConfigurer.ConfigureProperties(new Configuration());
            var persistenceModel = new PersistenceModel();
            var assembly = typeof(T).Assembly;
            persistenceModel.AddMappingsFromAssembly(assembly);
            persistenceModel.Configure(cfg);
            return cfg.BuildSessionFactory();

        }
    }
}
