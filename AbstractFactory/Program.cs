using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHandlerFactory factory;
            Console.WriteLine("Enter Input as described below:");
            Console.WriteLine("Enter " + (int)Databases.SQL + " to create a SQL database handler for employee");
            Console.WriteLine("Enter " + (int)Databases.MYSQL + " to create a MYSQL database handler for employee");
            Console.WriteLine("Enter " + (int)Databases.NOSQL + " to create a NOSQL database handler for employee");
            Console.WriteLine("Input: ");
            DatabaseHandler handler = null;
            var input = Console.ReadLine();
            int database = int.Parse(input);
            if (database == (int)Databases.MYSQL)
                factory = MYSQLDatabaseHandlerFactory.GetInstance();
            else if (database == (int)Databases.NOSQL)
                factory = NOSQLDatabaseHandlerFactory.GetInstance();
            else
                factory = SQLDatabaseHandlerFactory.GetInstance();

            EmployeeDatabaseHandler employeeHandler = factory.GetDatabaseHandler().GetEmployeeDatabaseHandler();
            DepartmentDatabaseHandler departmentHandler = factory.GetDatabaseHandler().GetDepartmentDatabaseHandler();

            employeeHandler.CreateEmployee();
            employeeHandler.DeleteEmployee();
            employeeHandler.GetEmployee();
            employeeHandler.UpdateEmployee();

            departmentHandler.CreateDepartment();
            departmentHandler.DeleteDepartment();
            departmentHandler.GetDepartment();
            departmentHandler.UpdateDepartment();
        }
    }
    
}
