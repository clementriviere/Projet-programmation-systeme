using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Refactor
{
    public static class ScenarioRefactor
    {
        public static RefactoredScenario RefactorScenario(Model.Business.Scenario scenario)
        {
            RefactoredScenario refactoredScenario = new RefactoredScenario();
            refactoredScenario.Name = scenario.ScenarioName;

            Model.Service.ScenarioPerRole serviceScenarioPerRole = new Model.Service.ScenarioPerRole();
            var ScenariiPerRole = serviceScenarioPerRole.GetByScenarioId(scenario.Id);

            Model.Service.ScenarioStep serviceScenarioStep = new Model.Service.ScenarioStep();

            foreach(Model.Business.ScenarioPerRole scenarioPerRole in ScenariiPerRole)
            {
                switch (scenarioPerRole.Role.RoleName)
                {
                    case "Client":
                        refactoredScenario.Client = ScenarioStepRefactor.RefactorScenarioStep(serviceScenarioStep.GetStepsByScenarioPerRoleId(scenarioPerRole.Id));
                            break;
                    case "Clerk":
                        var test = serviceScenarioStep.GetStepsByScenarioPerRoleId(scenarioPerRole.Id);
                        refactoredScenario.Clerk = ScenarioStepRefactor.RefactorScenarioStep(test);
                        break;
                    case "Waiter":
                        refactoredScenario.Waiter = ScenarioStepRefactor.RefactorScenarioStep(serviceScenarioStep.GetStepsByScenarioPerRoleId(scenarioPerRole.Id));
                        break;
                    case "Buttler":
                        refactoredScenario.Buttler = ScenarioStepRefactor.RefactorScenarioStep(serviceScenarioStep.GetStepsByScenarioPerRoleId(scenarioPerRole.Id));
                        break;
                    case "HeadWaiter":
                        refactoredScenario.HeadWaiter = ScenarioStepRefactor.RefactorScenarioStep(serviceScenarioStep.GetStepsByScenarioPerRoleId(scenarioPerRole.Id));
                        break;
                    default:
                        break;

                }
            }



            return refactoredScenario;
        }
    }
}
