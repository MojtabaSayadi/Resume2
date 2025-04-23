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
    public class WebServicesRepository : IWebServicesRepository
    {
        private readonly Resume2Context context;

        public WebServicesRepository(Resume2Context _context)
        {
            context = _context;
        }
        public void Add(WebServices webServices)
        {
            context.webServices.Add(webServices);
        }

        public void Delete(int id)
        {
            context.webServices.Remove(GetById(id));
        }

        public void Delete(WebServices webServices)
        {
            context?.webServices.Remove(webServices);
        }

        public List<WebServices> GetAll()
        {
            return context.webServices.ToList();
        }

        public WebServices GetById(int id)
        {
            return context.webServices.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webServices.Any(x => x.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebServices webServices)
        {
            context.webServices.UpdateRange(webServices);
        }
    }
}
