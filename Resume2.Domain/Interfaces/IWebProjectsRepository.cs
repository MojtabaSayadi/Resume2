using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Domain.Interfaces
{
    public interface IWebProjectsRepository
    {
        WebProjects GetById(int id);// find
        bool IsExist(int Id);
        List<WebProjects> GetAll();// select *
        void Add(WebProjects webProjects);// insert
        void Update(WebProjects webProjects);// update
        void Delete(int id);// delete
        void Delete(WebProjects webProjects);
        void Save(); // commit

    }
}
