using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class CourseBLL
    {
        private CourseGateway aCourseGateway = new CourseGateway();
        public string Save(Course aCourse)
        {
            return aCourseGateway.Save(aCourse);

        }
        public  List<Course> GateAllCourse()
        {
            return aCourseGateway.GateAllCourse();

        }

        
    }
}
