using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using InstituteManagment.Application.Dtos.Courses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.Course.Queries.GetCourseDetails
{
    public class GetCourseDetailsQueryHandler : IRequestHandler<GetCourseDetailsQuery, CourseOutPutDto>
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;

        public GetCourseDetailsQueryHandler(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public async Task<CourseOutPutDto> Handle(GetCourseDetailsQuery request, CancellationToken cancellationToken)
        {
            var @Course =await _courseRepository.GetByIdAsync(request.Id);
            var courseDto=_mapper.Map<CourseOutPutDto>(@Course);
            return courseDto;
        }
    }
}
