using Microsoft.AspNetCore.Mvc;
using Resume2.Core.Services.Implementations;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Controllers
{
    public class WebController : Controller
    {



        private IWebMainInfoService webService;
        public WebController(IWebMainInfoService _webService)
        {
            webService = _webService;
        }

       [HttpGet("ShowWeb")]
        public IActionResult ShowWeb()
        {
            List<WebMainInfo> webMainInfo = webService.GetWebs();
            return View(webMainInfo);
        }
        #region CreateWeb
        [HttpGet("CreateWeb")]
        public ActionResult CreateWeb()
        {
            return View(new WebMainInfo());
        }
        [HttpPost("CreateWeb")]
        public ActionResult CreateWeb(WebMainInfo webMainInfo)
        {
            if (ModelState.IsValid)
            {
                webService.AddWeb(webMainInfo);
                
                return RedirectToAction("ShowWeb");
            }
            else
            {
                return View(webMainInfo);
            }

        }
        #endregion

        #region EditWeb
        [HttpGet("EditWeb/{Id}")]
        public IActionResult EditWeb(int Id)
        {
            if (Id > 0)
            {
                if (webService.IsExist(Id))
                {
                    WebMainInfo webMainInfo = webService.GetWebById(Id);
                    return View(webMainInfo);
                }
                else
                {
                    // Id not found !
                    return RedirectToAction("ShowWeb");
                }
            }
            else
            {
                // Id not found !
                return RedirectToAction("ShowWeb");

            }

        }

        [Route("EditWeb")]
        [Route("EditWeb/{id}")]
        [HttpPost]
        public IActionResult EditWeb(WebMainInfo model)
        {
            WebMainInfo webMainInfo = webService.GetWebById(model.Id);  
            if (webMainInfo == null)
            {
                return RedirectToAction("ShowWeb");
            }
            else
            {
                bool isChanged = false;
                if (!webMainInfo.FullName.Equals(model.FullName))
                    webMainInfo.FullName = model.FullName;
                isChanged = true;
                //if (!webMainInfo.Explain1.Equals(model.Explain1))
                //    webMainInfo.Explain1 = model.Explain1;
                //isChanged = true;
                //if (!webMainInfo.Explain2.Equals(model.Explain2))
                //    webMainInfo.Explain2 = model.Explain2;
                //isChanged = true;



                if (isChanged)
                {
                    webService.UpdateWeb(webMainInfo);
                    //userService.UpdateUser(user);
                    return RedirectToAction("ShowWeb", "Web", new { SuccessMessage = "Web added successFully " });
                }
                else
                {

                    return RedirectToAction("ShowWeb", "Web", new { ErrorMessage = "Web not added " });
                }



            }
        }
        #endregion


    }
}
