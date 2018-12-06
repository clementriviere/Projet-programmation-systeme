using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class Ingredient
    {
        public Model.Data.Context Context;

        public Ingredient()
        {
            Context = new Context();
        }



        public void Add(Business.Ingredient Ingredient)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.Ingredient Ingredient)
        {


        }


        public List<Business.Ingredient> Get()
        {
            return null;

        }


        public Business.Ingredient Get(int Id)
        {
            return null;
        }
    }
}
