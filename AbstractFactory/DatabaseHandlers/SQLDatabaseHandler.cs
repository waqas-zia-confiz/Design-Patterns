using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DatabaseHandlers
{
    public class SQLDatabaseHandler:DatabaseHandler
    {

        public DepartmentDatabaseHandler GetDepartmentDatabaseHandler()
        {
            return new SQLDepartmentDatabaseHandler();
        }

        public EmployeeDatabaseHandler GetEmployeeDatabaseHandler()
        {
            return new SQLEmployeeDatabaseHandler();
        }
    }
}
