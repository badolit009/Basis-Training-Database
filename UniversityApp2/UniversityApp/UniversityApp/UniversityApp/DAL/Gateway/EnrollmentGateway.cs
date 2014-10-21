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
    class EnrollmentGateway
    {
        private SqlConnection connection;
        public EnrollmentGateway()
        {
            connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Save(Enrollment anEnrollment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO Enrollment VALUES ({0},{1},'{2}')", anEnrollment.AStudent.Id, anEnrollment.ACourse.Id,anEnrollment.DateTime);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Student Result Added successfull.";
            }
            return "Somthing wrong";
        }

        public List<Enrollment> EnrollDataShow()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM Enroll_View");
            SqlCommand command = new SqlCommand(query,connection);
            List<Enrollment> anEnrollments = new List<Enrollment>();
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    
                    Enrollment anEnrollment = new Enrollment();
                    anEnrollment.ACourse = new Course();
                    anEnrollment.AStudent = new Student();
                    anEnrollment.Id =(int) aReader[0];
                    anEnrollment.CourseId = (int) aReader[1];
                    anEnrollment.StudentId = (int) aReader[2];
                    anEnrollment.AStudent.RegNo = aReader[3].ToString();
                    anEnrollment.ACourse.Name = aReader[4].ToString();
                    anEnrollment.DateTime = (DateTime) aReader[5];
                    anEnrollment.ACourse.Code = aReader[6].ToString();
                    anEnrollment.ACourse.Id = (int) aReader[7];
                    anEnrollment.ACourse.Credit = aReader[8].ToString();
                    anEnrollment.AStudent.Address = aReader[9].ToString();
                    anEnrollment.AStudent.Email = aReader[10].ToString();
                    anEnrollment.AStudent.Id = (int) aReader[11];
                    anEnrollments.Add(anEnrollment);
                }
            }
            connection.Close();
            return anEnrollments;
        }
    }
}
