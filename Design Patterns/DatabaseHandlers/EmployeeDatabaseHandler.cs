﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public interface EmployeeDatabaseHandler
    {
        void GetEmployee();
        void CreateEmployee();
        void UpdateEmployee();
        void DeleteEmployee();
    }
}
