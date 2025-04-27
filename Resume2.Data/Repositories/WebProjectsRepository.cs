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
    public class WebProjectsRepository :IWebProjectsRepository
    {
        private readonly Resume2Context context;

        public WebProjectsRepository(Resume2Context _context)
        {
            context = _context;
        }

        public void Add(WebProjects webProjects)
        {
            context.webProjects.Add(webProjects);
        }

        public void Delete(int id)
        {
            context.webProjects.Remove(GetById(id));
        }

        public void Delete(WebProjects webProjects)
        {
            context.webProjects.Remove(webProjects);
        }

        public List<WebProjects> GetAll()
        {
            return context.webProjects.ToList();
        }

        public WebProjects GetById(int id)
        {
            return  context.webProjects.Find(id);
        }

        public bool IsExist(int Id)
        {
            return (context.webProjects.Any(p => p.Id == Id));
        }

        public void Save()
        {
           context.SaveChanges();
        }

        public void Update(WebProjects webProjects)
        {
            context.webProjects.Update(webProjects);
        }
    }
}
