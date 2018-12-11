using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class StepIngredient
    {
        public Model.Data.Context Context;

        public StepIngredient()
        {
            Context = new Context();
        }



        public void Add(Business.StepIngredient StepIngredient)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.StepIngredient StepIngredient)
        {


        }


        public List<Business.StepIngredient> Get()
        {
            return null;

        }


        public Business.StepIngredient Get(int Id)
        {
            return null;
        }
    }
}
