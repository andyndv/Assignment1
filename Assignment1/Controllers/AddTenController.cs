﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        public int Get(int id)
        {
            int Add = id + 10;
            return Add;
        }
    }
}
