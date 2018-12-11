using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Business
{
    public class ScenarioStep
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public int Duration { get; set; }
        public ScenarioPerRole ScenarioPerRole { get; set; }
    }
}
