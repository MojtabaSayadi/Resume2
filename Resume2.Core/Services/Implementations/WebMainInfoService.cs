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
        private IWebMainInfoRepository webService ;
        public WebMainInfoService(IWebMainInfoRepository _webService)
        {
            webService = _webService;
        }
        public void AddWeb(WebMainInfo webMainInfo)
        {
            webService.Add(webMainInfo);
            SaveWeb();
        }

        public void DeleteWeb(int id)
        {
            webService.Delete(id);
            SaveWeb();
        }

        public void DeleteWebs(WebMainInfo webMainInfo)
        {
            webService.Delete(webMainInfo);
            SaveWeb();
        }

        public WebMainInfo GetWebById(int id)
        {
            return webService.GetById(id);
        }

        public List<WebMainInfo> GetWebs()
        {
            return webService.GetAll();
        }

        public bool IsExist(int Id)
        {
            return webService.IsExist(Id);
        }

        public void SaveWeb()
        {
            webService.Save();
        }

        public void UpdateWeb(WebMainInfo webMainInfo)
        {
            webService.Update(webMainInfo);
            SaveWeb();
        }
    }
}
