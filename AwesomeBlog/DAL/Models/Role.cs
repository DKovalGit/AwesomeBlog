using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AwesomeBlog.DAL.Models
{
    public class Role:IdentityRole
    {
        public string Comment { get; set; }
        public Role() : base() { }
        public Role(string roleName, string roleComment) : base(roleName) 
        { 
            Comment = roleComment; 
        }
    }
}
