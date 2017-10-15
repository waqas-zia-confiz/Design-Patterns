using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MYSQLDepartmentDatabaseHandler : DepartmentDatabaseHandler
    {
        public void DeleteDepartment()
        {
            Console.WriteLine("Deleting Department from MYSQL database");
        }

        public void GetDepartment()
        {
            Console.WriteLine("Getting Department from MYSQL database");
        }

        public void CreateDepartment()
        {
            Console.WriteLine("Creating Department in MYSQL database");
        }

        public void UpdateDepartment()
        {
            Console.WriteLine("Updating Department in MYSQL database");
        }
    }
}
