using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class SubjectOfArea:AuditableEntity
    {
        public string SubjectOfAreaName { get; set; }

        public Department Department { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public ICollection<Course> Courses { get; set; }
               
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<News>  NewsList { get; set; }

        
    }
}
