using GlobalPlanningModel.Repository;
using System.Web.Mvc;

namespace GlobalPlanningModel.Controllers
{
    public class ScenariosController : Controller
    {
        ScenarioRepository _scenariosRepository;
        public ScenariosController( ScenarioRepository scenariosRepository)
        {
            _scenariosRepository = scenariosRepository;
        }
        // GET: Scenarios
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllScenarios()
        {
            var data = _scenariosRepository.GetAllScenarios();
            return new JsonResult() { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
