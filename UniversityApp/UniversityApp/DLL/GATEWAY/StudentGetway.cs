using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;

namespace UniversityApp.DLL.GATEWAY
{
    class StudentGetway
    {
        private SqlConnection connection;

        public StudentGetway()
        {
            string conn = @"server=BADOL-PC; database=AbcUniversity; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string Save(Student aStudent)
        {

            connection.Open();
            string query = string.Format("INSERT INTO t_student VALUES('{0}','{1}','{2}')", aStudent.Name, aStudent.Email, aStudent.Address);
            SqlCommand command = new SqlCommand(query, connection);
            int affactedrow = command.ExecuteNonQuery();
            connection.Close();
            if (affactedrow > 0)
            {
                return "success";
            }
            return "some problem";

        }

        public bool HasThisEmailValid(string email)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_student WHERE Email='{0}'", email);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;

        }

        public List<Student> GetAllStudent()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_student");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.StudentID = (int) aReader[0];
                    aStudent.Name = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    aStudent.Address = aReader[3].ToString();
                    students.Add(aStudent);
                }
            }
            connection.Close();
            return students;

        }
    }
}
