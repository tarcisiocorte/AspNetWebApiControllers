using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tccp.Data;
using Tccp.Models;

namespace Tccp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Post> Get(
            [FromServices]ApplicationDbContext context)
        {
            var post = new Post()
                {Id = Guid.NewGuid(), Created = Convert.ToDateTime("10/10/2010"), Message = "doing some tests"};

            context.Posts.Add(post);
            context.SaveChanges();
            return context.Posts.ToArray();
        }

        [HttpPost]
        public IActionResult Post(Post post,[FromServices]ApplicationDbContext context)
        {
            post.Id = Guid.NewGuid();
            post.Created = DateTime.Now;
            context.Posts.Add(post);
            context.SaveChanges();
            return Ok();
        }
    }
}