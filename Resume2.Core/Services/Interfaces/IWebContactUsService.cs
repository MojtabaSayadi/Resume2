﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Core.Services.Interfaces
{
    public interface IWebContactUsService
    {
        WebContactUs GetWebContactUsById(int id);
        List<WebContactUs> GetWebContactUss();
        bool IsExist(int Id);
        void AddWebContactUs(WebContactUs webContactUs);
        void UpdateWebContactUs(WebContactUs webContactUs);
        void DeleteWebContactUs(int id);
        void DeleteWebContactUss(WebContactUs webContactUs);
        void SaveWebContactUs();
    }
}
