using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogic;
using System.Configuration;

namespace HelloWorldClient
{
    class Output
    {
        IWriter objWriter;

        /// <summary>
        /// Writes a message to a given target
        /// </summary>
        /// <param name="info">Contains the information that is going to be displayed in the message</param>
        public void Write(string info)
        {
            string targetOutput = ConfigurationManager.AppSettings["targetOutput"];
            WriterFactory factory = new WriterFactory(targetOutput);
            
            objWriter = factory.Create();

            objWriter.WriteMessage(info);
        }
    }
}
