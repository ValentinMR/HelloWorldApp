using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProgramLogic;

namespace HelloWorldAPI.Controllers
{
    /// <summary>
    /// Controller used to expose the message to the client
    /// </summary>
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Get request used to provide a message to the client
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetMessage()
        {
            Message objMessage = new Message();

            return objMessage.GetMessage();
        }
    }
}
