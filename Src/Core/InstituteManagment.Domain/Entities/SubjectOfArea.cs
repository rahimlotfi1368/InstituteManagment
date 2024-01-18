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

        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public Course Course { get; set; }
               
        public Enrollment Enrollment { get; set; }

        
    }
}
