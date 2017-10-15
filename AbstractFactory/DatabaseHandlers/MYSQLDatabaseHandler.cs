using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DatabaseHandlers
{
    public class MYSQLDatabaseHandler:DatabaseHandler
    {
        public  DepartmentDatabaseHandler GetDepartmentDatabaseHandler()
        {
            return new MYSQLDepartmentDatabaseHandler();
        }

        public EmployeeDatabaseHandler GetEmployeeDatabaseHandler()
        {
            return new MYSQLEmployeeDatabaseHandler();
        }
    }
}
