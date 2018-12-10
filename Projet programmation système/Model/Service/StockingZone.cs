using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class StockingZone
    {
        public Model.Data.Context Context;

        public StockingZone()
        {
            Context = new Context();
        }



        public void Add(Business.StockingZone StockingZone)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.StockingZone StockingZone)
        {


        }


        public List<Business.StockingZone> Get()
        {
            return null;

        }


        public Business.StockingZone Get(int Id)
        {
            return null;
        }
    }
}
