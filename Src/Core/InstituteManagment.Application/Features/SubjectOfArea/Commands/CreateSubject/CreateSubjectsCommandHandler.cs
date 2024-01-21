using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using InstituteManagment.Application.Dtos.SubjectOfAreas;
using InstituteManagment.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.CreateSubject
{
    public class CreateSubjectsCommandHandler : IRequestHandler<CreateSubjectsCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ISubjectOfAreaRepository _subjectOfAreaRepository;

        public CreateSubjectsCommandHandler(IMapper mapper, ISubjectOfAreaRepository subjectOfAreaRepository)
        {
            _mapper = mapper;
            _subjectOfAreaRepository = subjectOfAreaRepository;
        }

        public async Task<Guid> Handle(CreateSubjectsCommand request, CancellationToken cancellationToken)
        {
            var @subjectOfArea= _mapper.Map<InstituteManagment.Domain.Entities.SubjectOfArea>(request);

            @subjectOfArea = await _subjectOfAreaRepository.AddAsync(@subjectOfArea);
            return @subjectOfArea.Id;
        }
    }
}
