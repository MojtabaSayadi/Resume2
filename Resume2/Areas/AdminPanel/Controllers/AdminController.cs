using Microsoft.AspNetCore.Mvc;

namespace Resume2.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        [HttpGet("AdminDashboard")]
        public IActionResult IndexAdmin()
        {
            return View();
        }
    
    }
}
