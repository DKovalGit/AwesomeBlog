using AwesomeBlog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Repositories
{
    public class TagsRepository: Repository<Tag>
    {
        public TagsRepository(ApplicationDbContext db): base(db)
        {
   
        }

    }
}
