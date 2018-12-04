using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Data;

namespace Model.Service
{
    class CommonEquipment
    {
        public Model.Data.Context Context;

        public CommonEquipment()
        {
            Context = new Context();
        }



        public void Add(Business.CommonEquipment CommonEquipment)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.CommonEquipment CommonEquipment)
        {


        }


        public List<Business.CommonEquipment> Get()
        {
            return null;

        }


        public Business.CommonEquipment Get(int Id)
        {
            return null;
        }
    }
}
