using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebBlogsService
    {
        WebBlogs GetWebBlogsById(int id);
        List<WebBlogs> GetWebBlogs();
        bool IsExist(int Id);
        void AddWebBlogs(WebBlogs webBlogs);
        void UpdateWebBlogs(WebBlogs webBlogs);
        void DeleteWebBlogs(int id);
        void DeleteWebBlogs(WebBlogs webBlogs);
        void SaveWebBlogs();

    }
}
