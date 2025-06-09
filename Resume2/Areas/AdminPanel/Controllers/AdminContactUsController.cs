using Microsoft.AspNetCore.Mvc;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.ViewModels.WebDoc.ContactUs.Admin;

namespace Resume2.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminContactUsController(
        IWebContactUsService webContactUsService
        ) : Controller

    {
        [HttpGet("AdminContactUs")]

        public async Task<IActionResult> ShowAdminContactUs(FilterAdminContactUsViewModel filter)
        {
            //List<AdminContactUsViewModel> List = webContactUsService.GetAdminContactUs();
            FilterAdminContactUsViewModel model =await webContactUsService.GetAllMessage(filter);
            return View(model);
        }
    }
}
