using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class StudentBLL
    {
        private StudentGateway aStudentGateway = new StudentGateway();
        public string Save(Student aStudent)
        {
            return aStudentGateway.Save(aStudent);
        }

        public List<Student> GetAllStudent()
        {
            return aStudentGateway.GetAllStudent();
        }
    }
}
