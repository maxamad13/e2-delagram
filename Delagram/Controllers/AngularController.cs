using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Delagram.Controllers
{
    public class AngularController : ApiController
    {
        public string Get()
        {
            return "<div>Hello!</div>";
        }
    }
}
