using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Configuration;

namespace HelloWorldClient
{
    class MessageFromAPI
    {
        string message = String.Empty;

        /// <summary>
        /// Connects to the API and gets an string message using a get request
        /// </summary>
        /// <returns></returns>
        internal string GetMessage()
        {
            string APIBaseAddress = ConfigurationManager.AppSettings["APIBaseAddress"];
            using (var client = new HttpClient())
            {
                //Obtener la direccion desde el web config
                client.BaseAddress = new Uri(APIBaseAddress);

                var responseTask = client.GetAsync("/api/Greeting");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    message = readTask.Result;
                }
                else
                {
                    message = "There was a problem consumming the API";
                }
            }
           
            return message;
        }
    }
}
