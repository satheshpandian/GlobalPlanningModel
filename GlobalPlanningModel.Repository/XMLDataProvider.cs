using GlobalPlanningModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace GlobalPlanningModel.Repository
{
    public class XMLDataProvider : iXMLDataProvider
    {
       
        public string FilePath { get; set; }
        public XElement Scenarios { get; set; }

        public XMLDataProvider()
        {
            FilePath = ConfigurationManager.AppSettings["DataFile"];
            Scenarios = XElement.Load($"{FilePath}");
        }

        public List<Scenario> GetAllScenarios()
        {
            try
            {
                return Scenarios.Descendants("Scenario").Select(x => new Scenario()
                {
                    ScenarioID = x.Element("ScenarioID") != null ? int.Parse(x.Element("ScenarioID").Value) : 0,
                    NumMonths = x.Element("NumMonths") != null ? int.Parse(x.Element("NumMonths").Value) : 0,
                    MarketID = x.Element("MarketID") != null ? int.Parse(x.Element("MarketID").Value) : 0,
                    NetworkLayerID = x.Element("NetworkLayerID") != null ? int.Parse(x.Element("NetworkLayerID").Value) : 0,
                    SampleDate = x.Element("SampleDate") != null ? DateTime.Parse(x.Element("SampleDate").Value) : DateTime.MinValue,
                    CreationDate = x.Element("CreationDate") != null ? DateTime.Parse(x.Element("CreationDate").Value) : DateTime.MinValue,
                    UserID = x.Element("UserID") != null ? x.Element("UserID").Value : "",
                    Surname = x.Element("Surname") != null ? x.Element("Surname").Value : "",
                    Forename = x.Element("Forename") != null ? x.Element("Forename").Value : "",
                    Name = x.Element("Name") != null ? x.Element("Name").Value : ""
                }).ToList();
            }
            catch(Exception ex)
            {
               return new List<Scenario>();
            }
           
        }
    }
    
}
