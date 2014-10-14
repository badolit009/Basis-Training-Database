using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDepartmentEntryApp.BLL;
using StudentDepartmentEntryApp.DLL.DAO;
using StudentDepartmentEntryApp.DLL.DAO.VIEW;

namespace StudentDepartmentEntryApp.UI
{
    public partial class StudentUI : Form
    {
        private Student aStudent;
        private StudentBLL aStudentBll=new StudentBLL();
        private List<StudentDepartmentView> students;

        public StudentUI()
        {
            InitializeComponent();
            ShowGridView();
            ShowDepartmentComboBox();
        }

        private void ShowDepartmentComboBox()
        {
            DepartmentBLL aDepartmentBll = new DepartmentBLL();
            List<Department> departments = aDepartmentBll.ShowAllDepartment();
            foreach (Department aDepartment in departments)
            {
                departmentComboBox.Items.Add(aDepartment);
            }
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "DepartmentID";
        }
        private void ShowGridView()
        {
            students = aStudentBll.ShowAllStudent();
            studentGrideView.DataSource = students;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student(regNoTextBox.Text,nameTextBox.Text,emailTextBox.Text);
            Department aDepartment = (Department) departmentComboBox.SelectedItem;
            aStudent.DepartmentID = aDepartment.DepartmentID;
            aStudentBll = new StudentBLL();
            string msg=aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
        }
    }
}
