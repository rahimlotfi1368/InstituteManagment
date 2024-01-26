using InstituteManagment.Application.Dtos.Courses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.Course.Queries.GetCourseDetails
{
    public class GetCourseDetailsQuery:IRequest<CourseOutPutDto>
    {
        public Guid Id { get; set; }
    }
}
