using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        public int Get(int id)
        {
            int squared = id * id;
            return squared;
        }
    }
}
