using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class Comment:AuditableEntity
    {
        public string? CommentText { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }

        public Course Course { get; set; }
        public Guid CourseId { get; set; }

        public News News { get; set; }
        public Guid NewsId { get; set; }
    }
}
