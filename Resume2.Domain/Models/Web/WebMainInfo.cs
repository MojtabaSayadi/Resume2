using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume2.Domain.Models.Web
{
    public class WebMainInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100,ErrorMessage =" name is too long")]
        public string FullName { get; set; }
        [MaxLength(100, ErrorMessage = " name is too long")]
        public string Major { get; set; }


        [MaxLength(2000, ErrorMessage = " it is too long")]
        public string ShortDescription { get; set; }

        [MaxLength(20, ErrorMessage = " it is too long")]
        public string Avatar { get; set; }

        [MaxLength(5000, ErrorMessage = " it is too long")]
        public string AboutMe { get; set; }
       
    }
}
