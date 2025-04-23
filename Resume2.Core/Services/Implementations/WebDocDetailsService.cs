using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Core.Services.Interfaces;
using Resume2.Data.Repositories;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels.WebDoc.Client;

namespace Resume2.Core.Services.Implementations
{
    public class WebDocDetailsService : IWebDocDetailsService
    {
        private IWebDocDetailsRepository webDocDetailsRepository;
        private IWebDocTypeService webDocTypeService;

        public WebDocDetailsService(IWebDocTypeService _webDocTypeService,IWebDocDetailsRepository _webDocDetailsRepository)
        {
            webDocDetailsRepository = _webDocDetailsRepository;
            webDocTypeService = _webDocTypeService;
        }

        public void AddWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Add(webDocDetails);
            SaveWebDocDetails();
        }

        public void DeleteWebDocDetails(int id)
        {
            webDocDetailsRepository.Delete(GetWebDocDetailsById(id));
            SaveWebDocDetails();
        }

        public void DeleteWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Delete(webDocDetails);
            SaveWebDocDetails();
        }

        public List<WebDocDetailsViewModel> GetAllWebDocDetailsViewModel()
        {
            List<WebDocDetails> webDocDetails = webDocDetailsRepository.GetAll();//kham

            List<WebDocDetailsViewModel> result = new List<WebDocDetailsViewModel>();
            WebDocDetailsViewModel tmp = new WebDocDetailsViewModel();

           foreach (var item in webDocDetails)
            {
                tmp = new WebDocDetailsViewModel()
                {
                    Title = item.Title,
                    ImageName =item.Image,
                    Title_En= webDocTypeService.GetWebDocTypeById(item.TypeId).Title_En
                };

                result.Add(tmp);
            }

            return result;


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
            SaveWebDocDetails();
        }
    }
}
