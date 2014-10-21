using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp.UI
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            GetAllStudent();
        }

        private StudentBLL aStudentBll = new StudentBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regNoTextBox.Text,emailTextBox.Text,addressTextBox.Text);
            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
            GetAllStudent();

        }
        private void GetAllStudent()
        {
            List<Student> aStudents = aStudentBll.GetAllStudent();
            dataGridView1.DataSource = aStudents;
        }
    }
}
