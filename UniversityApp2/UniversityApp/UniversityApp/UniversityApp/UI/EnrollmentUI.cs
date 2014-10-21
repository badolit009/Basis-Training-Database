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
    public partial class EnrollmentUI : Form
    {
        public EnrollmentUI()
        {
            
            InitializeComponent();
            GateAllCourse();
            GetAllStudent();
            EnrollDataShow();
        }

        
        private StudentBLL aStudentBll = new StudentBLL();
        
        private CourseBLL aCourseBll = new CourseBLL();
        private EnrollmentBLL anEnrollmentBll = new EnrollmentBLL();
        private Student aStudent = new Student();
        private Course aCourse = new Course();
        private Enrollment anEnrollment;

        private void enrollButton_Click(object sender, EventArgs e)
        {
            anEnrollment = new Enrollment();
            anEnrollment.DateTime = enrollDateTimePicker.Value;
            anEnrollment.CourseId = aCourse.Id;
            anEnrollment.StudentId = aStudent.Id;
            anEnrollment.ACourse = (Course) nameComboBox.SelectedItem;
            anEnrollment.AStudent = (Student) regiNoComboBox.SelectedItem;
            string msg = anEnrollmentBll.Save(anEnrollment);
            MessageBox.Show(msg);
            EnrollDataShow();
        }

        private void EnrollDataShow()
        {

            List < Enrollment > aEnrollments = anEnrollmentBll.EnrollDataShow();
            foreach (Enrollment aEnrollment in aEnrollments)
            {

                ListViewItem item = new ListViewItem(aEnrollment.AStudent.RegNo);

                item.SubItems.Add(aEnrollment.ACourse.Name);
                item.SubItems.Add(aEnrollment.DateTime.ToString());
                listView1.Items.Add(item);
            }
        }

        private void GetAllStudent()
         {
             List<Student> aStudents = aStudentBll.GetAllStudent();
             foreach (Student aStudent in aStudents)
             {
                 regiNoComboBox.Items.Add(aStudent);
             }
             regiNoComboBox.DisplayMember = "RegNo";
             regiNoComboBox.ValueMember = "Id";
         }
        private void GateAllCourse()
        {
            List<Course> courses = aCourseBll.GateAllCourse();
            foreach (Course course in courses)
            {
                nameComboBox.Items.Add(course);
            }
            nameComboBox.DisplayMember = "Name";
            nameComboBox.ValueMember = "Id";
        }

    }
}
