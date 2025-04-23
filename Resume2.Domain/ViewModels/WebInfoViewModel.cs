using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume2.Domain.ViewModels
{
    public class MyInfoOnWebViewModel
    {
        public string FullName { get; set; }
        public string Major { get; set; }
        public string ShortDescription { get; set; }

        public string ImageName { get; set; }
        public string AboutMe { get; set; }

        public string Email { get; set; }
        
        public string Phone_no { get; set; }
       
        public string Address { get; set; }
        public string ResumeImge { get; set; }
    }

}
