﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_LOGIN.Models
{
    public class RegisterViewModel
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }  





    }
}