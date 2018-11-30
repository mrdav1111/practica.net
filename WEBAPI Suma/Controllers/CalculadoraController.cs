using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services;

namespace WEBAPI_Suma.Controllers
{
    public class CalculadoraController : ApiController
    {
        [WebMethod]
        [HttpGet]
        public int Suma([FromUri] int a, [FromUri] int b)
        {
            return a + b;
        }
    }
}
