using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Data.Context;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Web;

namespace Resume2.Data.Repositories
{
    public class WebBlogsRepository : IWebBlogsRepository
    {
        private readonly Resume2Context context;

        public WebBlogsRepository(Resume2Context _context)
        {
            context = _context;
        }
        public void Add(WebBlogs webBlog)
        {
            context.webBlogs.Add(webBlog);
        }

        public void Delete(int id)
        {
            context.webBlogs.Remove(GetById(id));
        }

        public void Delete(WebBlogs webBlog)
        {
            context.webBlogs.Remove(webBlog);

        }

        public List<WebBlogs> GetAll()
        {
            return context.webBlogs.ToList();
        }

        public WebBlogs GetById(int id)
        {
            return context.webBlogs.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webBlogs.Any(b => b.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebBlogs webBlog)
        {
            context.webBlogs.Update(webBlog);
        }
    }
}
