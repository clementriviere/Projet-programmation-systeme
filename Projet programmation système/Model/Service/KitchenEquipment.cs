using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class KitchenEquipment
    {
        public Model.Data.Context Context;

        public KitchenEquipment()
        {
            Context = new Context();
        }



        public void Add(Business.KitchenEquipment KitchenEquipment)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.KitchenEquipment KitchenEquipment)
        {


        }


        public List<Business.KitchenEquipment> Get()
        {
            return null;

        }


        public Business.KitchenEquipment Get(int Id)
        {
            return null;
        }
    }
}
