using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.Controllers
{
    [Authorize]
    public class AnnotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
