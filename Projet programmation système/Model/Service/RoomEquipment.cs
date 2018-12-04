using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

using Model.Data;

namespace Model.Service
{
    class RoomEquipment
    {
        public Model.Data.Context Context;

        public RoomEquipment()
        {
            Context = new Context();
        }



        public void Add(Business.RoomEquipment RoomEquipment)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.RoomEquipment RoomEquipment)
        {


        }


        public List<Business.RoomEquipment> Get()
        {
            return null;

        }


        public Business.RoomEquipment Get(int Id)
        {
            return null;
        }
    }
}