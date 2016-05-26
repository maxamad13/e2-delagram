using Delagram.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Delagram.DAL
{
    public class DelagramContext : ApplicationDbContext
    {
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
    }
}