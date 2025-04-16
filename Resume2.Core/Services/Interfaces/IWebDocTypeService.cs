using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels.WebDoc.Client;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebDocTypeService
    {
        WebDocType GetWebDocTypeById(int id);
        List<WebDocType> GetWebDocType();
        List<WebDocViewModel> GetAllWebDocTypeViewModel();
        bool IsExist(int Id);
        void AddWebDocType(WebDocType webDocType);
        void UpdateWebDocType(WebDocType webDocType);
        void DeleteWebDocType(int id);
        void DeleteWebDocType(WebDocType webDocType);
        void SaveWebDocType();

    }
}
