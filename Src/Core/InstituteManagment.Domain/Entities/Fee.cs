using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Fee:AuditableEntity
    {
        public ICollection<Course> Courses { get; set; }

        public string FeeName { get; set; }
        public Decimal FeeAmount { get; set; }
        public Decimal Discount { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
    }
}
