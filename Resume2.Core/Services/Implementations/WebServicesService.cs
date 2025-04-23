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
    public class WebServicesService : IWebServicesService
    {
        private IWebServicesRepository webServicesRepository;
        public WebServicesService(IWebServicesRepository _webServicesRepository)
        {
            webServicesRepository = _webServicesRepository;
        }
        public void AddWebServices(WebServices webServices)
        {
            webServicesRepository.Add(webServices);
            SaveWebServices();
        }

        public void DeleteWebServices(int id)
        {
            webServicesRepository.Delete(GetWebServicesById(id));
            SaveWebServices();
        }

        public void DeleteWebServices(WebServices webServices)
        {
            webServicesRepository.Delete(webServices);
            SaveWebServices();
        }

        public List<WebServices> GetWebServices()
        {
            return webServicesRepository.GetAll();
        }

        public WebServices GetWebServicesById(int id)
        {
            return webServicesRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
           return webServicesRepository.IsExist(Id);
        }

        public void SaveWebServices()
        {
            webServicesRepository.Save();
        }

        public void UpdateWebServices(WebServices webServices)
        {
            webServicesRepository.Update(webServices);
            SaveWebServices();
        }
    }
}
