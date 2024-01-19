using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.Course.Queries.GetAllCourses
{
    public class GetCourseListQuery:IRequest<List<CourseOutPutDto>>
    {
    }
}
