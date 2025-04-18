using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels;
using Resume2.Domain.ViewModels.WebDoc.Client;
using Resume2.Models;

namespace Resume2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebMainInfoService webMainInfoService;
        private IWebSkillsService webSkillsService;
        private IWebSocialService webSocialService;
        private IWebDocTypeService webDocTypeService;


        public HomeController(IWebDocTypeService _webDocTypeService,IWebSkillsService _webSkillsService, IWebSocialService  _webSocialService, IWebMainInfoService _webMainInfoService,ILogger<HomeController> logger)
        {
            _logger = logger;
            webMainInfoService = _webMainInfoService;
            webSocialService = _webSocialService;
            webSkillsService = _webSkillsService;
            webDocTypeService = _webDocTypeService;
        }

        public IActionResult Index()
        {
            MyInfoOnWebViewModel myinfo=webMainInfoService.GetWebInfoViewModel();
            ViewBag.WebInfo=myinfo;

            List<WebDocViewModel> list = webDocTypeService.GetAllWebDocTypeViewModel();
            ViewBag.WebDoc=list;

            List<WebSocial> MySocial = webSocialService.GetWebSocials();
            ViewBag.Social = MySocial;
            List<WebSkills> MySkills = webSkillsService.GetWebSkills();
            ViewBag.Skills = MySkills;



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
