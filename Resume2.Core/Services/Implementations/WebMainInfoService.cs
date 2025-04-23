using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels;

namespace Resume2.Core.Services.Implementations
{
    public class WebMainInfoService : IWebMainInfoService
    {
        private IWebMainInfoRepository webRepository;
        public WebMainInfoService(IWebMainInfoRepository _webService)
        {
            webRepository = _webService;
        }
        public void AddWeb(WebMainInfo webMainInfo)
        {
            webRepository.Add(webMainInfo);
            SaveWeb();
        }

        public void DeleteWeb(int id)
        {
            webRepository.Delete(id);
            SaveWeb();
        }

        public void DeleteWebs(WebMainInfo webMainInfo)
        {
            webRepository.Delete(webMainInfo);
            SaveWeb();
        }

        public WebMainInfo GetWebById(int id)
        {
            return webRepository.GetById(id);
        }

        public MyInfoOnWebViewModel GetWebInfoViewModel()
        {
            WebMainInfo webMainInfo = webRepository.GetWebInfo();
            if (webMainInfo != null)
            {
                MyInfoOnWebViewModel result = new MyInfoOnWebViewModel()
                {
                    AboutMe = webMainInfo.AboutMe,
                    FullName = webMainInfo.FullName,
                    ImageName = webMainInfo.Avatar,
                    Major = webMainInfo.Major,
                    ShortDescription = webMainInfo.ShortDescription,
                    Address = webMainInfo.Address,
                    Email = webMainInfo.Email,
                    Phone_no = webMainInfo.Phone_no,
                    ResumeImge = webMainInfo.ResumeImge
                };
                return result;

            }
            else
            {
                return null;
            }
        }

        public List<WebMainInfo> GetWebs()
        {
            return webRepository.GetAll();
        }

        public bool IsExist(int Id)
        {
            return webRepository.IsExist(Id);
        }

        public void SaveWeb()
        {
            webRepository.Save();
        }

        public void UpdateWeb(WebMainInfo webMainInfo)
        {
            webRepository.Update(webMainInfo);
            SaveWeb();
        }
    }
}
