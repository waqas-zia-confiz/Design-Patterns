using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class DatabaseHandlerFactory
    {
        public EmployeeDatabaseHandler createEmployeeDatabaseHandler(Databases database) {
            if (database == Databases.MYSQL)
                return new MYSQLEmployeeDatabaseHandler();
            else if (database == Databases.NOSQL)
                return new NOSQLEmployeeDatabaseHandler();
            else
                return new SQLEmployeeDatabaseHandler();
        }
    }
}
