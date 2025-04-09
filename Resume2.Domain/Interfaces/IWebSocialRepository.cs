using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Domain.Interfaces
{
    public interface IWebSocialRepository
    {
        WebSocial GetById(int id);// find
        bool IsExist(int Id);
        List<WebSocial> GetAll();// select *
        void Add(WebSocial webSocial);// insert
        void Update(WebSocial webSocial);// update
        void Delete(int id);// delete
        void Delete(WebSocial webSocial);
        void Save(); // commit
    }
}
