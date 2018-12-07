using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Data;
using System.Threading.Tasks;


namespace Model.Service
{
    class Equipment
    {
        public Model.Data.Context Context;

        public Equipment()
        {
            Context = new Context();
        }



        public void Add(Business.Equipment Equipment)
        {
            
        }


        public void Delete(int id)
        {
           
        }


        public void Update(Business.Equipment Equipment)
        {

            
        }


        public List<Business.Equipment> Get()
        {
            return null;

        }


        public Business.Equipment Get(int Id)
        {
            return null;
        }
    }
}
