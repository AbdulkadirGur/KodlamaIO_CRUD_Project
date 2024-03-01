using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class Course :BaseProp
    {
        
        public string Description { get; set; }
        
        public string  Author { get; set; }

        public decimal Price { get; set; }


    }
}
