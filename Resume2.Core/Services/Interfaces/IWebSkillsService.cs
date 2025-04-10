using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebSkillsService
    {
        WebSkills GetWebSkillsById(int id);
        List<WebSkills> GetWebSkills();
        bool IsExist(int Id);
        void AddWebSkills(WebSkills webSkills);
        void UpdateWebSkills(WebSkills webSkills);
        void DeleteWebSkills(int id);
        void DeleteWebSkills(WebSkills webSkills);
        void SaveWebSkills();

    }
}
