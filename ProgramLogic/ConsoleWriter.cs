using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Writes a message
        /// </summary>
        /// <param name="info">Content of the message</param>
        public void WriteMessage(string info)
        {
            Console.WriteLine(info);
        }
    }
}
