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

        public static List<Business.Scenario> Map(List<Data.DAO.Scenario> scenarios)
        {
            return (from scenario in scenarios select Map(scenario)).ToList();
        }
    }
}
