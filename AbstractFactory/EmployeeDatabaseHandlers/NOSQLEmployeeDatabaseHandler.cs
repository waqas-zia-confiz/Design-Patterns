using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class NOSQLEmployeeDatabaseHandler :EmployeeDatabaseHandler
    {
        public void DeleteEmployee()
        {
            Console.WriteLine("Deleting Employee from NOSQL database");
        }

        public void GetEmployee()
        {
            Console.WriteLine("Getting Employee from NOSQL database");
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Creating Employee in NOSQL database");
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Updating Employee in NOSQL database");
        }
    }
}
