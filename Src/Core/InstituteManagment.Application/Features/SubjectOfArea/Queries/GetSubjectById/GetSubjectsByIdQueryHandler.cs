using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using InstituteManagment.Application.Dtos.SubjectOfAreas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Queries.GetSubjectById
{
    public class GetSubjectsByIdQueryHandler : IRequestHandler<GetSubjectsByIdQuery, SubjectOutPutDto>
    {
        private readonly IMapper _mapper;
        private readonly ISubjectOfAreaRepository _SubjectRepository;

        public GetSubjectsByIdQueryHandler(IMapper mapper, ISubjectOfAreaRepository subjectRepository)
        {
            _mapper = mapper;
            _SubjectRepository = subjectRepository;
        }

        public async Task<SubjectOutPutDto> Handle(GetSubjectsByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await _SubjectRepository.GetByIdAsync(request.Id);
            return _mapper.Map<SubjectOutPutDto>(subject);
        }
    }
}
