using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Models
{

    [Table("PostComments")]
    public class PostComment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid UserPostId { get; set; }
        public UserPost UserPost { get; set; }
        
        [Column(TypeName = "VARCHAR")]
        [StringLength(8000)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
