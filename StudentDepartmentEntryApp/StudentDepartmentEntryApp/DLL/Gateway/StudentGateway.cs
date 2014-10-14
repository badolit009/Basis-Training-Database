using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentEntryApp.DLL.DAO;
using StudentDepartmentEntryApp.DLL.DAO.VIEW;

namespace StudentDepartmentEntryApp.DLL.Gateway
{
    class StudentGateway
    {
        private SqlConnection connection;

        public StudentGateway()
        {
            string conn = @"server=BADOL-PC; database=University; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string Save(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}',{3})",aStudent.RegNo,aStudent.Name,aStudent.Email,aStudent.DepartmentID);
            SqlCommand command = new SqlCommand(query,connection);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows > 0)
            {
                return "insert success";
            }
            return "some wrong";
        }

        public bool HasThisEmailValid(Student aStudent)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE Email=('{0}')",aStudent.Email);
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool HasRow = aReader.HasRows;
            connection.Close();
            return HasRow;
           
          
        }

        public List<StudentDepartmentView> ShowAllStudent()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM View_1");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<StudentDepartmentView> students = new List<StudentDepartmentView>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    StudentDepartmentView aStudentDepartmentView = new StudentDepartmentView();

                    aStudentDepartmentView.RegNo = aReader[0].ToString();
                    aStudentDepartmentView.Name = aReader[1].ToString();
                    aStudentDepartmentView.Email = aReader[2].ToString();
                    aStudentDepartmentView.DepCode =aReader[3].ToString();
                    aStudentDepartmentView.DepName = aReader[4].ToString();
                    students.Add(aStudentDepartmentView);
                }
            }
            connection.Close();
            return students;

        }
    }
}
