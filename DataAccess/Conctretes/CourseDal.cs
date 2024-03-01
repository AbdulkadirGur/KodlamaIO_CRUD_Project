using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctretes
{
    public class CourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course1.Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
            course1.Author = "Engin Demirog";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course2.Description = "";
            course2.Author = "Abdulkadir Gur";
            course2.Price = 10;

            courses= new List<Course>() { course1,course2};
        }
    }
}
