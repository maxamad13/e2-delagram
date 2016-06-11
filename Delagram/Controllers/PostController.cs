using Delagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Delagram.DAL;

namespace Delagram.Controllers
{
    public class PostController : ApiController
    {
        DelagramRepository Repo = new DelagramRepository();

        public IEnumerable<Post> Get()
        {
            List<Post> posts = Repo.GetPosts();
            return posts;
        }
    }
}
