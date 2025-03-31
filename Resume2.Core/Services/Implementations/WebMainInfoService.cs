using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Implementations
{
    public class WebMainInfoService : IWebMainInfoService
    {
        private IWebMainInfoService webService ;
        public WebMainInfoService(IWebMainInfoService _webService)
        {
            webService = _webService;
        }
        public void AddWeb(WebMainInfo webMainInfo)
        {
            webService.AddWeb(webMainInfo);
            SaveWeb();
        }

        public void DeleteWeb(int id)
        {
            webService.DeleteWeb(id);
            SaveWeb();
        }

        public void DeleteWebs(WebMainInfo webMainInfo)
        {
            webService.DeleteWebs(webMainInfo);
            SaveWeb();
        }

        public WebMainInfo GetWebById(int id)
        {
            return webService.GetWebById(id);
        }

        public List<WebMainInfo> GetWebs()
        {
            return webService.GetWebs();
        }

        public bool IsExist(int Id)
        {
            return webService.IsExist(Id);
        }

        public void SaveWeb()
        {
            webService.SaveWeb();
        }

        public void UpdateWeb(WebMainInfo webMainInfo)
        {
            webService.UpdateWeb(webMainInfo);
            SaveWeb();
        }
    }
}
