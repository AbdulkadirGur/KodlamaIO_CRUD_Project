using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctretes
{
    public class InstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 5;
            instructor1.Name = "Engin Demirog";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 6;
            instructor2.Name = "Abdulkadir Gur";

            instructors = new List<Instructor>() { instructor1,instructor2};
        }
    }
}
