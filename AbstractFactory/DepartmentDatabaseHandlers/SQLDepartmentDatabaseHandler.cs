using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SQLDepartmentDatabaseHandler : DepartmentDatabaseHandler
    {
        public void DeleteDepartment()
        {
            Console.WriteLine("Deleting Department from SQL database");
        }

        public void GetDepartment()
        {
            Console.WriteLine("Getting Department from SQL database");
        }
        
        public void CreateDepartment()
        {
            Console.WriteLine("Creating Department in SQL database");
        }

        public void UpdateDepartment()
        {
            Console.WriteLine("Updating Department in SQL database");
        }
    }
}
