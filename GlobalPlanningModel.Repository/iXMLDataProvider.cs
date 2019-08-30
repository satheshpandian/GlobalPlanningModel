using GlobalPlanningModel.Models;
using System.Collections.Generic;

namespace GlobalPlanningModel.Repository
{
    public interface iXMLDataProvider
    {
        List<Scenario> GetAllScenarios();
    }
}
