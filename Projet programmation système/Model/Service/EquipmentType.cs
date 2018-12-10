using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class EquipmentType
    {
        public Context Context;

        public EquipmentType()
        {
            Context = new Context();
        }



        public void Add(Business.EquipmentType EquipmentType)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.EquipmentType EquipmentType)
        {


        }


        public List<Business.EquipmentType> Get()
        {
            return null;

        }


        public Business.EquipmentType Get(int Id)
        {
            return null;
        }
    }
}
