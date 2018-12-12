using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Refactor
{
    public static class ScenarioStepRefactor
    {
        public static List<RefactoredScenarioStep> RefactorScenarioStep(List<Model.Business.ScenarioStep> scenarioSteps)
        {
            List<RefactoredScenarioStep> stepList = new List<RefactoredScenarioStep>();

            foreach (Model.Business.ScenarioStep scenarioStep in scenarioSteps)
            {
                stepList.Add(new RefactoredScenarioStep { action = scenarioStep.Action, duration = scenarioStep.Duration });
            }

            return stepList;
        }
    }
}
