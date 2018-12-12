using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
    class ScenarioStep
    {
        public static Business.ScenarioStep Map(Data.DAO.ScenarioStep ScenarioStep)
        {
            return new Business.ScenarioStep
            {
                Id = ScenarioStep.Id,
                Action = ScenarioStep.Action,
                Duration = ScenarioStep.Duration,
                Order = ScenarioStep.Order,
                ScenarioPerRole = Business.Mapper.ScenarioPerRole.Map(ScenarioStep.ScenarioPerRole)
            };
        }

        public static List<Business.ScenarioStep> Map(List<Data.DAO.ScenarioStep> ScenarioSteps)
        {
            return (from ScenarioStep in ScenarioSteps select Map(ScenarioStep)).ToList();
        }
    }
}
