using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    class ScenarioPerRole
    {
        public Model.Data.Context Context;

        public ScenarioPerRole()
        {
            Context = new Context();
        }


        public List<Business.ScenarioPerRole> Get()
        {
            return Business.Mapper.ScenarioPerRole.Map(Context.ScenarioPerRole.ToList());
        }


        public Business.ScenarioPerRole Get(int Id)
        {
            return (from c in Context.ScenarioPerRole where c.Id == Id select Business.Mapper.ScenarioPerRole.Map(c)).FirstOrDefault();
        }

    }
}
