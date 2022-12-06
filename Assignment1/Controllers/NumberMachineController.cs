using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        public int Get(int id)
        {

            int product = id * id - 24 + 99 / 2;
            return product;
        }
    }
}
