using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebMainInfoService
    {
        WebMainInfo GetWebById(int id);

        MyInfoOnWebViewModel GetWebInfoViewModel();

        List<WebMainInfo> GetWebs();
        bool IsExist(int Id);
        void AddWeb(WebMainInfo webMainInfo);
        void UpdateWeb(WebMainInfo webMainInfo);
        void DeleteWeb(int id);
        void DeleteWebs(WebMainInfo webMainInfo);
        void SaveWeb();
    }
}
