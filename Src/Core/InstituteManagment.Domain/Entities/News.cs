using InstituteManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Domain.Entities
{
    public class News:AuditableEntity
    {
        public string Title { get; set; }
        public string NewsImage { get; set; }
        public string Body { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }

        public SubjectOfArea SubjectOfArea { get; set; }
        public Guid SubjectOfAreaId { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
