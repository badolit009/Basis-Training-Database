using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.UI;

namespace UniversityApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseUI aCourseUi = new CourseUI();
            aCourseUi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentUI aStudentUi = new StudentUI();
            aStudentUi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnrollmentUI aEnrollmentUi = new EnrollmentUI();
            aEnrollmentUi.ShowDialog();
        }
    }
}
