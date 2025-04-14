using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;

namespace Resume2.Domain.Models.Web
{
    public class WebDocDetails
    {
        public int  Id {  get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int TypeId {  get; set; }

        #region Relation

        [ForeignKey("TypeId")]
        public WebDocType webDocType { get; set; }
        #endregion
    }
}
