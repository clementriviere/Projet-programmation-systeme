using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    class ScenarioStep
    {
        public Model.Data.Context Context;

        public ScenarioStep()
        {
            Context = new Context();
        }


        public List<Business.ScenarioStep> Get()
        {
            return Business.Mapper.ScenarioStep.Map(Context.ScenarioStep.ToList());
        }


        public Business.ScenarioStep Get(int Id)
        {
            return (from c in Context.ScenarioStep where c.Id == Id select Business.Mapper.ScenarioStep.Map(c)).FirstOrDefault();
        }
    }
}
