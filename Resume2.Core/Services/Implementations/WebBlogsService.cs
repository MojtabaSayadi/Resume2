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
        
        private IWebBlogsRepository webBlogsRepository;

    
        public WebBlogsService(IWebBlogsRepository _webBlogsRepository)
        {
            webBlogsRepository = _webBlogsRepository;
        }

        public void AddWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.Add(webBlogs);
                SaveWebBlogs();
        }

        
       
        public void DeleteWebBlogs(int id)
        {
            webBlogsRepository.Delete( GetWebBlogsById(id));
            SaveWebBlogs();
        }

        public void DeleteWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.Delete(webBlogs);
        }

        public List<WebBlogs> GetWebBlogs()
        {
            return webBlogsRepository.GetAll();
        }

        public WebBlogs GetWebBlogsById(int id)
        {
            return webBlogsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webBlogsRepository.IsExist(Id);
        }

        public void SaveWebBlogs()
        {
            webBlogsRepository.Save();
        }

        public void UpdateWebBlogs(WebBlogs webBlogs)
        {
            webBlogsRepository.Update(webBlogs);
            SaveWebBlogs();
        }
    }
}
