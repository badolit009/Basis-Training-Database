using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentEntryApp.DLL.DAO;
using StudentDepartmentEntryApp.DLL.DAO.VIEW;
using StudentDepartmentEntryApp.DLL.Gateway;

namespace StudentDepartmentEntryApp.BLL
{
    class StudentBLL
    {
        private StudentGateway aStudentGateway;

        public StudentBLL()
        {
            aStudentGateway = new StudentGateway();
        }

        public string Save(Student aStudent)
        {
            if (aStudent.RegNo == string.Empty || aStudent.Name == string.Empty || aStudent.Email == string.Empty)
            {
                return "Plz fill All The Fields";
            }
            else
            {
                
                if (!HasThisEmailValid(aStudent))
                {
                    return aStudentGateway.Save(aStudent);
                }
                else
                {
                    return "This Email Already Exits";
                }
            }
        }

        private bool HasThisEmailValid(Student aStudent)
        {
            return aStudentGateway.HasThisEmailValid(aStudent);
        }


        internal List<StudentDepartmentView> ShowAllStudent()
        {
            return aStudentGateway.ShowAllStudent();
        }
    }
}
