using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentApp.DLL.DAO;
using StudentDepartmentApp.DLL.Gateway;

namespace StudentDepartmentApp.BLL
{
    class DepartmentBLL
    {
        private DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {
            if (aDepartment.Name == string.Empty || aDepartment.Code == string.Empty)
            {
                return "Plz fill all field";
            }
            else
            {
                if (HasThisCodeValid(aDepartment.Code)||HasThisNameValid(aDepartment.Name))
                {
                    string msg = "";
                    if (HasThisCodeValid(aDepartment.Code))
                    {
                        msg+="This Code Already Exists In System\n";
                    }
                    if (HasThisNameValid(aDepartment.Name))
                    {
                        msg += "This Name Already Exists In System\n";
                    }
                    return msg;

                }
                else
                {
                    return aDepartmentGateway.Save(aDepartment);
                }
            }
            
        }

        private bool HasThisNameValid(string name)
        {
            return aDepartmentGateway.HasThisNameValid(name);
        }

        private bool HasThisCodeValid(string code)
        {
            return aDepartmentGateway.HasThisCodeValid(code);
        }

        public List<Department> Show(Department aDepartment)
        {
          return  aDepartmentGateway.Show(aDepartment);
        }
    }
}
