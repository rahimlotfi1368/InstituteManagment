using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using InstituteManagment.Application.Features.SubjectOfArea.Commands.UpdateSubject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.SubjectOfArea.Commands.DeleteSubject
{
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand, Unit>
    {
        private readonly IMapper? _mapper;
        private readonly ISubjectOfAreaRepository? _subjectOfAreaRepository;

        public DeleteSubjectCommandHandler(IMapper? mapper, ISubjectOfAreaRepository? subjectOfAreaRepository)
        {
            _mapper = mapper;
            _subjectOfAreaRepository = subjectOfAreaRepository;
        }

        public async Task<Unit> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var foundedSubject = await _subjectOfAreaRepository.GetByIdAsync(request.SubjectOfAreaId);
            await _subjectOfAreaRepository.DeleteAsync(foundedSubject);
            return Unit.Value;
        }
    }
}
