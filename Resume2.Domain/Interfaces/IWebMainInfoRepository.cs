using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Domain.Interfaces
{
    public interface IWebMainInfoRepository
    {
        WebMainInfo GetById(int id);// find
        WebMainInfo GetWebInfo();
        bool IsExist(int Id);
        List<WebMainInfo> GetAll();// select *
        void Add(WebMainInfo webMainInfo);// insert
        void Update(WebMainInfo webMainInfo);// update
        void Delete(int id);// delete
        void Delete(WebMainInfo webMainInfo);
        void Save(); // commit
    }
}
