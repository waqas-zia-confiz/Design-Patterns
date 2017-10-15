using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class NOSQLDepartmentDatabaseHandler :DepartmentDatabaseHandler
    {
        public void DeleteDepartment()
        {
            Console.WriteLine("Deleting Department from NOSQL database");
        }

        public void GetDepartment()
        {
            Console.WriteLine("Getting Department from NOSQL database");
        }

        public void CreateDepartment()
        {
            Console.WriteLine("Creating Department in NOSQL database");
        }

        public void UpdateDepartment()
        {
            Console.WriteLine("Updating Department in NOSQL database");
        }
    }
}
