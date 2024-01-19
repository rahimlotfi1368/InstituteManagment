using AutoMapper;
using InstituteManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.Course.Queries.GetAllCourses
{
    public class GetCourseListQueryHandler : IRequestHandler<GetCourseListQuery, List<CourseOutPutDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository  _courseRepository;

        public GetCourseListQueryHandler(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }
        public async Task<List<CourseOutPutDto>> Handle(GetCourseListQuery request, CancellationToken cancellationToken)
        {
            var allCourses = (await _courseRepository.GetListAsync()).OrderBy(c => c.CreatedDate);
            var allCoursesOutput = _mapper.Map<List<CourseOutPutDto>>(allCourses);
            return allCoursesOutput;
        }
    }
}
