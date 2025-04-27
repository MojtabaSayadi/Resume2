using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Domain.Interfaces
{
    public interface IWebBlogsRepository
    {
        WebBlogs GetById(int id);// find
        bool IsExist(int Id);
        List<WebBlogs> GetAll();// select *
        void Add(WebBlogs webBlogs);// insert
        void Update(WebBlogs webBlogs);// update
        void Delete(int id);// delete
        void Delete(WebBlogs webBlogs);
        void Save(); // commit

    }
}
