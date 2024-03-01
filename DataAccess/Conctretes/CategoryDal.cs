using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctretes
{
    public  class CategoryDal
    {
        List<Category> catagorys;
        public CategoryDal() 
        {
            Category catagory1 = new Category();
            catagory1.Name = "Tümü";
            catagory1.Id = 3;

            Category catagory2 = new Category();
            catagory2.Name = "Programlama";
            catagory2.Id = 4;

            catagorys = new List<Category>() { catagory1 ,catagory2};
        }

    }
}
