using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Common;

namespace Resume2.Domain.ViewModels.WebDoc.ContactUs.Admin
{
    public class AdminContactUsViewModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        public string PhoneNumber { get; set; }


        public string Message { get; set; }
        public string CreatedDateS { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class FilterAdminContactUsViewModel : Paging.BasePaging<AdminContactUsViewModel>
    {

    }
}
