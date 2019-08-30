using GlobalPlanningModel.Models;
using GlobalPlanningModel.Repository;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace GlobalPlanningModel.Tests
{

    public class RepositoryTest
    {
        Mock<iXMLDataProvider> _xmlDataProvider = new Mock<iXMLDataProvider>();
       
        [Test]
        public void TestGetAllScenarios()
        {
            #region Test Setup
            _xmlDataProvider.Setup(x => x.GetAllScenarios()).Returns(new List<Scenario>()
            {
                new Scenario(){Name="sathesh",Surname="Mani",ScenarioID=1},
                new Scenario(){Name="sathesh",Surname="Mani",ScenarioID=2},
                new Scenario(){Name="someone",Surname="Mani",ScenarioID=2}
            });
            #endregion

            ScenarioRepository scenarioRepository = new ScenarioRepository(_xmlDataProvider.Object);
            var scenarios = scenarioRepository.GetAllScenarios();
            Assert.NotNull(scenarios);
            Assert.NotNull(scenarios.Count == 3);
            var userSathesh = scenarios.Where(x => x.Name == "sathesh").ToList();
            Assert.NotNull(userSathesh.Count == 2);

        }
}
}
