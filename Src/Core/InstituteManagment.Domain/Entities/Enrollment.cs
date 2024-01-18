using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Enrollment:AuditableEntity
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid SubjectOfAreaId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int EnrollmentStatus { get; set; }
        public int EnrollmentPassStatus { get; set; }
        public int EnrollmentPayStatus { get; set; }
        public float Grade { get; set; }
    }
}
