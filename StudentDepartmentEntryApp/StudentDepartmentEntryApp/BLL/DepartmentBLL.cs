using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentEntryApp.DLL.DAO;
using StudentDepartmentEntryApp.DLL.Gateway;

namespace StudentDepartmentEntryApp.BLL
{
    class DepartmentBLL
    {
        private DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {
            if(aDepartment.Code==string.Empty||aDepartment.Name==string.Empty)
            {
                return "Plz Fill All The Fields";
            }
            else
            {
                String msg = "";
                if (HasThisCode(aDepartment.Code) || HasThisName(aDepartment.Name))
                {
                    
                    if (HasThisCode(aDepartment.Code))
                    {
                        msg += "Code Is Already Exits In System\n";
                    }

                    if (HasThisName(aDepartment.Name))
                    {
                        msg += "\nName Is Already Exits In System";
                    }
                }
                else
                {
                    return aDepartmentGateway.Save(aDepartment);
                }
                return msg; 
            }
        }

        private bool HasThisName(string name)
        {
            return aDepartmentGateway.HasThisName(name);
        }

        private bool HasThisCode(string code)
        {
            return aDepartmentGateway.HasThisCode(code);
        }

        public List<Department> ShowAllDepartment()
        {
           return aDepartmentGateway.ShowAllDepartment();
        }
    }
}
