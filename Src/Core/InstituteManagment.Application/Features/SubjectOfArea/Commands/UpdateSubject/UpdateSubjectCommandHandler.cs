using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.UpdateSubject
{
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand, Unit>
    {
        private readonly IMapper? _mapper;
        private readonly ISubjectOfAreaRepository? _subjectOfAreaRepository;

        public UpdateSubjectCommandHandler(ISubjectOfAreaRepository? subjectOfAreaRepository, IMapper? mapper)
        {
            _subjectOfAreaRepository = subjectOfAreaRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var foundedSubject =await _subjectOfAreaRepository.GetByIdAsync(request.SubjectOfAreaId);
            _mapper.Map(request, foundedSubject, typeof(UpdateSubjectCommand), typeof(InstituteManagment.Domain.Entities.SubjectOfArea));
            await _subjectOfAreaRepository.UpdateAsync(foundedSubject);
            return Unit.Value;
        }
    }
}
