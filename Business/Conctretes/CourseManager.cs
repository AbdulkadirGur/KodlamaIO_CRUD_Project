using Business.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conctretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseService _courseService;

        public CourseManager(ICourseService courseService) 
        {
            _courseService = courseService;
        }
        public void Add(Course course)
        {
            _courseService.Add(course);    
        }

        public void Delete(Course course)
        {
            _courseService.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseService.GetAll();
        }

        public void Update(Course course)
        {
            _courseService.Update(course);
        }
    }
}
