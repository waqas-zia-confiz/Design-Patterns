using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHandlerFactory factory = new DatabaseHandlerFactory();
            Console.WriteLine("Enter Input as described below:");
            Console.WriteLine("Enter " + (int)Databases.SQL + " to create a SQL database handler for employee");
            Console.WriteLine("Enter " + (int)Databases.MYSQL + " to create a MYSQL database handler for employee");
            Console.WriteLine("Enter " + (int)Databases.NOSQL + " to create a NOSQL database handler for employee");
            Console.WriteLine("Input: ");
            EmployeeDatabaseHandler handler = null;
            var input = Console.ReadLine();
            int database = int.Parse(input);
            if (database == (int)Databases.MYSQL) 
                handler = factory.createEmployeeDatabaseHandler(Databases.MYSQL);
            else if (database == (int)Databases.SQL)
                handler = factory.createEmployeeDatabaseHandler(Databases.SQL);
            else 
                handler = factory.createEmployeeDatabaseHandler(Databases.NOSQL);

            handler.CreateEmployee();
            handler.DeleteEmployee();
            handler.GetEmployee();
            handler.UpdateEmployee();
        }
    }
}
