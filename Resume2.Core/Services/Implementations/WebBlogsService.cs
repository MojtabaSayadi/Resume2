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
    public class WebBlogsService : IWebBlogsService

    {
        
        private IWebBlogsService webBlogsRepository;

    
        public WebBlogsService(IWebBlogsService _webBlogsRepository)
        {
            webBlogsRepository = _webBlogsRepository;
        }

        public void AddWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.AddWebBlogs(webBlogs);
            SaveWebBlogs();
        }

        public void DeleteWebBlogs(int id)
        {
            webBlogsRepository.DeleteWebBlogs(GetWebBlogsById(id));
            SaveWebBlogs();
        }

        public void DeleteWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.DeleteWebBlogs(webBlogs);
            SaveWebBlogs();
        }

        public List<WebBlogs> GetWebBlogs()
        {
            return webBlogsRepository.GetWebBlogs();
        }

        public WebBlogs GetWebBlogsById(int id)
        {
            return webBlogsRepository.GetWebBlogsById(id);
        }

        public bool IsExist(int Id)
        {
            return webBlogsRepository.IsExist(Id);
        }

        public void SaveWebBlogs()
        {
            webBlogsRepository.SaveWebBlogs();
        }

        public void UpdateWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.UpdateWebBlogs(webBlogs);
            SaveWebBlogs();
        }
    }
}
