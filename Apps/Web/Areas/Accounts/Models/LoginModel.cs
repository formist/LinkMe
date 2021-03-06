﻿using LinkMe.Apps.Asp.Json;
using LinkMe.Apps.Asp.Json.Models;

namespace LinkMe.Web.Areas.Accounts.Models
{
    public class LoginModel
        : JsonRequestModel
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
