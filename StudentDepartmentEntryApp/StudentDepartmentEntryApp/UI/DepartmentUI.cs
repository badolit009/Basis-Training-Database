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

namespace StudentDepartmentEntryApp.UI
{
    public partial class DepartmentUI : Form
    {
        private Department aDepartment;
        DepartmentBLL aDepartmentBll = new DepartmentBLL();

        public DepartmentUI()
        {
            InitializeComponent();
            ShowGridView();
        }

        private void ShowGridView()
        {
            List<Department> aDepartments = aDepartmentBll.ShowAllDepartment();
            departmentGrideView.DataSource = aDepartments;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(codeTextBox.Text,nameTextBox.Text);
            string msg=aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);
            ShowGridView();

        }
    }
}
