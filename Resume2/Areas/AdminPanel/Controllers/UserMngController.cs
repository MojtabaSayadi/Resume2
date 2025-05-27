using Microsoft.AspNetCore.Mvc;

namespace Resume2.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserMngController : Controller
    {
        [HttpGet("UserMngDashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
