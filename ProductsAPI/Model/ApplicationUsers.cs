﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Model
{
    public class ApplicationUsers : IdentityUser
    {
        [MaxLength(55)]
        public string FirstName { get; set; }
        [MaxLength(55)]
        public string LastName { get; set; }
    }
}
