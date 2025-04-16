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
    public class WebDocDetailsService : IWebDocDetailsService
    {
        private IWebDocDetailsRepository webDocDetailsRepository;

        public WebDocDetailsService(IWebDocDetailsRepository _webDocDetailsRepository)
        {
            webDocDetailsRepository = _webDocDetailsRepository;
        }

        public void AddWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Add(webDocDetails);
        }

        public void DeleteWebDocDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Delete(webDocDetails);
        }

        public List<WebDocDetails> GetWebDocDetails()
        {
           return webDocDetailsRepository.GetAll();
        }

        public WebDocDetails GetWebDocDetailsById(int id)
        {
            return webDocDetailsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webDocDetailsRepository.IsExist(Id);
        }

        public void SaveWebDocDetails()
        {
            webDocDetailsRepository.Save();
        }

        public void UpdateWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Update(webDocDetails);
        }
    }
}
