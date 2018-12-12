using Microsoft.EntityFrameworkCore;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class ScenarioStep
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
            return (from c in Context.ScenarioStep.Include(i => i.ScenarioPerRole) where c.Id == Id select Business.Mapper.ScenarioStep.Map(c)).FirstOrDefault();
        }

        public List<Business.ScenarioStep> GetStepsByScenarioPerRoleId(int id)
        {
            return (from c in Context.ScenarioStep.Include(i => i.ScenarioPerRole).Include(i => i.ScenarioPerRole.Role).Include(i => i.ScenarioPerRole.Scenario) where c.Id_ScenarioPerRole == id select Business.Mapper.ScenarioStep.Map(c)).ToList();
        }
    }
}
