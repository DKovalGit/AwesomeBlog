using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace AwesomeBlog.DAL.Models
{
    public class UserRole:IdentityUserRole<string>
    {
    }
}
