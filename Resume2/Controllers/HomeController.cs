using System.Diagnostics;
using System.Text.RegularExpressions;
using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Requests;
using IPE.SmsIrClient.Models.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Resume2.Core.Services.Implementations;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels;
using Resume2.Domain.ViewModels.WebDoc.Client;
using Resume2.Domain.ViewModels.WebDoc.ContactUs.Client;
using Resume2.Domain.ViewModels.WebDoc.Security;
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
        private IWebDocDetailsService webDocDetailsService;
        private IWebServicesService webServicesService;
        private IWebProjectsService webProjectsService;
        private IWebBlogsService webBlogsService;
        private IWebContactUsService webContactUsService;
        public IRecaptchaService  recaptchaService { get; set; }
        public IConfiguration configuration;

        public HomeController(IWebDocDetailsService _webDocDetailsService, IWebDocTypeService _webDocTypeService,
            IWebServicesService _webServicesService,
            IWebSkillsService _webSkillsService, IWebSocialService _webSocialService, IWebProjectsService _webProjectsService,
        IWebMainInfoService _webMainInfoService,
        IWebBlogsService _webBlogsService,
        ILogger<HomeController> logger,
        IWebContactUsService _webContactUsService,
        IRecaptchaService _recaptchaService,
        IConfiguration _configuration)
            
          

        {
            _logger = logger;
            webMainInfoService = _webMainInfoService;
            webSocialService = _webSocialService;
            webSkillsService = _webSkillsService;
            webDocTypeService = _webDocTypeService;
            webDocDetailsService = _webDocDetailsService;
            webServicesService = _webServicesService;
            webProjectsService = _webProjectsService;
            webBlogsService = _webBlogsService;
            webContactUsService = _webContactUsService;
            recaptchaService = _recaptchaService;
            configuration = _configuration;

        }

        [HttpGet]
        public IActionResult Index(string? message,string? errmessage)
        {
            if (!string.IsNullOrEmpty(message))
                ViewBag.Message = message;

            if (!string.IsNullOrEmpty(errmessage))
                ViewBag.errmessage = errmessage;

            MyInfoOnWebViewModel myinfo = webMainInfoService.GetWebInfoViewModel();
            ViewBag.WebInfo = myinfo;

            List<WebDocViewModel> list = webDocTypeService.GetAllWebDocTypeViewModel();
            ViewBag.WebDoc = list;



            List<WebSocial> MySocial = webSocialService.GetWebSocials();
            ViewBag.Social = MySocial;

            List<WebServices> MyServices = webServicesService.GetWebServices();
            ViewBag.Services = MyServices;


            List<WebBlogs> webBlogs = webBlogsService.GetWebBlogs();
            ViewBag.Blogs = webBlogs;

            List<WebSkills> MySkills = webSkillsService.GetWebSkills();
            ViewBag.Skills = MySkills;

            List<WebDocDetailsViewModel> docDetailsViewModels = webDocDetailsService.GetAllWebDocDetailsViewModel();
            ViewBag.DocD = docDetailsViewModels;
            #region calculate of experience
            int startYear = 1996;
            int currentYear = DateTime.Now.Year;

            int yearsOfExperience = currentYear - startYear;
            ViewBag.exp_year = yearsOfExperience;
            #endregion
            List<WebProjects> MyProject = webProjectsService.GetWebProjects();
            ViewBag.MyProjects = MyProject;



            #region GoogleRecapcha
            GoogleRecapchaForViewViewModel tmp = new GoogleRecapchaForViewViewModel()
            {
                SiteKey = GoogleRecapchaViewModel.SiteKey
            };

            ViewData["SiteKey"] = tmp;
            #endregion


            return View(new WebContactUsViewModel());
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(WebContactUsViewModel model)
        {
            #region InitViewBags
            MyInfoOnWebViewModel myinfo = webMainInfoService.GetWebInfoViewModel();
            ViewBag.WebInfo = myinfo;

            List<WebDocViewModel> list = webDocTypeService.GetAllWebDocTypeViewModel();
            ViewBag.WebDoc = list;



            List<WebSocial> MySocial = webSocialService.GetWebSocials();
            ViewBag.Social = MySocial;

            List<WebServices> MyServices = webServicesService.GetWebServices();
            ViewBag.Services = MyServices;


            List<WebBlogs> webBlogs = webBlogsService.GetWebBlogs();
            ViewBag.Blogs = webBlogs;

            List<WebSkills> MySkills = webSkillsService.GetWebSkills();
            ViewBag.Skills = MySkills;

            List<WebDocDetailsViewModel> docDetailsViewModels = webDocDetailsService.GetAllWebDocDetailsViewModel();
            ViewBag.DocD = docDetailsViewModels;
            #region calculate of experience
            int startYear = 1996;
            int currentYear = DateTime.Now.Year;

            int yearsOfExperience = currentYear - startYear;
            ViewBag.exp_year = yearsOfExperience;
            #endregion
            List<WebProjects> MyProject = webProjectsService.GetWebProjects();
            ViewBag.MyProjects = MyProject;
            #endregion

            #region GoogleRecapcha
            GoogleRecapchaForViewViewModel tmp = new GoogleRecapchaForViewViewModel()
            {
                SiteKey = GoogleRecapchaViewModel.SiteKey
            };

            ViewData["SiteKey"] = tmp;
            #endregion



            if (ModelState.IsValid)
            {
                if (!recaptchaService.ReCaptchaPassed(model.Token, GoogleRecapchaViewModel.SecretKey))
                {
                    string err = "لطفا مجددا صفحه را بارگزاری کنید.";
                    return RedirectToAction("Index", "Home", new { errmessage = err });
                }

                bool isPhoneNumber = true;
                foreach (var item in model.PhoneNumber)
                {
                    isPhoneNumber = int.TryParse(item.ToString(), out int result);
                    if (isPhoneNumber == false)
                        break;
                }


                if (isPhoneNumber)
                {

                    #region sms
                    try
                    {
                        string smsAPiKey = configuration.GetValue<string>("SmsApi");
                        SmsIr smsIr = new SmsIr(smsAPiKey);
                        string mobile = model.PhoneNumber;
                        int templateId = 328329;
                        VerifySendParameter[] verifySendParameters = {
                            new VerifySendParameter("NAME", model.Fullname),
                         };
                        var response = await smsIr.VerifySendAsync(mobile, templateId, verifySendParameters);

                        VerifySendResult sendResult = response.Data;
                        int messageId = sendResult.MessageId;
                        decimal cost = sendResult.Cost;


                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    #endregion



                    WebContactUs webContactUs = new WebContactUs()
                    {
                        CreatedDate = DateTime.Now,
                        Fullname = model.Fullname,
                        Message = model.Message,
                        PhoneNumber = model.PhoneNumber,
                    };
                    webContactUsService.AddWebContactUs(webContactUs);
                    //return View(new WebContactUsViewModel());
                    return RedirectToAction("Index", "Home",new {message="پیام شما با موفقیت دریافت شد"});
                }

                else
                {
                    ModelState.AddModelError("PhoneNumber", "فرمت وارد شده صحیح نمی باشد.");

                }
            }
            else
            {
                ModelState.AddModelError("Message", "خطا در مقادیر ورودی. لطفا عبارات را بدرستی وارد کنید.");
            }

            return View(model);
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
