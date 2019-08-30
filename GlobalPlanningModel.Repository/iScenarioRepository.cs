using GlobalPlanningModel.Models;
using System.Collections.Generic;

namespace GlobalPlanningModel.Repository
{
    public interface iScenarioRepository
    {
        List<Scenario> GetAllScenarios();
    }
}
