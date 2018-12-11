using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business
{
    public class ScenarioPerRole
    {
        public int Id { get; set; }

        public Scenario Scenario { get; set; }

        public Role Role { get; set; }
    }
}
