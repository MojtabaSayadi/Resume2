using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebProjectsService
    {
        WebProjects GetWebProjectsById(int id);
        List<WebProjects> GetWebProjects();
        bool IsExist(int Id);
        void AddWebProjects(WebProjects webProjects);
        void UpdateWebProjects(WebProjects webProjects);
        void DeleteWebProjects(int id);
        void DeleteWebProjects(WebProjects webProjects);
        void SaveWebProjects();
    }
}
