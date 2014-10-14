using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDepartmentEntryApp.DLL.DAO;

namespace StudentDepartmentEntryApp.DLL.Gateway
{
    class DepartmentGateway
    {
        private SqlConnection connection;
        public DepartmentGateway()
        {
            string conn = @"server=BADOL-PC; database=University; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string Save(Department aDepartment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Department VALUES('{0}','{1}')", aDepartment.Code, aDepartment.Name);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows > 0)
            {
                return "insert success";
            }
            return "some wrong";
        }

        public bool HasThisName(string name)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Department WHERE Name=('{0}')", name);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool HasRow = aReader.HasRows;
            connection.Close();
            return HasRow;
        }

        public bool HasThisCode(string code)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Department WHERE Code=('{0}')",code);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool HasRow = aReader.HasRows;
            connection.Close();
            return HasRow;
        }

        public List<Department> ShowAllDepartment()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Department");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartments = new Department();
                    aDepartments.DepartmentID = (int)aReader[0];
                    aDepartments.Code = aReader[1].ToString();
                    aDepartments.Name = aReader[2].ToString();
                    departments.Add(aDepartments);
                }
            }
            connection.Close();
            return departments;
        }
    }
}
