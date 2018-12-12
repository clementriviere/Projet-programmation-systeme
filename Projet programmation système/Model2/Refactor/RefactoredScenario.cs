using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Refactor
{
    public class RefactoredScenario
    {
        public RefactoredScenario()
        {

        }
            
        public string Name { get; set; }
        public List<RefactoredScenarioStep> Client {get;set;}
        public List<RefactoredScenarioStep> Clerk {get;set;}
        public List<RefactoredScenarioStep> Waiter {get;set;}
        public List<RefactoredScenarioStep> HeadWaiter {get;set;}
        public List<RefactoredScenarioStep> Buttler {get;set;}

    }
}
