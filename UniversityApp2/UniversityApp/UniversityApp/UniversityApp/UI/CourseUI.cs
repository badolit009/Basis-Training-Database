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
    public partial class CourseUI : Form
    {
        public CourseUI()
        {
            InitializeComponent();
            AllCourseShow();
        }
        private CourseBLL aCourseBll = new CourseBLL();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Course aCourse=new Course(codeTextBox.Text,nameTextBox.Text,creditTextBox.Text);

            string msg = aCourseBll.Save(aCourse);
            MessageBox.Show(msg);
            AllCourseShow();
        }
        private void AllCourseShow()
        {
            List<Course> aCourses = aCourseBll.GateAllCourse();
            foreach (Course aCourse in aCourses)
            {
                
                ListViewItem item = new ListViewItem(aCourse.Code);
                item.SubItems.Add(aCourse.Name);
                item.SubItems.Add(aCourse.Credit);
                listView1.Items.Add(item);
                
            }

        }

    }
}
