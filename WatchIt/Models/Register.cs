﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchIt.Models
{
    public class Register
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}