using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.DAO
{
    public class ScenarioPerRole
    {
        public int Id { get; set; }

        public int Id_Scenario { get; set; }
        [ForeignKey("Id_Scenario")]
        public virtual Scenario Scenario { get; set; }

        public int Id_Role { get; set; }
        [ForeignKey("Id_Role")]
        public virtual Role Role { get; set; }
    }
}
