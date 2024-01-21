using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.UpdateSubject
{
    public class UpdateSubjectCommand:IRequest<Unit>
    {
        public Guid SubjectOfAreaId { get; set; }
        public string? SubjectOfAreaName { get; set; }
    }
}
