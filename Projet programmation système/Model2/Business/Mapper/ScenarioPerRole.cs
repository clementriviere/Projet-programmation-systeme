using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business.Mapper
{
    class ScenarioPerRole
    {
        public static Business.ScenarioPerRole Map(Data.DAO.ScenarioPerRole Spr)
        {
            return new Business.ScenarioPerRole
            {
                Id = Spr.Id,
                Role = Business.Mapper.Role.Map(Spr.Role),
                Scenario = Business.Mapper.Scenario.Map(Spr.Scenario)
            };
        }

        public static List<Business.ScenarioPerRole> Map(List<Data.DAO.ScenarioPerRole> Sprs)
        {
            return (from Spr in Sprs select Map(Spr)).ToList();
        }
    }
}
