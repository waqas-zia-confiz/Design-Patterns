using AbstractFactory.DatabaseHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class MYSQLDatabaseHandlerFactory : DatabaseHandlerFactory
    {
        static readonly object _lock = new object();
        private static DatabaseHandlerFactory instance;
        public DatabaseHandler GetDatabaseHandler() => new MYSQLDatabaseHandler();
        public static DatabaseHandlerFactory GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new MYSQLDatabaseHandlerFactory();
                    }
                }
            }
            return instance;
        }
    }
}
