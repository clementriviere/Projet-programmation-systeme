using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.DAO
{
    public class ScenarioStep
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public int Duration { get; set; }
        public int Order { get; set; }

        public int Id_ScenarioPerRole { get; set; }
        [ForeignKey("Id_ScenarioPerRole")]
        public virtual ScenarioPerRole ScenarioPerRole { get; set; }
    }
}
