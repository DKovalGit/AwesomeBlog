using AwesomeBlog.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Models
{
    [Table("UserPosts")]
    public class UserPost
    {        
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR")]
        [StringLength(8000)]
        public string PostText { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
