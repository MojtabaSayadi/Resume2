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
        [MaxLength(200, ErrorMessage = " it is too long")]
        public string Explain1 { get; set; }

        [MaxLength(1000, ErrorMessage = " it is too long")]
        public string Explain2 { get; set; }

        [MaxLength(5000, ErrorMessage = " it is too long")]
        public string AboutMe { get; set; }
        public string InstagarmAdd {  get; set; }
        public string GitHubAdd {  get; set; }
    }
}
