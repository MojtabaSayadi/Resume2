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
    public class WebContactUsRepository : IWebContactUsRepository
    {
        private readonly Resume2Context context;

        public WebContactUsRepository(Resume2Context _context)
        {
            context=_context;
        }

        public void Add(WebContactUs webContactUs)
        {
            context.webContactUs.Add(webContactUs);
        }

        public void Delete(int id)
        {
           context.webContactUs.Remove(GetById(id));
        }

        public void Delete(WebContactUs webContactUs)
        {
            context.webContactUs.Remove(webContactUs);
        }

        public List<WebContactUs> GetAll()
        {
            return context.webContactUs.ToList();
        }

        public WebContactUs GetById(int id)
        {
            return context.webContactUs.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webContactUs.Any(p=>p.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebContactUs webContactUs)
        {
            context.webContactUs.Update(webContactUs);
        }
    }
}
