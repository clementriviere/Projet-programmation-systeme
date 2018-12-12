using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Refactor;

namespace Model.Refactor
{
    public static class ScenarioDisplayer
    {
        public static void displayScenarii()
        {
            Model.Service.Scenario serviceScenario = new Model.Service.Scenario();
            var scenarios = serviceScenario.Get(1);
            var scenario = ScenarioRefactor.RefactorScenario(scenarios);

            Console.WriteLine(scenario.Name);
            Console.WriteLine("\nClient :");
            displayForeach(scenario.Client);
            Console.WriteLine("\nButtler :");
            displayForeach(scenario.Buttler);
            Console.WriteLine("\nHeadWaiter :");
            displayForeach(scenario.HeadWaiter);
            Console.WriteLine("\nWaiter :");
            displayForeach(scenario.Waiter);
            Console.WriteLine("\nClerk :");
            displayForeach(scenario.Clerk);
            Console.Read();
        }

        public static void displayForeach(List<RefactoredScenarioStep> steps)
        {
            foreach (RefactoredScenarioStep step in steps)
            {
                Console.WriteLine("  ->{0} ({1})", step.action, step.duration);
            }
        }
    }
}
