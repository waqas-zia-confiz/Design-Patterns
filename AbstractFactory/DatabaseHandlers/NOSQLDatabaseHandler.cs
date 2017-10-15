using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DatabaseHandlers
{
    public class NOSQLDatabaseHandler : DatabaseHandler
    {
        public DepartmentDatabaseHandler GetDepartmentDatabaseHandler()
        {
            return new NOSQLDepartmentDatabaseHandler();
        }

        public EmployeeDatabaseHandler GetEmployeeDatabaseHandler()
        {
            return new NOSQLEmployeeDatabaseHandler();
        }
    }
}
