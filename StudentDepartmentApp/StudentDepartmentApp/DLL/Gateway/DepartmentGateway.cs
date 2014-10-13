using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentApp.DLL.DAO;

namespace StudentDepartmentApp.DLL.Gateway
{
    class DepartmentGateway
    {
        private SqlConnection connection;

        public DepartmentGateway()
        {
            string conn = @"server=BADOL-PC;database=AbcUniversity; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string Save(Department aDepartment)
        {


            connection.Open();
            string query = string.Format("INSERT INTO Department VALUES('{0}','{1}')", aDepartment.Name, aDepartment.Code);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedrow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Insert Success";
            }
            return "some problem";

        }

        public bool HasThisCodeValid(string code)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM Department WHERE Code=('{0}') ", code);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public bool HasThisNameValid(string name)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM Department WHERE Name=('{0}') ", name);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public List<Department> Show(Department aDepartment)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM Department");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aDepartment = new Department();
                    aDepartment.DepartmentID = (int)aReader[0];
                    aDepartment.Name = aReader[1].ToString();
                    aDepartment.Code = aReader[2].ToString();

                    departments.Add(aDepartment);
                }
            }
            connection.Close();
            return departments;
        }
    }
}
