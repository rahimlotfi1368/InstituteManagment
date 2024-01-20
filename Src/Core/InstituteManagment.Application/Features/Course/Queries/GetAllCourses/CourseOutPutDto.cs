using InstituteManagment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Features.Course.Queries.GetAllCourses
{
    public class CourseOutPutDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public string CoursePopularity { get; set; }
        public float PassGrade { get; set; }
        public int EnrollmentCapacity { get; set; }
        public string DepartmentName { get; set; }       
        public string TeacherName { get; set; }            
        public ICollection<CourseOutPutDto> Prerequisites { get; set; }
        public Decimal FeeAmount { get; set; }
    }
}
