using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Queries.GetAllSubjects
{
    public class GetSubjectsQuery:IRequest<List<SubjectOutPutDto>>
    {
    }
}
