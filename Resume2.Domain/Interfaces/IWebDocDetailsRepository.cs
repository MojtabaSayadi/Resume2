using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Domain.Interfaces
{
    public interface IWebDocDetailsRepository
    {
        WebDocDetails GetById(int id);// find
        bool IsExist(int Id);
        List<WebDocDetails> GetAll();// select *
        void Add(WebDocDetails webDocDetails);// insert
        void Update(WebDocDetails webDocDetails);// update
        void Delete(int id);// delete
        void Delete(WebDocDetails webDocDetails);
        void Save(); // commit

    }
}
