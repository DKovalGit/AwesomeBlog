using AwesomeBlog.DAL.Models;
using AwesomeBlog.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.PLL.Controllers
{
    public class TagsController : Controller
    {
        private readonly IRepository<Tag> _repoTag;

        public TagsController(IRepository<Tag> repoTag)
        {
            _repoTag = repoTag;
        }

        public IActionResult Index()
        {

            var tags = _repoTag.GetAll();
            foreach(var tag in tags)
            {
                Console.WriteLine(tag.Name);
            }

            return View();
        }
    }
}
