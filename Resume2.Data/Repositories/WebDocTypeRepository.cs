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
    public class WebDocTypeRepository :IWebDocTypeRepository
    {

        private readonly Resume2Context context;

        public WebDocTypeRepository(Resume2Context _context)
        {
            context = _context;
        }

        public void Add(WebDocType webDocType)
        {
            context.webDocType.Add(webDocType);
        }

        public void Delete(int id)
        {
            context.webDocType.Remove(GetById(id));
        }

        public void Delete(WebDocType webDocType)
        {
            context.webDocType.Remove(webDocType);

        }

        public List<WebDocType> GetAll()
        {
           return context.webDocType.ToList();
        }

        public WebDocType GetById(int id)
        {
            return context.webDocType.Find(id) ;
        }

        public bool IsExist(int Id)
        {
            return context.webDocType.Any(d => d.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebDocType webDocType)
        {
            context.webDocType.Update(webDocType);
        }
    }
}
