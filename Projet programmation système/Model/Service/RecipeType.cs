using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class RecipeType
    {
        public Model.Data.Context Context;

        public RecipeType()
        {
            Context = new Context();
        }


        public List<Business.RecipeType> Get()
        {
            return Business.Mapper.RecipeType.Map(Context.RecipeType.ToList());
        }


        public Business.RecipeType Get(int Id)
        {
            return (from c in Context.RecipeType where c.Id == Id select Business.Mapper.RecipeType.Map(c)).FirstOrDefault();
        }
    }
}
