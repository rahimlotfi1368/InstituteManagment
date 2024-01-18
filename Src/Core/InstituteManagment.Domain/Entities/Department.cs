using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Department:AuditableEntity
    {
        public Guid HeadId { get; set; }
        public string DepartmentName { get; set; }
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Guid SubjectOfAreaId { get; set; }

        public ICollection<Student>  Students { get; set; }

        public ICollection<Teacher>  Teachers { get; set; }

        public ICollection<Course>  Courses { get; set; }

    }
}
