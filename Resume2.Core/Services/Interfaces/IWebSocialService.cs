using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebSocialService
    {
        WebSocial GetWebSocialById(int id);
        List<WebSocial> GetWebSocials();
        bool IsExist(int Id);
        void AddWebsocial(WebSocial webSocial);
        void UpdateWebSocial(WebSocial webSocial);
        void DeleteWebSocial(int id);
        void DeleteWebSocial(WebSocial webSocial);
        void SaveWebSocial();
    }
}
