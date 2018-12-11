using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
    public static class Scenario
    {
        public static Business.Scenario Map(Data.DAO.Scenario scenario)
        {
            return new Business.Scenario
            {
                Id = scenario.Id,
                ScenarioName = scenario.ScenarioName,
            };
        }
    }
}
