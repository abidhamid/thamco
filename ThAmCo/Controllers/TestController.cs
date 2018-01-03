using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThAmCo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ContentResult Test1()
        {
            return Content("This is a test page");
        }

        [Authorize]
        public ContentResult Test2()
        {
            return Content("This is a secret test page");
        }

        [Authorize(Roles = "manager")]
        public ContentResult Test3()
        {
            return Content("This is a secret secret test page");
        }
    }
}