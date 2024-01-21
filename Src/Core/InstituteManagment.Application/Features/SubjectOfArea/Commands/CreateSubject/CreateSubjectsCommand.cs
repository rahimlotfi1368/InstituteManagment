using InstituteManagment.Application.Dtos.SubjectOfAreas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.CreateSubject
{
    public class CreateSubjectsCommand:IRequest<Guid>
    {
        public string? SubjectOfAreaName { get; set; }
    }
}
