using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume2.Domain.Models.Web
{
    public class WebBlogs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength (50)]
        public string ImageFile { get; set; }
        [MaxLength (1000)]
        public string Url { get; set; }
    }
}
//A blog is an informational website consisting of discrete, 
//    often informal diary-style text entries.
//    Posts are typically displayed in reverse chronological order 
//    so that the most recent post appears first, 
//    at the top of the web page
