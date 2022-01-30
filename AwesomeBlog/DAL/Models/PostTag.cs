using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Models
{
    [Table("PostTags")]
    [Index("UserPostId", "TagId", IsUnique = true, Name = "UQ_PostTag")]
    public class PostTag
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserPostId { get; set; }
        public UserPost UserPost { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
