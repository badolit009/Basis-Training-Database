using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDepartmentApp.BLL;
using StudentDepartmentApp.DLL.DAO;

namespace StudentDepartmentApp
{
    public partial class DepartmentUI : Form
    {
        private DepartmentBLL aDepartmentBll = new DepartmentBLL();
        private Department aDepartment;
        private List<Department> departments;

        public DepartmentUI()
        {
            InitializeComponent();
            ShowGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(nameTextBox.Text, codeTextBox.Text);
            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);
            ShowGridView();
        }

        private void ShowGridView()
        {
            departments = aDepartmentBll.Show(aDepartment);
            departmentGrideView.DataSource = departments;
            
        }

    }
}
