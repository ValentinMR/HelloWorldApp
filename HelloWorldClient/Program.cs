using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClient
{
    class Program
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string message;

            try
            {
                //Gets the message from the API
                MessageFromAPI messageFromAPI = new MessageFromAPI();
                message = messageFromAPI.GetMessage();

                //Writes the message to a given output
                Output output = new Output();
                output.Write(message);

                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine("An exception has ocurred: " + ex.Message);
            }
        }
    }
}
