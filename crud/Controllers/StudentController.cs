using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
