using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;
using UniversityApp.DLL.GATEWAY;

namespace UniversityApp.BLL
{
    class StudentBLL
    {
        private StudentGetway aStudentGetway;

        public StudentBLL()
        {
            aStudentGetway = new StudentGetway();
        }


        public string Save(Student aStudent)
        {
            if (aStudent.Name == string.Empty || aStudent.Email == string.Empty || aStudent.Address == string.Empty)
            {
                return "PlZ fill the all fields";

            }
            else
            {
                if (!HasThisEmailValid(aStudent.Email))
                {
                    return aStudentGetway.Save(aStudent);
                }
                else
                {
                    return "Email Address Already In System";
                }
            }   
        }
        public bool HasThisEmailValid(string email)
        {
           return aStudentGetway.HasThisEmailValid(email);
        }
        public List<Student> GetAllStudent()
        {
            return aStudentGetway.GetAllStudent();
        }
    }
}
