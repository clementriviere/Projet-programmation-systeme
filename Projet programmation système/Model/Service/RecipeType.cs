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



        public void Add(Business.RecipeType RecipeType)
        {
;
        }


        public void Delete(int id)
        {

        }


        public void Update(Business.RecipeType RecipeType)
        {
        }


        public List<Business.RecipeType> Get()
        {
            return null;

        }


        public Business.RecipeType Get(int Id)
        {
            return null;
        }
    }
}
