using InstituteManagment.Application.Dtos.SubjectOfAreas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Queries.GetSubjectById
{
    public class GetSubjectsByIdQuery:IRequest<SubjectOutPutDto>
    {
        public Guid Id { get; set; }
    }
}
