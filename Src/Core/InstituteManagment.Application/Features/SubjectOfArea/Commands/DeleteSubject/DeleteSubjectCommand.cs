using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.DeleteSubject
{
    public class DeleteSubjectCommand:IRequest<Unit>
    {
        public Guid SubjectOfAreaId { get; set; }
    }
}
