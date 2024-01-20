using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public  class Course:AuditableEntity
    {
        public int Credits { get; set; }
        public string Description { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public string CoursePopularity { get; set; }
        public float PassGrade { get; set; }
        public int EnrollmentCapacity { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Guid ParentCourseId { get; set; }
        public Course ParentCourse { get; set; }
        public ICollection<Course> Childrens { get; set; }

        public Guid FeeId { get; set; }
        public Fee Fee { get; set; }

        public Guid SubjectOfAreaId { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
