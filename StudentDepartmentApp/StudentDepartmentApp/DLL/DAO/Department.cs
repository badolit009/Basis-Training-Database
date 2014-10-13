using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentApp.DLL.DAO
{
    class Department
    {
        public int DepartmentID { get; set; }
        public string  Name { get; set; }
        public string Code { get; set; }

        public Department(string name, string code):this()
        {
            Name = name;
            Code = code;
        }

        public Department()
        {
        }
    }
    
}
