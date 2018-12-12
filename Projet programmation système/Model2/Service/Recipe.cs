using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.Data;

namespace Model.Service
{
    public class Recipe
    {
        public Model.Data.Context Context;

        public Recipe()
        {
            Context = new Model.Data.Context();
        }

        public List<Business.Recipe> Get()
        {
            return (from c in Context.Recipe.Include(i => i.RecipeType) select Business.Mapper.Recipe.Map(c)).ToList();
        }


        public Business.Recipe Get(int Id)
        {
            return (from c in Context.Recipe where c.Id == Id select Business.Mapper.Recipe.Map(c)).FirstOrDefault(); 
        }
    }
}
