﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        public string Post() 
        {
            string greeting = "Hello World!";
            return greeting;
        } 
    }
}
