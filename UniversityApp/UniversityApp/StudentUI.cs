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
using UniversityApp.DLL.DAO;

namespace UniversityApp
{
    public partial class StudentUI : Form
    {
        StudentBLL aStudentBll = new StudentBLL();
        private List<Student> students;

        public StudentUI()
        {
            InitializeComponent();
            ShowDataInGird();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            string msg=aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
            ShowDataInGird();

        }

        private void ShowDataInGird()
        {

            students = aStudentBll.GetAllStudent();
            studentGrideView.DataSource = students;
        }
    }
}
