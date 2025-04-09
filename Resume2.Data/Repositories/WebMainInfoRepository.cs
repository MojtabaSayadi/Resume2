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
    public class WebMainInfoRepository : IWebMainInfoRepository
    {
        private Resume2Context context;

        public WebMainInfoRepository(Resume2Context _context)
        {
            context = _context;
        }
        public void Add(WebMainInfo webMainInfo)
        {
            context.Add(webMainInfo);
        }

        public void Delete(int id)
        {
            context.Remove(GetById(id));
        }

        public void Delete(WebMainInfo webMainInfo)
        {
            context.Remove(webMainInfo);
        }

        public List<WebMainInfo> GetAll()
        {
            return context.webMainInfo.ToList();
        }

        public WebMainInfo GetById(int id)
        {
            return context.webMainInfo.Find(id);
        }

        public WebMainInfo GetWebInfo()
        {
            return context.webMainInfo.FirstOrDefault();
        }

        public bool IsExist(int Id)
        {
            return context.webMainInfo.Any(x => x.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebMainInfo webMainInfo)
        {
            context.Update(webMainInfo);
        }
    }
}
