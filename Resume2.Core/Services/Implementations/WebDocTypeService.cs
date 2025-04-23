using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels.WebDoc.Client;

namespace Resume2.Core.Services.Implementations
{
    public class WebDocTypeService : IWebDocTypeService
    {
        private IWebDocTypeRepository webDocTypeRepository;

        public WebDocTypeService(IWebDocTypeRepository _webDocTypeRepository)
        {
            webDocTypeRepository=_webDocTypeRepository;
        }
        public void AddWebDocType(WebDocType webDocType)
        {
            webDocTypeRepository.Add(webDocType);
            SaveWebDocType();
        }

        public void DeleteWebDocType(int id)
        {
            webDocTypeRepository.Delete(GetWebDocTypeById(id));
            SaveWebDocType();
        }

        public void DeleteWebDocType(WebDocType webDocType)
        {
            webDocTypeRepository.Delete(webDocType);
            SaveWebDocType();
        }

        public List<WebDocViewModel> GetAllWebDocTypeViewModel()
        {
            List<WebDocType> webDocTypes = webDocTypeRepository.GetAll();//kham

            List<WebDocViewModel> result= new List<WebDocViewModel>();
            WebDocViewModel tmp=new WebDocViewModel()
            {
                Title="همه",
                Title_En="All"
            };

            result.Add(tmp);


            foreach (var item in webDocTypes)
            {
                tmp = new WebDocViewModel()
                {
                    Title = item.Title,
                    Title_En=item.Title_En
                };

                result.Add(tmp);
            }

            return result;
        }

        public List<WebDocType> GetWebDocType()
        {
            return webDocTypeRepository.GetAll();
        }

        public WebDocType GetWebDocTypeById(int id)
        {
            return webDocTypeRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webDocTypeRepository.IsExist(Id);
        }

        public void SaveWebDocType()
        {
            webDocTypeRepository.Save();
        }

        public void UpdateWebDocType(WebDocType webDocType)
        {
            webDocTypeRepository.Update(webDocType);
            SaveWebDocType();
        }
    }
}
