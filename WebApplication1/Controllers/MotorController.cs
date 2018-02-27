using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class MotorController : ApiController
    {

        // PUT api/motor/5
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine(value);
            //todo
        }

    }
}
