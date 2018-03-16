using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Evaluation.Models;
using Microsoft.AspNetCore.Authorization;

namespace Evaluation.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
