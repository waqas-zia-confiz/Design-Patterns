using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class MYSQLEmployeeDatabaseHandler : EmployeeDatabaseHandler
    {
        public void DeleteEmployee()
        {
            Console.WriteLine("Deleting Employee from MYSQL database");
        }

        public void GetEmployee()
        {
            Console.WriteLine("Getting Employee from MYSQL database");
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Creating Employee in MYSQL database");
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Updating Employee in MYSQL database");
        }
    }
}
