using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;

namespace UniversityApp.DAL.Gateway
{
    class StudentGateway
    {
        private SqlConnection connection;
        public StudentGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Save(Student aStudent)
        {
            connection.Open();
            string quary = String.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}')",aStudent.RegNo,aStudent.Email,aStudent.Address);
            SqlCommand command = new SqlCommand(quary, connection);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows > 0)
            {
                return "Course Added Successfully";

            }
            return "Something Wrong";
        }

        public List<Student> GetAllStudent()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student");
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Student> aStudents = new List<Student>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.Id = (int) aReader[0];
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    aStudent.Address = aReader[3].ToString();
                    aStudents.Add(aStudent);

                }

            }
            connection.Close();
            ;
            return aStudents;
        }
    }
}
