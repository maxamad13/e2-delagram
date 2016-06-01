using Delagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Delagram.Controllers
{
    public class PostController : ApiController
    {
        public IEnumerable<Post> Get()
        {
            List<Post> posts = new List<Post>();
            posts.Add(new Post { ImageUrl = "https://placekitten.com/400/300", Caption="Hey Caption 1"});
            posts.Add(new Post { ImageUrl = "https://placekitten.com/400/300", Caption = "Hey Caption 2" });
            return posts;
        }
    }
}
