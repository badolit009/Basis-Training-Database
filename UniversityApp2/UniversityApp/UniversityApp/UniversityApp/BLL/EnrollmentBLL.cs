using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class EnrollmentBLL
    {
        private EnrollmentGateway anEnrollmentGateway;
        public EnrollmentBLL()
        {
            anEnrollmentGateway = new EnrollmentGateway();
        }

        public string Save(Enrollment anEnrollment)
        {
            return anEnrollmentGateway.Save(anEnrollment);
        }

        public List<Enrollment> EnrollDataShow()
        {
            return anEnrollmentGateway.EnrollDataShow();
        }
    }
}
