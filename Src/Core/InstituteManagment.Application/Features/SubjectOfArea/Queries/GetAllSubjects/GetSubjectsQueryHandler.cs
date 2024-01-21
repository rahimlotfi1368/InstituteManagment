using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using InstituteManagment.Application.Dtos.SubjectOfAreas;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Queries.GetAllSubjects
{
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, List<SubjectOutPutDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISubjectOfAreaRepository _SubjectRepository;

        public GetSubjectsQueryHandler(IMapper mapper, ISubjectOfAreaRepository subjectRepository)
        {
            _mapper = mapper;
            _SubjectRepository = subjectRepository;
        }

        public async Task<List<SubjectOutPutDto>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            var allSubjects = (await _SubjectRepository.GetListAsync()).OrderBy(s => s.CreatedDate).ToList();
            return _mapper.Map<List<SubjectOutPutDto>>(allSubjects);
        }
    }
}
