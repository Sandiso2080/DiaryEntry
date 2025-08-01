using Microsoft.AspNetCore.Mvc;

namespace DiaryEntry.Controllers
{
    public class DiaryModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
