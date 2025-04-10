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
    public class WebSkillsRepository :IWebSkillsRepository
    {

        private readonly Resume2Context context;

        public WebSkillsRepository(Resume2Context _context)
        {
            context = _context;
        }

        public void Add(WebSkills webSkills)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(WebSkills webSkills)
        {
            throw new NotImplementedException();
        }

        public List<WebSkills> GetAll()
        {
            throw new NotImplementedException();
        }

        public WebSkills GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(WebSkills webSkills)
        {
            throw new NotImplementedException();
        }
    }
}
