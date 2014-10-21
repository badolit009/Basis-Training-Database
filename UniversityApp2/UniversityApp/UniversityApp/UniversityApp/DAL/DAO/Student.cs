using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.DAO
{
    class Student
    {
        public int Id { get; set; }
        public string  RegNo { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }

        public Student(string regNo, string email, string address):this()
        {
            RegNo = regNo;
            Email = email;
            Address = address;
        }

        public Student()
        {
        }
    }
}
