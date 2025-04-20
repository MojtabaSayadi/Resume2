using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Web;
using Resume2.Domain.ViewModels.WebDoc.Client;

namespace Resume2.Core.Services.Interfaces
{
     public interface IWebDocDetailsService
    {
        WebDocDetails GetWebDocDetailsById(int id);
        List<WebDocDetails> GetWebDocDetails();
        List<WebDocDetailsViewModel> GetAllWebDocDetailsViewModel(); /// WebDocDetailsViewModel
        bool IsExist(int Id);
        void AddWebDocDetails(WebDocDetails webDocDetails);
        void UpdateWebDocDetails(WebDocDetails webDocDetails);
        void DeleteWebDocDetails(int id);
        void DeleteWebDocDetails(WebDocDetails webDocDetails);
        void SaveWebDocDetails();

    }
}
