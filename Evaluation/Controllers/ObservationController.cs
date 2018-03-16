using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.Controllers
{
    [Authorize]
    public class ObservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListSelfEvaluation()
        {
            return View();
        }
    }
}
