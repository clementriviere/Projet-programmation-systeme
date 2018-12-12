using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class Recipe
    {
        public Model.Data.Context Context;

        public Recipe()
        {
            Context = new Context();
        }

        public List<Business.Recipe> Get()
        {
            return Business.Mapper.Recipe.Map(Context.Recipe.ToList());
        }


        public Business.Recipe Get(int Id)
        {
            return (from c in Context.Recipe where c.Id == Id select Business.Mapper.Recipe.Map(c)).FirstOrDefault(); 
        }
    }
}
