﻿using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using MMORPG.Mappings;

namespace MMORPG
{
    internal class DataLayer
    {
        private static ISessionFactory? _factory = null;
        private static object objLock = new object();

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory!.OpenSession();
        }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18234;Password=princeBlue!05"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PlayerMapping>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                return null;
            }

        }
    }
}
