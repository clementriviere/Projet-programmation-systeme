using Microsoft.EntityFrameworkCore;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class ScenarioPerRole
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
            return (from c in Context.ScenarioPerRole.Include(i => i.Scenario).Include(i => i.Role) where c.Id == Id select Business.Mapper.ScenarioPerRole.Map(c)).FirstOrDefault();
        }

        public List<Business.ScenarioPerRole> GetByScenarioId(int id)
        {
            return (from c in Context.ScenarioPerRole.Include(i => i.Scenario).Include(i => i.Role) where c.Scenario.Id == id select Business.Mapper.ScenarioPerRole.Map(c)).ToList();
        }

    }
}
