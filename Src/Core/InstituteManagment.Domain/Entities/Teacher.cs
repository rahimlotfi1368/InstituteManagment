using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Teacher:User
    {
        public int Experience { get; set; }
        public int TeacherPerformance { get; set; }
        public int TeacherState { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Course> Courses { get; set; }

        public SubjectOfArea SubjectOfArea { get; set; }
        public Guid SubjectOfAreaId { get; set; }
    }
}
