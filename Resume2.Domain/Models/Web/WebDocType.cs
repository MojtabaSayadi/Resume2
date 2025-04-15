using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Resume2.Domain.Models.Web
{
    public class WebDocType
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Title_En  { get; set; }

        #region Relation
        public List<WebDocDetails> webDocDetails { get; set; }
        
        #endregion
    }
}
