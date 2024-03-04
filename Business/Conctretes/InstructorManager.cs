using Business.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conctretes
{
    public  class InstructorManager :II
    {
        private readonly IInstructorServices _services;
        public InstructorManager(IInstructorServices services) 
        {
            _services = services;
        }

        public void Add(Instructor instructor)
        {
            _services.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _services.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _services.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _services.Update(instructor);
        }
    }
}
