using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;

namespace Model.Service
{
    class StockType
    {
        public Model.Data.Context Context;

        public StockType()
        {
            Context = new Context();
        }



        public void Add(Business.StockType StockType)
        {

        }


        public void Delete(int id)
        {

        }


        public void Update(Business.StockType StockType)
        {


        }


        public List<Business.StockType> Get()
        {
            return null;

        }


        public Business.StockType Get(int Id)
        {
            return null;
        }
    }
}
