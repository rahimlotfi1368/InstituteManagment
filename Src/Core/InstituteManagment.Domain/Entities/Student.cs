using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Student:User
    {
        public int StudentPerformance { get; set; }
        public int StudentState { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public SubjectOfArea SubjectOfArea { get; set; }
        public Guid SubjectOfAreaId { get; set; }
    }
}
