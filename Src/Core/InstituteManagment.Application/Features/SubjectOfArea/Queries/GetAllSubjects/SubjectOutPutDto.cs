using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Queries.GetAllSubjects
{
    public class SubjectOutPutDto
    {
        public Guid SubjectOfAreaId { get; set; }
        public string SubjectOfAreaName { get; set; }
    }
}
