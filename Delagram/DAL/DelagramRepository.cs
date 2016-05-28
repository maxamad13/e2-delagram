using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delagram.DAL
{
    public class DelagramRepository
    {
        public DelagramContext context { get; set; }
        
        public DelagramRepository()
        {
            context = new DelagramContext();
        }

        // Allows us to isolate Repo from context during testing
        public DelagramRepository(DelagramContext _context)
        {
            context = _context;
        }

        public int GetPostCount()
        {
            return context.Posts.Count();
        }
    }
}