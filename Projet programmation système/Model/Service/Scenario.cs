using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    class Scenario
    {
        public Model.Data.Context Context;

        public Scenario()
        {
            Context = new Context();
        }


        public List<Business.Scenario> Get()
        {
            return Business.Mapper.Scenario.Map(Context.Scenario.ToList());
        }


        public Business.Scenario Get(int Id)
        {
            return (from c in Context.Scenario where c.Id == Id select Business.Mapper.Scenario.Map(c)).FirstOrDefault();
        }
    }
}
