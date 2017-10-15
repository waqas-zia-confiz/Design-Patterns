using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SQLEmployeeDatabaseHandler : EmployeeDatabaseHandler
    {
        public void DeleteEmployee()
        {
            Console.WriteLine("Deleting Employee from SQL database");
        }

        public void GetEmployee()
        {
            Console.WriteLine("Getting Employee from SQL database");
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Creating Employee in SQL database");
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Updating Employee in SQL database");
        }
    }
}
