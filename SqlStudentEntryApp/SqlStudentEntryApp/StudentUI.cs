using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlStudentEntryApp
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;


            string conn = @"server=BADOL-PC; database=AbcUniversity;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query =string.Format("INSERT INTO t_student VALUES('{0}','{1}','{2}')",aStudent.Name,aStudent.Email,aStudent.Address);
            SqlCommand command = new SqlCommand(query,connection);
            int affectedrow = command.ExecuteNonQuery();
            connection.Close();

            if (affectedrow > 0)

                MessageBox.Show("Insert success");
            else

            {
                MessageBox.Show("Some Problem");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=BADOL-PC; database=AbcUniversity;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = string.Format(@"SELECT * FROM t_student");
            SqlCommand command = new SqlCommand(query,connection);
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
            studentDataGridView.DataSource=students;

        }

    }
}
