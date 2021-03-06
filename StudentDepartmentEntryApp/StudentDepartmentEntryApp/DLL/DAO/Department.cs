﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentEntryApp.DLL.DAO
{
    class Department
    {
        public int DepartmentID { get; set;}
        public string  Code { get; set; }
        public string Name { get; set; }

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
        }
    }
}
