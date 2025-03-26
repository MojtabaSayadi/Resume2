using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume2.Domain.Models.Auth
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName{ get; set; }
        public string Password { get; set; }
    }
}
