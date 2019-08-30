using System.Collections.Generic;
using GlobalPlanningModel.Models;

namespace GlobalPlanningModel.Repository
{
    public class ScenarioRepository: iScenarioRepository
    {
        iXMLDataProvider _xmlDataProvider;
        public ScenarioRepository(iXMLDataProvider xmlDataProvider)
        {
            _xmlDataProvider = xmlDataProvider;
        }

        public List<Scenario> GetAllScenarios()
        {
            return _xmlDataProvider.GetAllScenarios();
        }
    }
}
