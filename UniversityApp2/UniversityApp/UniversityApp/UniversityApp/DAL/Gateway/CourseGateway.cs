using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;

namespace UniversityApp.DAL.Gateway
{
    class CourseGateway
    {
        private SqlConnection connection;
        public CourseGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Save(Course aCourse)
        {
            connection.Open();
            string quary = String.Format("INSERT INTO t_Course VALUES('{0}','{1}','{2}')", aCourse.Code, aCourse.Name, aCourse.Credit);
            SqlCommand command=new SqlCommand(quary,connection);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows>0)
            {
                return "Course Added Successfully";

            }
            return "Something Wrong";
        }

        public List<Course> GateAllCourse()
        {
            connection.Open();
            string quary = "SELECT * FROM t_Course";
            SqlCommand command = new SqlCommand(quary, connection);
            List<Course> courses = new List<Course>();
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.Id = (int) aReader[0];
                    aCourse.Code = aReader[1].ToString();
                    aCourse.Name = aReader[2].ToString();
                    aCourse.Credit = aReader[3].ToString();
                    courses.Add(aCourse);
                }
            }
            connection.Close();
            return courses;
        }
    }
}
